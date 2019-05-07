﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql.Interface {
	public interface ISelect<T1, T2, T3, T4, T5, T6, T7, T8> : ISelect0<ISelect<T1, T2, T3, T4, T5, T6, T7, T8>, T1> where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {

		bool Any(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp);
		Task<bool> AnyAsync(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp);

		DataTable ToDataTable<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select);
		Task<DataTable> ToDataTableAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select);

		List<TReturn> ToList<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select);
		Task<List<TReturn>> ToListAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select);
		string ToSql<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>> select);

		TReturn ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, TReturn>> select);
		Task<TReturn> ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, TReturn>> select);

		TMember Sum<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		Task<TMember> SumAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		TMember Min<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		Task<TMember> MinAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		TMember Max<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		Task<TMember> MaxAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		TMember Avg<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		Task<TMember> AvgAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> Where(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp);
		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> exp);

		ISelectGrouping<TKey, (T1, T2, T3, T4, T5, T6, T7, T8)> GroupBy<TKey>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey>> exp);

		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
		ISelect<T1, T2, T3, T4, T5, T6, T7, T8> OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TMember>> column);
	}
}