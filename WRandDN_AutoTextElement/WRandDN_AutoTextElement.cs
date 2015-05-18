using System;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;

using Miner.ComCategories;
using Miner.Interop;
namespace WRandDN_AutoTextElement
{
    [ComVisible(true)]
    [Guid("4c73e554-8966-3333-b7bb-5ab425108d46")]
    [ProgId("SE.WRandDN_AutoTextElement")]
    [ComponentCategory(ComCategory.MMCustomTextSources)]
    public class WRandDN_AutoTextElement : IMMAutoTextSource
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region IMMAutoTextSource Members

        public string Message
        {
            get
            {
                return null;
            }
        }

        public string ProgID
        {
            get
            {
                return "SE.WRandDN_AutoTextElement";
            }
        }

        public string Caption
        {
            get
            {
                return "SE: Work Request Name - Design Name";
            }
        }

        public bool NeedRefresh(Miner.Interop.mmAutoTextEvents eTextEvent)
        {
            return true;
            if (eTextEvent == mmAutoTextEvents.mmCreate |
                eTextEvent == mmAutoTextEvents.mmPlotNewPage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string TextString(Miner.Interop.mmAutoTextEvents eTextEvent, IMMMapProductionInfo pMapProdInfo)
        {
            try
            {
                Type t2 = Type.GetTypeFromProgID("esriFramework.AppRef");
                System.Object obj = Activator.CreateInstance(t2);
                ESRI.ArcGIS.Framework.IApplication app = obj as ESRI.ArcGIS.Framework.IApplication;
                return app.Caption.Substring(0,app.Caption.IndexOf("(") - 1);
                /*switch (eTextEvent)
                {
                    
                    case mmAutoTextEvents.mmCreate:
                        {
                            return this.Caption;
                        }
                    case mmAutoTextEvents.mmPlotNewPage:
                        {

                            return "xxx";
                        }
                    default:
                        {
                            return "";
                        }
                }*/
            }
            catch (Exception ex)
            {
                _log.Error("ERROR - ", ex);
                return "";
            }

        }

        #endregion
    
    }
}
