using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_SpecialExample
{
    public class CustomError
    {
        // fields
        // Error Code - Message
        string _errorCode;
        string _errorMessage;

        // constructor
        public CustomError(string errorCode, string errorMessage)
        {
            _errorCode = errorCode;
            _errorMessage = errorMessage;
        } // CustomError


        // properties
        public string ErrorCode { get => _errorCode; }
        public string ErrorMessage { get => _errorMessage; }

        // New : override ToString()
        // This will allow us to change what displays
        // when we call the ToString() on instanced object
        // New Keyword : override ( to change the functionality of a parent classes method )
        public override string ToString()
        {
            return $"{this._errorCode} - {this._errorMessage}";
        }


    } // main
     
} // namespace
