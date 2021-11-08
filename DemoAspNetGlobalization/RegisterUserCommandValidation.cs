using System;
using DemoAspNetGlobalization.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace DemoAspNetGlobalization
{
    public interface IRegisterUserCommandValidation
    {
        string Validate(RegisterUserCommand command);
    }
    public class RegisterUserCommandValidation : IRegisterUserCommandValidation
    {
        private readonly IStringLocalizer _localizer;
        public RegisterUserCommandValidation(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        public string Validate(RegisterUserCommand command)
        {
            if (string.IsNullOrEmpty(command.Name))
            {
                return _localizer["HelloWorld"].Value;
            }
            return string.Empty;
        }
        // public RegisterUserCommandValidation(RegisterUserCommand command)
        // {
        //     if (string.IsNullOrEmpty(command.Name))
        //     {
        //         throw new Exception(Messages.HelloWorld);
        //     }
        // }
    }

    public class RegisterUserCommand
    {
        public RegisterUserCommand(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // public bool IsValid()
        // {
        //     var validate = new RegisterUserCommandValidation(this);
        //     return true;
        // }
    }


}