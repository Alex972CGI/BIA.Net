﻿namespace BIA.Net.Authentication.Business
{
#pragma warning disable CS1591 // Missing XML Comment
#pragma warning disable SA1600 // Elements must be documented
#pragma warning disable SA1402 // File may only contain one single class
    public interface ILinkedProperties
    {
        bool IsValid { get; set; }
        string Login { get; set; }
    }
#pragma warning restore CS1591 // Missing XML Comment
#pragma warning restore SA1600 // Elements must be documented
#pragma warning restore SA1402 // File may only contain one single class
}