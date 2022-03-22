using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7_New.Patterns
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Получатель для удаления элемента
    class ShopDelItems
    {
        public void DeleteItem()
        {
            //Удалить элемент
        }

        public void ReturnItem()
        {
            //Вернуть элеменет
        }
    }

    class ShoopDelItemsCommand : ICommand
    {
        ShopDelItems shopDel;
        public ShoopDelItemsCommand(ShopDelItems shopdel)
        {
            shopDel = shopdel;
        }
        public void Execute()
        {
            shopDel.DeleteItem();
        }
        public void Undo()
        {
            shopDel.ReturnItem();
        }
    }

    // Invoker - инициатор 
    class Pult
    {
        ICommand command;

        public Pult() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void DelItem()
        {
            command.Execute();
        }
        public void ReturnItem()
        {
            command.Undo();
        }
    }
}
