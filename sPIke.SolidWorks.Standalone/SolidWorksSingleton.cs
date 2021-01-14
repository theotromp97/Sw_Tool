using SolidWorks.Interop.sldworks;
using System;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    internal class SolidWorksSingleton
    {
        public static SldWorks swApp;
        public static string pthSavePart = GUI.pthProjFolder;

        private SolidWorksSingleton()
        {
        }

        internal async static Task<SldWorks> getApplication() 
        { 
            if (swApp == null)
            {
                return await Task<SldWorks>.Run(() =>
                {
                    swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.application")) as SldWorks;
                    swApp.Visible = true;

                    return swApp;
                });
                
            }
            return swApp;
        }

        internal static void Dispose()
        {
            if (swApp != null)
            {
                swApp.ExitApp();
                swApp = null;
            }
        }
    }
}
