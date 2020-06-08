﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do.Model
{
   public interface IToDoManager
    {
        //Create
        Task CreateToDo(ToDo toDo);

        //Read
        Task<ToDo> GetToDo(int id);
        Task<IEnumerable<ToDo>> GetAllToDos();

        //Update
        Task<ToDo> UpdateToDo(ToDo todo, int id);

        //Delete
        Task DeleteToDo(int id);


    }
}
