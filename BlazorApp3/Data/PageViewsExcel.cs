using DataAccessLibrary.Models;
using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Net.NetworkInformation;


using DataAccessLibrary;




namespace BlazorApp3.Data
{
    public class PageViewsExcel
    {

        public void GenerateExcel(IJSRuntime iJSRuntime)
        {
            byte[] fileContent;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("UserPageViews");

                #region Headers

                worksheet.Cells[1, 1].Value = "WebPage";
                worksheet.Cells[1, 1].Style.Font.Size = 12;
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                worksheet.Cells[1, 2].Value = "Capfin";
                worksheet.Cells[1, 2].Style.Font.Size = 12;
                worksheet.Cells[1, 2].Style.Font.Bold = true;
                worksheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                #endregion


                #region First Row / Maybe column will try and see

                worksheet.Cells[2, 1].Value = "0";
                worksheet.Cells[2, 1].Style.Font.Size = 12;
                worksheet.Cells[2, 1].Style.Font.Bold = true;
                worksheet.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                worksheet.Cells[2, 2].Value = "0";
                worksheet.Cells[2, 2].Style.Font.Size = 12;
                worksheet.Cells[2, 2].Style.Font.Bold = true;
                worksheet.Cells[2, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                #endregion


            //foreach(var finalPivData in finalPivotedDatas)
            //{
            //        for (int i = 0; i > finalPivotedDatas.Count; i++)
            //        {
            //            worksheet.Cells[1, i].Value = finalPivData.WebPage;
            //            worksheet.Cells[1, i].Style.Font.Size = 12;
            //            worksheet.Cells[1, i].Style.Font.Bold = true;
            //            worksheet.Cells[1, i].Style.Border.Top.Style = ExcelBorderStyle.Hair;
            //        }
            //}



                fileContent = package.GetAsByteArray();


            }

            iJSRuntime.InvokeAsync<PageViewsExcel>(
                "saveAsFile", "PageViewsExcel List.xlsx", Convert.ToBase64String(fileContent)
                );
        }
        
    }
}
