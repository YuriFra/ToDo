using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Item
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Message { get; set; }
       [DataType((DataType.Date))]
       public DateTime Due { get; set; }
    }
}