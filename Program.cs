using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the key: ");
            string key = Console.ReadLine();

            if (key == " ")
            {
                DocumentWorker worker1 = new DocumentWorker();
                worker1.OpenDocument();
                worker1.EditDocument();
                worker1.SaveDocument();
            }
            if (key == "pro")
            {
                ProDocumentWorker worker = new ProDocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
            if (key == "exp")
            {
                ExpertDocumentWorker expert = new ExpertDocumentWorker();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }
        }
    }
}