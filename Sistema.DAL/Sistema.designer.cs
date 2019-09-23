﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_sistema")]
	public partial class SistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    #endregion
		
		public SistemaDataContext() : 
				base(global::Sistema.DAL.Properties.Settings.Default.db_sistemaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produto
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private EntitySet<Produto> _Produto;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public Categoria()
		{
			this._Produto = new EntitySet<Produto>(new Action<Produto>(this.attach_Produto), new Action<Produto>(this.detach_Produto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_categoria", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Produto", ThisKey="Codigo", OtherKey="CodigoCategoria")]
		public EntitySet<Produto> Produto
		{
			get
			{
				return this._Produto;
			}
			set
			{
				this._Produto.Assign(value);
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
		
		private void attach_Produto(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Produto(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_produto")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private System.Nullable<decimal> _Valor;
		
		private System.Nullable<int> _CodigoCategoria;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnValorChanging(System.Nullable<decimal> value);
    partial void OnValorChanged();
    partial void OnCodigoCategoriaChanging(System.Nullable<int> value);
    partial void OnCodigoCategoriaChanged();
    #endregion
		
		public Produto()
		{
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_produto", Storage="_Codigo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_produto", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="valor", Storage="_Valor", DbType="Decimal(25,2)")]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_CodigoCategoria", DbType="Int")]
		public System.Nullable<int> CodigoCategoria
		{
			get
			{
				return this._CodigoCategoria;
			}
			set
			{
				if ((this._CodigoCategoria != value))
				{
					this.OnCodigoCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodigoCategoria = value;
					this.SendPropertyChanged("CodigoCategoria");
					this.OnCodigoCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Categoria", ThisKey="CodigoCategoria", OtherKey="Codigo", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Produto.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Produto.Add(this);
						this._CodigoCategoria = value.Codigo;
					}
					else
					{
						this._CodigoCategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
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
