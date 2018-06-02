﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.DyRepository
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository
    {
        int Insert(TEntity entity);
        int Delete(object reqParams);
        [Statement(Id = "Delete")]
        int DeleteById(string Id);
        int Update(TEntity entity);
        [Statement(Id = "Update")]
        int DyUpdate(object dyObj);
        IEnumerable<TEntity> Query(object reqParams);
        IEnumerable<TEntity> QueryByPage(object reqParams);
        [Statement(Execute = ExecuteBehavior.ExecuteScalar)]
        int GetRecord(object reqParams);
        TEntity GetEntity(object reqParams);
        [Statement(Id = "GetEntity")]
        TEntity GetById(string Id);
        [Statement(Execute = ExecuteBehavior.ExecuteScalar)]
        int IsExist(object reqParams);
    }
}
