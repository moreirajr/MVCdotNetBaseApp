using System;
using System.ComponentModel.DataAnnotations;


namespace MVCdotNetBaseApp.Application.ViewModels
{
    public class BaseViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}