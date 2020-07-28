using SOHU.Data.Enum;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Helpers
{
    public static class ObjectHelper
    {
        public static T Initialization<T>(this T model, InitType type, int initUser) where T : BaseModel
        {
            model.DateUpdated = AppGlobal.InitDateTime;
            model.UserUpdated = initUser;
            switch (type)
            {
                case InitType.Update:
                    break;
                case InitType.Insert:
                    model.DateCreated = AppGlobal.InitDateTime;
                    model.UserCreated = initUser;
                    break;
            }
            return model;
        }
    }
}
