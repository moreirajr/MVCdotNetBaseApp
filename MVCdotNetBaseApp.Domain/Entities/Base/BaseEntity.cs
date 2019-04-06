using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCdotNetBaseApp.Domain.Entities.Base
{
	public class BaseEntity
	{
		public Guid Id { get; set; }

		public BaseEntity()
		{
			Id = Guid.NewGuid();
		}

		[NotMapped]
		public string ValidationMessage { get; set; }
	}
}