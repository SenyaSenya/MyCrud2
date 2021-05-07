﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using MyCrud2;
using System;
using System.Collections;
using System.Linq;

namespace MyCrud2.OrdersModelCodeFirstDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
			if(isInDesignTime)
                return new DesignTimeUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork>(() => new OrdersModelCodeFirstDesignTimeUnitOfWork());
            return new DbUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork>(() => new OrdersModelCodeFirstUnitOfWork(() => new OrdersModelCodeFirst()));
        }
    }
}