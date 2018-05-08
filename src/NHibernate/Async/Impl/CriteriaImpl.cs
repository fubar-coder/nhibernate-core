﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Util;

namespace NHibernate.Impl
{
	using System.Threading.Tasks;
	public partial class CriteriaImpl : ICriteria, ISupportEntityJoinCriteria
	{

		public async Task<IList> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			var results = new List<object>();
			await (ListAsync(results, cancellationToken)).ConfigureAwait(false);
			return results;
		}

		public async Task ListAsync(IList results, CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			Before();
			try
			{
				await (session.ListAsync(this, results, cancellationToken)).ConfigureAwait(false);
			}
			finally
			{
				After();
			}
		}

		public async Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			List<T> results = new List<T>();
			await (ListAsync(results, cancellationToken)).ConfigureAwait(false);
			return results;
		}

		public async Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			object result = await (UniqueResultAsync(cancellationToken)).ConfigureAwait(false);
			if (result == null && typeof (T).IsValueType)
			{
				return default(T);
			}
			else
			{
				return (T) result;
			}
		}

		public async Task<object> UniqueResultAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			return AbstractQueryImpl.UniqueElement(await (ListAsync(cancellationToken)).ConfigureAwait(false));
		}
		public sealed partial class Subcriteria : ICriteria
		{

			public Task<IList> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled<IList>(cancellationToken);
				}
				return root.ListAsync(cancellationToken);
			}

			public Task ListAsync(IList results, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled<object>(cancellationToken);
				}
				return root.ListAsync(results, cancellationToken);
			}

			public Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled<IList<T>>(cancellationToken);
				}
				return root.ListAsync<T>(cancellationToken);
			}

			public Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled<T>(cancellationToken);
				}
				return root.UniqueResultAsync<T>(cancellationToken);
			}

			public Task<object> UniqueResultAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled<object>(cancellationToken);
				}
				return root.UniqueResultAsync(cancellationToken);
			}
		}
	}
}