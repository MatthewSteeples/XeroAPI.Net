﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace XeroApi.Model
{
    public abstract class EndpointModelBase : ModelBase
    {
        
    }

    public abstract class ModelBase : IModelBase
    {
        [XmlAttribute("status")]
        public ValidationStatus ValidationStatus 
        { 
            get; 
            set; 
        }

        public List<ValidationError> ValidationErrors
        { 
            get;
            set;
        }
        
        public List<Warning> Warnings
        {
            get; 
            set;
        }
    }

    public interface IModelBase
    {

    }

    public enum ValidationStatus
    {
        OK,
        WARNING,
        ERROR
    }

    public struct Warning
    {
        public string Message;
    }

    public struct ValidationError
    {
        public string Message;
    }
}
