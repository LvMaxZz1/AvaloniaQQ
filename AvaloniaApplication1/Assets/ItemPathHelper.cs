using System;
using System.IO;

namespace AvaloniaApplication1.Assets;

public class ItemPathHelper
{
    private static readonly string BasePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", ".."));
    public static readonly string LogoPath = Path.Combine(BasePath,"Assets/测试狗狗.jpg");
}