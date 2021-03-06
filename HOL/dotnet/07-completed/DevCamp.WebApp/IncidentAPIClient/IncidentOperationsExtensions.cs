﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IncidentAPI;
using IncidentAPI.Models;
using Microsoft.Rest;

namespace IncidentAPI
{
    public static partial class IncidentOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        public static string ClearData(this IIncidentOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).ClearDataAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> ClearDataAsync(this IIncidentOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.ClearDataWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='newIncident'>
        /// Required.
        /// </param>
        public static string CreateIncident(this IIncidentOperations operations, Incident newIncident)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).CreateIncidentAsync(newIncident);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='newIncident'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> CreateIncidentAsync(this IIncidentOperations operations, Incident newIncident, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.CreateIncidentWithOperationResponseAsync(newIncident, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        public static string GetAllIncidents(this IIncidentOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).GetAllIncidentsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetAllIncidentsAsync(this IIncidentOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetAllIncidentsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        public static int GetAllIncidentsCount(this IIncidentOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).GetAllIncidentsCountAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<int> GetAllIncidentsCountAsync(this IIncidentOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<int> result = await operations.GetAllIncidentsCountWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='incidentId'>
        /// Required.
        /// </param>
        public static string GetById(this IIncidentOperations operations, string incidentId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).GetByIdAsync(incidentId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='incidentId'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetByIdAsync(this IIncidentOperations operations, string incidentId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetByIdWithOperationResponseAsync(incidentId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        public static int GetIncidentCount(this IIncidentOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).GetIncidentCountAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<int> GetIncidentCountAsync(this IIncidentOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<int> result = await operations.GetIncidentCountWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        public static string SampleData(this IIncidentOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).SampleDataAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> SampleDataAsync(this IIncidentOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.SampleDataWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='incidentId'>
        /// Required.
        /// </param>
        /// <param name='newIncident'>
        /// Required.
        /// </param>
        public static string UpdateIncident(this IIncidentOperations operations, string incidentId, Incident newIncident)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIncidentOperations)s).UpdateIncidentAsync(incidentId, newIncident);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IncidentAPI.IIncidentOperations.
        /// </param>
        /// <param name='incidentId'>
        /// Required.
        /// </param>
        /// <param name='newIncident'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> UpdateIncidentAsync(this IIncidentOperations operations, string incidentId, Incident newIncident, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.UpdateIncidentWithOperationResponseAsync(incidentId, newIncident, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
