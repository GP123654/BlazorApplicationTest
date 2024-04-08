//namespace BlazorApp3.wwwroot.js
//{
//    public class SaveAsFile
//    {
//    }
//}



function saveAsFile(filename, bytesBase64) {

    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + bytesBase64; //"data:application/octet-stream;base64,"
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}