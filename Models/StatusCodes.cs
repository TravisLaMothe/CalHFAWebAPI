using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    class StatusCodes
    {
        public int StatusCode { get; set; }
        public string Description { get; set; }
        public string BusinessUnit { get; set; }
        public string NotesAndAssumptions { get; set; }
        public int ConversationCategoryID { get; set; }
    }
}