﻿using UnityEngine;
using System;

namespace WooshiiAttributes
    {
    [AttributeUsage (AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ArrayElementsAttribute : PropertyAttribute
        {
        public ArrayElementsAttribute()
            {

            }
        }
    }