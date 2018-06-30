﻿using DietAndFitness.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DietAndFitness.Controls
{
    /// <summary>
    /// Interface for basic CRUD operations
    /// </summary>
    public interface IDataAccess 
    {
        Task<List<T>> GetAll<T>() where T : DatabaseEntity, new();
        Task<int> Insert<T>(T entity);
        Task<int> Update<T>(T entity);
        Task<int> Delete<T>(T entity);
        Task<List<T>> GetByDate<T>(DateTime date) where T : DatabaseEntity, new();
    }
}
