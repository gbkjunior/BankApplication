﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingApplication_DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bank")]
	public partial class BankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomerTable(CustomerTable instance);
    partial void UpdateCustomerTable(CustomerTable instance);
    partial void DeleteCustomerTable(CustomerTable instance);
    #endregion
		
		public BankDataContext() : 
				base(global::BankingApplication_DAL.Properties.Settings.Default.BankConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AccountTable> AccountTables
		{
			get
			{
				return this.GetTable<AccountTable>();
			}
		}
		
		public System.Data.Linq.Table<Customer_Accounts_Table> Customer_Accounts_Tables
		{
			get
			{
				return this.GetTable<Customer_Accounts_Table>();
			}
		}
		
		public System.Data.Linq.Table<CustomerTable> CustomerTables
		{
			get
			{
				return this.GetTable<CustomerTable>();
			}
		}
		
		public System.Data.Linq.Table<TransactionTable> TransactionTables
		{
			get
			{
				return this.GetTable<TransactionTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountTable")]
	public partial class AccountTable
	{
		
		private System.Nullable<int> _Account_ID;
		
		private string _Account_Type;
		
		public AccountTable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", DbType="Int")]
		public System.Nullable<int> Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this._Account_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_Type", DbType="VarChar(15)")]
		public string Account_Type
		{
			get
			{
				return this._Account_Type;
			}
			set
			{
				if ((this._Account_Type != value))
				{
					this._Account_Type = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Accounts_Table")]
	public partial class Customer_Accounts_Table
	{
		
		private System.Nullable<int> _Customer_ID;
		
		private System.Nullable<int> _Account_ID;
		
		private System.Nullable<decimal> _Balance;
		
		public Customer_Accounts_Table()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_ID", DbType="Int")]
		public System.Nullable<int> Customer_ID
		{
			get
			{
				return this._Customer_ID;
			}
			set
			{
				if ((this._Customer_ID != value))
				{
					this._Customer_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", DbType="Int")]
		public System.Nullable<int> Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this._Account_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(10,0)")]
		public System.Nullable<decimal> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this._Balance = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerTable")]
	public partial class CustomerTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_ID;
		
		private string _Customer_Name;
		
		private string _Customer_Address;
		
		private string _Customer_Telephone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IDChanging(int value);
    partial void OnCustomer_IDChanged();
    partial void OnCustomer_NameChanging(string value);
    partial void OnCustomer_NameChanged();
    partial void OnCustomer_AddressChanging(string value);
    partial void OnCustomer_AddressChanged();
    partial void OnCustomer_TelephoneChanging(string value);
    partial void OnCustomer_TelephoneChanged();
    #endregion
		
		public CustomerTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_ID
		{
			get
			{
				return this._Customer_ID;
			}
			set
			{
				if ((this._Customer_ID != value))
				{
					this.OnCustomer_IDChanging(value);
					this.SendPropertyChanging();
					this._Customer_ID = value;
					this.SendPropertyChanged("Customer_ID");
					this.OnCustomer_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Name", DbType="VarChar(45)")]
		public string Customer_Name
		{
			get
			{
				return this._Customer_Name;
			}
			set
			{
				if ((this._Customer_Name != value))
				{
					this.OnCustomer_NameChanging(value);
					this.SendPropertyChanging();
					this._Customer_Name = value;
					this.SendPropertyChanged("Customer_Name");
					this.OnCustomer_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Address", DbType="VarChar(100)")]
		public string Customer_Address
		{
			get
			{
				return this._Customer_Address;
			}
			set
			{
				if ((this._Customer_Address != value))
				{
					this.OnCustomer_AddressChanging(value);
					this.SendPropertyChanging();
					this._Customer_Address = value;
					this.SendPropertyChanged("Customer_Address");
					this.OnCustomer_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Telephone", DbType="VarChar(20)")]
		public string Customer_Telephone
		{
			get
			{
				return this._Customer_Telephone;
			}
			set
			{
				if ((this._Customer_Telephone != value))
				{
					this.OnCustomer_TelephoneChanging(value);
					this.SendPropertyChanging();
					this._Customer_Telephone = value;
					this.SendPropertyChanged("Customer_Telephone");
					this.OnCustomer_TelephoneChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionTable")]
	public partial class TransactionTable
	{
		
		private System.Nullable<int> _Transaction_ID;
		
		private string _Transaction_Type;
		
		private string _Transaction_Date;
		
		private System.Nullable<decimal> _Amount;
		
		private System.Nullable<int> _Account_ID;
		
		private System.Nullable<int> _Customer_ID;
		
		public TransactionTable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_ID", DbType="Int")]
		public System.Nullable<int> Transaction_ID
		{
			get
			{
				return this._Transaction_ID;
			}
			set
			{
				if ((this._Transaction_ID != value))
				{
					this._Transaction_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_Type", DbType="VarChar(15)")]
		public string Transaction_Type
		{
			get
			{
				return this._Transaction_Type;
			}
			set
			{
				if ((this._Transaction_Type != value))
				{
					this._Transaction_Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_Date", DbType="VarChar(20)")]
		public string Transaction_Date
		{
			get
			{
				return this._Transaction_Date;
			}
			set
			{
				if ((this._Transaction_Date != value))
				{
					this._Transaction_Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(10,0)")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this._Amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", DbType="Int")]
		public System.Nullable<int> Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this._Account_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_ID", DbType="Int")]
		public System.Nullable<int> Customer_ID
		{
			get
			{
				return this._Customer_ID;
			}
			set
			{
				if ((this._Customer_ID != value))
				{
					this._Customer_ID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
