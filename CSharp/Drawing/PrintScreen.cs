using static System.Drawing.Imaging.ImageFormat; //Somente à partir do C# 6
using static System.Clipboard; //Somente à partir do C# 6, caso contrário, use apenas o namespace

if (ContainsImage())  
    GetImage().Save(@"image.jpeg", Jpeg);
    
//http://pt.stackoverflow.com/q/14760/101
