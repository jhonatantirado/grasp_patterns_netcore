﻿using System;
using System.Linq.Expressions;

namespace EnterprisePatterns.Api.Common.Domain.Specification
{
    public class GenericSpecification<T>
    {
        public Expression<Func<T, bool>> Expression { get; }

        public GenericSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return Expression.Compile().Invoke(entity);
        }
    }
}
