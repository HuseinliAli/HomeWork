using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserRegistered = "User is registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is not correct";
        public static string SuccessfulLogin = "Login is complted successfully";
        public static string UserAlreadyExists = "User is already exists";
        public static string AccessTokenCreated = "Access token is crated";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string ProductAdded = "Product is added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System is repairing";
        public static string ProductListed = "Products are listed";
        public static string ProductCountOfCategoryError = "Category limit is bound";
        public static string ProductNamesAreSameOrNot = "Product names are same of other";
        public static string CategoryCountBounds = "Categories count bounds";
        public static string CategoryLimitBounds = "Category count bounds";
    }
}
