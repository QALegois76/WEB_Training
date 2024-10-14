using Microsoft.AspNetCore.Mvc;
using WepApiTraining.Models;

namespace WepApiTraining.Controllers
{
    public abstract class EFControllerBase : ControllerBase
    {
        protected readonly STCDataContext _stcData;

        // constructor
        public EFControllerBase(STCDataContext stcData) 
        {
            _stcData = stcData;
        }

    }



    public class DataSingleton
    {
        private static readonly DataSingleton _instance = new DataSingleton();

        public static DataSingleton Instance => _instance;


        public STCDataContext? stcData = null;

        // constructor
        private DataSingleton()
        {
                
        }


        public void Init()
        {
             stcData = new STCDataContext();
        }
    }
}
