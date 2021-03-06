﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorViewModel_ALL.cs" company="NSW RFS">
//   Copyright 2014 NSW Rural Fire Service, NSW Government, Australia
// </copyright>
// <summary>
//   Defines the ErrorViewModel_ALL type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NSWRFS.WebAPI.Core.Models
{
    using System;

    using NSWRFS.WebAPI.Core.Exceptions;

    /// <summary>
    /// The error view model_ all.
    /// </summary>
    public class ErrorViewModel_ALL
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel_ALL"/> class.
        /// </summary>
        /// <param name="ex">
        /// The Business Exception.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Exception must not be null
        /// </exception>
        public ErrorViewModel_ALL(BusinessException ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException("ex");
            }

            this.Description = "Exception";
            this.Message = ex.Message;
            this.Code = ex.Code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel_ALL"/> class.
        /// </summary>
        /// <param name="ex">
        /// The Exception.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Exception must not be null
        /// </exception>
        public ErrorViewModel_ALL(Exception ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException("ex");
            }

            this.Description = "Critical Exception";
            this.Message = "A critical system error occurred. Please try again or contact the administrator.";
            this.Code = "-1";
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public string Code { get; internal set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; internal set; }
    }
}