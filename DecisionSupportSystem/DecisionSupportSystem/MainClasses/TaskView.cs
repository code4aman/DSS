﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecisionSupportSystem.DbModel;

namespace DecisionSupportSystem.MainClasses
{
    public class TaskView : BasePropertyChanged
    {
        private string _recomendation;
        public string Recommendation 
        { 
            get { return _recomendation; } 
            set
            {
                if (value != this._recomendation)
                {
                    this._recomendation = value; RaisePropertyChanged("Recommendation");
                }
            } 
        }

        private decimal _maxEmv;
        public decimal MaxEmv
        {
            get { return _maxEmv; }
            set
            {
                if (value != this._maxEmv)
                {
                    this._maxEmv = value; RaisePropertyChanged("MaxEmv");
                }
            }
        }

        private decimal _minEol;
        public decimal MinEol
        {
            get { return _minEol; }
            set
            {
                if (value != this._minEol)
                {
                    this._minEol = value; RaisePropertyChanged("MinEol");
                }
            }
        } 
    }
}
