using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_api_mongodb.Core.Commons
{
    public class Constants
    {
        public struct AppSettings
        {
            public const string Client_URL = "AppSettings:Client_URL";
            public const string CorsPolicy = "AppSettings:reactPolicy";
        }

        public struct JWT
        {
            public const string Key = "AppSettings:JWT:key";
            public const string Issuer = "AppSettings:JWT:Issuer";
            public const string Audience = "AppSettings:JWT:Audience";
            public const string TokenExpiresInMinute 
                = "AppSettings:JWT:TokenExpiresInMinute";
            public const string RefreshTokenValidityInDays 
                = "AppSettings:JWT:RefreshTokenValidityInDays";
        }

        public struct StatusMessage
        {
            public const string RegisterSuccess = "Registered successfully";
            public const string LoginSuccess = "Login Successfully";
            public const string RefreshTokenSuccess = "Refresh Token Successfully";
            public const string InvaildPassword = "Invalid Password";
            public const string NotFoundUser = "User not found";
            public const string Success = "OK";
            public const string No_Data = "No Data";
            public const string Fetching_Success = "Fetching data successfully";
            public const string Could_Not_Create = "Could not create";
            public const string No_Delete = "No Deleted";
            public const string DuplicateUser = "User duplicate";
            public const string DuplicatePosition = "Position is Duplicate";
            public const string DuplicateData = "Date is Duplicate";
            public const string DuplicateId = "ID duplicate";
            public const string DuplicateName = "Name duplicate";
            public const string Cannot_Update_Data = "Cannot Update Data";
            public const string Cannot_Map_Data = "Cannot Map Data";
            public const string UserInActive = "User not active";
            public const string SaveSuccessfully = "saved";
            public const string InsertSuccessfully = "Insert success";
            public const string UpdateSuccessfully = "Updated";
            public const string DeleteSuccessfully = "Deleted";
            public const string MappingError = "Data can't mapping";
            public const string PasswordDecryptError = "Password can't decrypt";
            public const string RefreshTokenInvalid = "Invalid access token or refresh token";
        }
      
        public struct Status
        {
            public const bool True = true;
            public const bool False = false;
            public static string Active = "A";
            public static string ActiveText = "Active";
            public static string Inactive = "I";
            public static string InactiveText = "Inactive";
        }
    }
}
