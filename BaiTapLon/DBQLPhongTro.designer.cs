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

namespace BaiTapLon
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
    using Microsoft.Build.Framework.XamlTypes;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PhongTro")]
	public partial class DBQLPhongTroDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertThongTinThue(ThongTinThue instance);
    partial void UpdateThongTinThue(ThongTinThue instance);
    partial void DeleteThongTinThue(ThongTinThue instance);
    partial void InsertThongTinPhong(ThongTinPhong instance);
    partial void UpdateThongTinPhong(ThongTinPhong instance);
    partial void DeleteThongTinPhong(ThongTinPhong instance);
    partial void InsertThongTinKH(ThongTinKH instance);
    partial void UpdateThongTinKH(ThongTinKH instance);
    partial void DeleteThongTinKH(ThongTinKH instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public DBQLPhongTroDataContext() : 
				base(global::BaiTapLon.Properties.Settings.Default.PhongTroConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongTroDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongTroDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongTroDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongTroDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ThongTinThue> ThongTinThues
		{
			get
			{
				return this.GetTable<ThongTinThue>();
			}
		}
		
		public System.Data.Linq.Table<ThongTinPhong> ThongTinPhongs
		{
			get
			{
				return this.GetTable<ThongTinPhong>();
			}
		}
		
		public System.Data.Linq.Table<ThongTinKH> ThongTinKHs
		{
			get
			{
				return this.GetTable<ThongTinKH>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}

        public IEnumerable<Category> Categories { get; internal set; }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThongTinThue")]
	public partial class ThongTinThue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaThue;
		
		private string _MaPhong;
		
		private string _MaKH;
		
		private System.DateTime _NgayThue;
		
		private System.Nullable<System.DateTime> _NgayTra;
		
		private EntityRef<ThongTinPhong> _ThongTinPhong;
		
		private EntityRef<ThongTinKH> _ThongTinKH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaThueChanging(string value);
    partial void OnMaThueChanged();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnNgayThueChanging(System.DateTime value);
    partial void OnNgayThueChanged();
    partial void OnNgayTraChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTraChanged();
    #endregion
		
		public ThongTinThue()
		{
			this._ThongTinPhong = default(EntityRef<ThongTinPhong>);
			this._ThongTinKH = default(EntityRef<ThongTinKH>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThue", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaThue
		{
			get
			{
				return this._MaThue;
			}
			set
			{
				if ((this._MaThue != value))
				{
					this.OnMaThueChanging(value);
					this.SendPropertyChanging();
					this._MaThue = value;
					this.SendPropertyChanged("MaThue");
					this.OnMaThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._ThongTinPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._ThongTinKH.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThue", DbType="Date NOT NULL")]
		public System.DateTime NgayThue
		{
			get
			{
				return this._NgayThue;
			}
			set
			{
				if ((this._NgayThue != value))
				{
					this.OnNgayThueChanging(value);
					this.SendPropertyChanging();
					this._NgayThue = value;
					this.SendPropertyChanged("NgayThue");
					this.OnNgayThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="Date")]
		public System.Nullable<System.DateTime> NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ThongTinPhong_ThongTinThue", Storage="_ThongTinPhong", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public ThongTinPhong ThongTinPhong
		{
			get
			{
				return this._ThongTinPhong.Entity;
			}
			set
			{
				ThongTinPhong previousValue = this._ThongTinPhong.Entity;
				if (((previousValue != value) 
							|| (this._ThongTinPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ThongTinPhong.Entity = null;
						previousValue.ThongTinThues.Remove(this);
					}
					this._ThongTinPhong.Entity = value;
					if ((value != null))
					{
						value.ThongTinThues.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(string);
					}
					this.SendPropertyChanged("ThongTinPhong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ThongTinKH_ThongTinThue", Storage="_ThongTinKH", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public ThongTinKH ThongTinKH
		{
			get
			{
				return this._ThongTinKH.Entity;
			}
			set
			{
				ThongTinKH previousValue = this._ThongTinKH.Entity;
				if (((previousValue != value) 
							|| (this._ThongTinKH.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ThongTinKH.Entity = null;
						previousValue.ThongTinThues.Remove(this);
					}
					this._ThongTinKH.Entity = value;
					if ((value != null))
					{
						value.ThongTinThues.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(string);
					}
					this.SendPropertyChanged("ThongTinKH");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThongTinPhong")]
	public partial class ThongTinPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhong;
		
		private string _DienTich;
		
		private string _GiaPhong;
		
		private string _ChuThich;
		
		private EntitySet<ThongTinThue> _ThongTinThues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnDienTichChanging(string value);
    partial void OnDienTichChanged();
    partial void OnGiaPhongChanging(string value);
    partial void OnGiaPhongChanged();
    partial void OnChuThichChanging(string value);
    partial void OnChuThichChanged();
    #endregion
		
		public ThongTinPhong()
		{
			this._ThongTinThues = new EntitySet<ThongTinThue>(new Action<ThongTinThue>(this.attach_ThongTinThues), new Action<ThongTinThue>(this.detach_ThongTinThues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienTich", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string DienTich
		{
			get
			{
				return this._DienTich;
			}
			set
			{
				if ((this._DienTich != value))
				{
					this.OnDienTichChanging(value);
					this.SendPropertyChanging();
					this._DienTich = value;
					this.SendPropertyChanged("DienTich");
					this.OnDienTichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string GiaPhong
		{
			get
			{
				return this._GiaPhong;
			}
			set
			{
				if ((this._GiaPhong != value))
				{
					this.OnGiaPhongChanging(value);
					this.SendPropertyChanging();
					this._GiaPhong = value;
					this.SendPropertyChanged("GiaPhong");
					this.OnGiaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChuThich", DbType="NVarChar(200)")]
		public string ChuThich
		{
			get
			{
				return this._ChuThich;
			}
			set
			{
				if ((this._ChuThich != value))
				{
					this.OnChuThichChanging(value);
					this.SendPropertyChanging();
					this._ChuThich = value;
					this.SendPropertyChanged("ChuThich");
					this.OnChuThichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ThongTinPhong_ThongTinThue", Storage="_ThongTinThues", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<ThongTinThue> ThongTinThues
		{
			get
			{
				return this._ThongTinThues;
			}
			set
			{
				this._ThongTinThues.Assign(value);
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
		
		private void attach_ThongTinThues(ThongTinThue entity)
		{
			this.SendPropertyChanging();
			entity.ThongTinPhong = this;
		}
		
		private void detach_ThongTinThues(ThongTinThue entity)
		{
			this.SendPropertyChanging();
			entity.ThongTinPhong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThongTinKH")]
	public partial class ThongTinKH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKH;
		
		private string _HoTen;
		
		private string _SDT;
		
		private string _CMND;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _DiaChi;
		
		private string _anh;
		
		private EntitySet<ThongTinThue> _ThongTinThues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnanhChanging(string value);
    partial void OnanhChanged();
    #endregion
		
		public ThongTinKH()
		{
			this._ThongTinThues = new EntitySet<ThongTinThue>(new Action<ThongTinThue>(this.attach_ThongTinThues), new Action<ThongTinThue>(this.detach_ThongTinThues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="VarChar(10)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anh", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string anh
		{
			get
			{
				return this._anh;
			}
			set
			{
				if ((this._anh != value))
				{
					this.OnanhChanging(value);
					this.SendPropertyChanging();
					this._anh = value;
					this.SendPropertyChanged("anh");
					this.OnanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ThongTinKH_ThongTinThue", Storage="_ThongTinThues", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<ThongTinThue> ThongTinThues
		{
			get
			{
				return this._ThongTinThues;
			}
			set
			{
				this._ThongTinThues.Assign(value);
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
		
		private void attach_ThongTinThues(ThongTinThue entity)
		{
			this.SendPropertyChanging();
			entity.ThongTinKH = this;
		}
		
		private void detach_ThongTinThues(ThongTinThue entity)
		{
			this.SendPropertyChanging();
			entity.ThongTinKH = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _uses;
		
		private string _pass;
		
		private string _quyen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusesChanging(string value);
    partial void OnusesChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnquyenChanging(string value);
    partial void OnquyenChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uses", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string uses
		{
			get
			{
				return this._uses;
			}
			set
			{
				if ((this._uses != value))
				{
					this.OnusesChanging(value);
					this.SendPropertyChanging();
					this._uses = value;
					this.SendPropertyChanged("uses");
					this.OnusesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quyen", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string quyen
		{
			get
			{
				return this._quyen;
			}
			set
			{
				if ((this._quyen != value))
				{
					this.OnquyenChanging(value);
					this.SendPropertyChanging();
					this._quyen = value;
					this.SendPropertyChanged("quyen");
					this.OnquyenChanged();
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
}
#pragma warning restore 1591
