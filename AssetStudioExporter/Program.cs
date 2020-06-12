using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetStudio
{
    static class Program
    {
        static void Main()
        {
            AssetsManager assetsManager = new AssetsManager();
            string[] files = { "F:\\Bladed\\chopghost_Data\\StreamingAssets\\shared" };
            assetsManager.LoadFiles(files);
        }
    }
}
