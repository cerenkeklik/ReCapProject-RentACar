using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string CarDeleted = "Car deleted.";
        public static string CarUpdated = "Car updated.";
        public static string CarAddingFailed = "Car adding failed.";
        public static string CarDeletingFailed = "Car deleting failed.";
        public static string CarUpdatingFailed = "Car updating failed.";
        public static string BrandAdded = "Brand added.";
        public static string BrandDeleted = "Brand deleted.";
        public static string BrandUpdated = "Brand updated.";
        public static string BrandAddingFailed = "Brand adding failed.";
        public static string BrandDeletingFailed = "Brand deleting failed.";
        public static string BrandUpdatingFailed = "Brand updating failed.";
        public static string Successful = "Successful!";
        public static string Failed = "Failed!";
        public static string CannotChooseCar = "This car is in our another customer!";
        public static string CarImagesCountExceeded = "Car images count exceeded.";
        public static string CarImageAdded = "Car image added.";
        public static string UserNotFound = "UserNotFound.";
        public static string passwordError = "Wrong Password.";
        public static string SuccessfulLogin = "Login Successfull";
        public static string UserAlreadyExists = "User already exists.";
        public static string UserRegistered = "User registered successfully.";
        public static string AccessTokenCreated = "Access token created.";
        public static string AuthorizationDenied = "Authorization denied.";
        internal static string PasswordError = "Wrong password.";
    }
}
