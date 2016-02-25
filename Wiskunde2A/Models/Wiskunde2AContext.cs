namespace Wiskunde2A.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Wiskunde2AContext : DbContext
    {
        // Your context has been configured to use a 'Wiskunde2AContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Wiskunde2A.Models.Wiskunde2AContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Wiskunde2AContext' 
        // connection string in the application configuration file.
        public Wiskunde2AContext()
            : base("name=Wiskunde2AContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Question> Questions { get; set; }
    }
    public class Question
    {
        [ScaffoldColumn(false)]
        public int QuestionID { get; set; }
        [Display(Name = "Vraag")]
        public string _Question { get; set; }
        [Display(Name = "Uitwerkingen")]
        public string Elaboration { get; set; }

        [Display(Name = "Antwoord")]
        public string Answer { get; set; }

        public bool AnsweredCorrect { get; set; }
    }
}