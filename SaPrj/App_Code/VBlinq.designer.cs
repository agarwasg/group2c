﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="vbleague")]
public partial class VBlinqDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertPlayer(Player instance);
  partial void UpdatePlayer(Player instance);
  partial void DeletePlayer(Player instance);
  partial void InsertLevel(Level instance);
  partial void UpdateLevel(Level instance);
  partial void DeleteLevel(Level instance);
  partial void InsertTeam(Team instance);
  partial void UpdateTeam(Team instance);
  partial void DeleteTeam(Team instance);
  #endregion
	
	public VBlinqDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["vbleagueConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public VBlinqDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public VBlinqDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public VBlinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public VBlinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Player> Players
	{
		get
		{
			return this.GetTable<Player>();
		}
	}
	
	public System.Data.Linq.Table<Level> Levels
	{
		get
		{
			return this.GetTable<Level>();
		}
	}
	
	public System.Data.Linq.Table<Team> Teams
	{
		get
		{
			return this.GetTable<Team>();
		}
	}
}

[Table(Name="dbo.Player")]
public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _PlrName;
	
	private string _PlrPhone;
	
	private string _PlrEmail;
	
	private char _PlrGender;
	
	private string _PlrHeight;
	
	private System.DateTime _PlrDOB;
	
	private string _PlrLevel;
	
	private System.Nullable<bool> _PlrMH;
	
	private System.Nullable<bool> _PlrOH;
	
	private System.Nullable<bool> _PlrST;
	
	private System.Nullable<bool> _PlrLB;
	
	private string _PlrLeagues;
	
	private string _PlrTeam;
	
	private EntityRef<Level> _Level;
	
	private EntityRef<Team> _Team;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlrNameChanging(string value);
    partial void OnPlrNameChanged();
    partial void OnPlrPhoneChanging(string value);
    partial void OnPlrPhoneChanged();
    partial void OnPlrEmailChanging(string value);
    partial void OnPlrEmailChanged();
    partial void OnPlrGenderChanging(char value);
    partial void OnPlrGenderChanged();
    partial void OnPlrHeightChanging(string value);
    partial void OnPlrHeightChanged();
    partial void OnPlrDOBChanging(System.DateTime value);
    partial void OnPlrDOBChanged();
    partial void OnPlrLevelChanging(string value);
    partial void OnPlrLevelChanged();
    partial void OnPlrMHChanging(System.Nullable<bool> value);
    partial void OnPlrMHChanged();
    partial void OnPlrOHChanging(System.Nullable<bool> value);
    partial void OnPlrOHChanged();
    partial void OnPlrSTChanging(System.Nullable<bool> value);
    partial void OnPlrSTChanged();
    partial void OnPlrLBChanging(System.Nullable<bool> value);
    partial void OnPlrLBChanged();
    partial void OnPlrLeaguesChanging(string value);
    partial void OnPlrLeaguesChanged();
    partial void OnPlrTeamChanging(string value);
    partial void OnPlrTeamChanged();
    #endregion
	
	public Player()
	{
		this._Level = default(EntityRef<Level>);
		this._Team = default(EntityRef<Team>);
		OnCreated();
	}
	
	[Column(Storage="_PlrName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string PlrName
	{
		get
		{
			return this._PlrName;
		}
		set
		{
			if ((this._PlrName != value))
			{
				this.OnPlrNameChanging(value);
				this.SendPropertyChanging();
				this._PlrName = value;
				this.SendPropertyChanged("PlrName");
				this.OnPlrNameChanged();
			}
		}
	}
	
	[Column(Storage="_PlrPhone", DbType="NChar(12) NOT NULL", CanBeNull=false)]
	public string PlrPhone
	{
		get
		{
			return this._PlrPhone;
		}
		set
		{
			if ((this._PlrPhone != value))
			{
				this.OnPlrPhoneChanging(value);
				this.SendPropertyChanging();
				this._PlrPhone = value;
				this.SendPropertyChanged("PlrPhone");
				this.OnPlrPhoneChanged();
			}
		}
	}
	
	[Column(Storage="_PlrEmail", DbType="VarChar(30)")]
	public string PlrEmail
	{
		get
		{
			return this._PlrEmail;
		}
		set
		{
			if ((this._PlrEmail != value))
			{
				this.OnPlrEmailChanging(value);
				this.SendPropertyChanging();
				this._PlrEmail = value;
				this.SendPropertyChanged("PlrEmail");
				this.OnPlrEmailChanged();
			}
		}
	}
	
	[Column(Storage="_PlrGender", DbType="NChar(1) NOT NULL")]
	public char PlrGender
	{
		get
		{
			return this._PlrGender;
		}
		set
		{
			if ((this._PlrGender != value))
			{
				this.OnPlrGenderChanging(value);
				this.SendPropertyChanging();
				this._PlrGender = value;
				this.SendPropertyChanged("PlrGender");
				this.OnPlrGenderChanged();
			}
		}
	}
	
	[Column(Storage="_PlrHeight", DbType="VarChar(20)")]
	public string PlrHeight
	{
		get
		{
			return this._PlrHeight;
		}
		set
		{
			if ((this._PlrHeight != value))
			{
				this.OnPlrHeightChanging(value);
				this.SendPropertyChanging();
				this._PlrHeight = value;
				this.SendPropertyChanged("PlrHeight");
				this.OnPlrHeightChanged();
			}
		}
	}
	
	[Column(Storage="_PlrDOB", DbType="DateTime NOT NULL")]
	public System.DateTime PlrDOB
	{
		get
		{
			return this._PlrDOB;
		}
		set
		{
			if ((this._PlrDOB != value))
			{
				this.OnPlrDOBChanging(value);
				this.SendPropertyChanging();
				this._PlrDOB = value;
				this.SendPropertyChanged("PlrDOB");
				this.OnPlrDOBChanged();
			}
		}
	}
	
	[Column(Storage="_PlrLevel", DbType="NChar(2) NOT NULL", CanBeNull=false)]
	public string PlrLevel
	{
		get
		{
			return this._PlrLevel;
		}
		set
		{
			if ((this._PlrLevel != value))
			{
				if (this._Level.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPlrLevelChanging(value);
				this.SendPropertyChanging();
				this._PlrLevel = value;
				this.SendPropertyChanged("PlrLevel");
				this.OnPlrLevelChanged();
			}
		}
	}
	
	[Column(Storage="_PlrMH", DbType="Bit")]
	public System.Nullable<bool> PlrMH
	{
		get
		{
			return this._PlrMH;
		}
		set
		{
			if ((this._PlrMH != value))
			{
				this.OnPlrMHChanging(value);
				this.SendPropertyChanging();
				this._PlrMH = value;
				this.SendPropertyChanged("PlrMH");
				this.OnPlrMHChanged();
			}
		}
	}
	
	[Column(Storage="_PlrOH", DbType="Bit")]
	public System.Nullable<bool> PlrOH
	{
		get
		{
			return this._PlrOH;
		}
		set
		{
			if ((this._PlrOH != value))
			{
				this.OnPlrOHChanging(value);
				this.SendPropertyChanging();
				this._PlrOH = value;
				this.SendPropertyChanged("PlrOH");
				this.OnPlrOHChanged();
			}
		}
	}
	
	[Column(Storage="_PlrST", DbType="Bit")]
	public System.Nullable<bool> PlrST
	{
		get
		{
			return this._PlrST;
		}
		set
		{
			if ((this._PlrST != value))
			{
				this.OnPlrSTChanging(value);
				this.SendPropertyChanging();
				this._PlrST = value;
				this.SendPropertyChanged("PlrST");
				this.OnPlrSTChanged();
			}
		}
	}
	
	[Column(Storage="_PlrLB", DbType="Bit")]
	public System.Nullable<bool> PlrLB
	{
		get
		{
			return this._PlrLB;
		}
		set
		{
			if ((this._PlrLB != value))
			{
				this.OnPlrLBChanging(value);
				this.SendPropertyChanging();
				this._PlrLB = value;
				this.SendPropertyChanged("PlrLB");
				this.OnPlrLBChanged();
			}
		}
	}
	
	[Column(Storage="_PlrLeagues", DbType="VarChar(100)")]
	public string PlrLeagues
	{
		get
		{
			return this._PlrLeagues;
		}
		set
		{
			if ((this._PlrLeagues != value))
			{
				this.OnPlrLeaguesChanging(value);
				this.SendPropertyChanging();
				this._PlrLeagues = value;
				this.SendPropertyChanged("PlrLeagues");
				this.OnPlrLeaguesChanged();
			}
		}
	}
	
	[Column(Storage="_PlrTeam", DbType="NChar(4)")]
	public string PlrTeam
	{
		get
		{
			return this._PlrTeam;
		}
		set
		{
			if ((this._PlrTeam != value))
			{
				if (this._Team.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPlrTeamChanging(value);
				this.SendPropertyChanging();
				this._PlrTeam = value;
				this.SendPropertyChanged("PlrTeam");
				this.OnPlrTeamChanged();
			}
		}
	}
	
	[Association(Name="Level_Player", Storage="_Level", ThisKey="PlrLevel", OtherKey="LevCode", IsForeignKey=true)]
	public Level Level
	{
		get
		{
			return this._Level.Entity;
		}
		set
		{
			Level previousValue = this._Level.Entity;
			if (((previousValue != value) 
						|| (this._Level.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Level.Entity = null;
					previousValue.Players.Remove(this);
				}
				this._Level.Entity = value;
				if ((value != null))
				{
					value.Players.Add(this);
					this._PlrLevel = value.LevCode;
				}
				else
				{
					this._PlrLevel = default(string);
				}
				this.SendPropertyChanged("Level");
			}
		}
	}
	
	[Association(Name="Team_Player", Storage="_Team", ThisKey="PlrTeam", OtherKey="TeamCode", IsForeignKey=true)]
	public Team Team
	{
		get
		{
			return this._Team.Entity;
		}
		set
		{
			Team previousValue = this._Team.Entity;
			if (((previousValue != value) 
						|| (this._Team.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Team.Entity = null;
					previousValue.Players.Remove(this);
				}
				this._Team.Entity = value;
				if ((value != null))
				{
					value.Players.Add(this);
					this._PlrTeam = value.TeamCode;
				}
				else
				{
					this._PlrTeam = default(string);
				}
				this.SendPropertyChanged("Team");
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

[Table(Name="dbo.[Level]")]
public partial class Level : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _LevCode;
	
	private string _LevDesc;
	
	private EntitySet<Player> _Players;
	
	private EntitySet<Team> _Teams;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLevCodeChanging(string value);
    partial void OnLevCodeChanged();
    partial void OnLevDescChanging(string value);
    partial void OnLevDescChanged();
    #endregion
	
	public Level()
	{
		this._Players = new EntitySet<Player>(new Action<Player>(this.attach_Players), new Action<Player>(this.detach_Players));
		this._Teams = new EntitySet<Team>(new Action<Team>(this.attach_Teams), new Action<Team>(this.detach_Teams));
		OnCreated();
	}
	
	[Column(Storage="_LevCode", DbType="NChar(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string LevCode
	{
		get
		{
			return this._LevCode;
		}
		set
		{
			if ((this._LevCode != value))
			{
				this.OnLevCodeChanging(value);
				this.SendPropertyChanging();
				this._LevCode = value;
				this.SendPropertyChanged("LevCode");
				this.OnLevCodeChanged();
			}
		}
	}
	
	[Column(Storage="_LevDesc", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string LevDesc
	{
		get
		{
			return this._LevDesc;
		}
		set
		{
			if ((this._LevDesc != value))
			{
				this.OnLevDescChanging(value);
				this.SendPropertyChanging();
				this._LevDesc = value;
				this.SendPropertyChanged("LevDesc");
				this.OnLevDescChanged();
			}
		}
	}
	
	[Association(Name="Level_Player", Storage="_Players", ThisKey="LevCode", OtherKey="PlrLevel")]
	public EntitySet<Player> Players
	{
		get
		{
			return this._Players;
		}
		set
		{
			this._Players.Assign(value);
		}
	}
	
	[Association(Name="Level_Team", Storage="_Teams", ThisKey="LevCode", OtherKey="TeamLevel")]
	public EntitySet<Team> Teams
	{
		get
		{
			return this._Teams;
		}
		set
		{
			this._Teams.Assign(value);
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
	
	private void attach_Players(Player entity)
	{
		this.SendPropertyChanging();
		entity.Level = this;
	}
	
	private void detach_Players(Player entity)
	{
		this.SendPropertyChanging();
		entity.Level = null;
	}
	
	private void attach_Teams(Team entity)
	{
		this.SendPropertyChanging();
		entity.Level = this;
	}
	
	private void detach_Teams(Team entity)
	{
		this.SendPropertyChanging();
		entity.Level = null;
	}
}

[Table(Name="dbo.Team")]
public partial class Team : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _TeamCode;
	
	private string _TeamName;
	
	private string _TeamComment;
	
	private System.Nullable<System.DateTime> _TeamFoundationDate;
	
	private string _TeamLevel;
	
	private System.Nullable<bool> _TeamActive;
	
	private System.Nullable<int> _TeamWins;
	
	private System.Data.Linq.Binary _Version;
	
	private EntitySet<Player> _Players;
	
	private EntityRef<Level> _Level;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeamCodeChanging(string value);
    partial void OnTeamCodeChanged();
    partial void OnTeamNameChanging(string value);
    partial void OnTeamNameChanged();
    partial void OnTeamCommentChanging(string value);
    partial void OnTeamCommentChanged();
    partial void OnTeamFoundationDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTeamFoundationDateChanged();
    partial void OnTeamLevelChanging(string value);
    partial void OnTeamLevelChanged();
    partial void OnTeamActiveChanging(System.Nullable<bool> value);
    partial void OnTeamActiveChanged();
    partial void OnTeamWinsChanging(System.Nullable<int> value);
    partial void OnTeamWinsChanged();
    partial void OnVersionChanging(System.Data.Linq.Binary value);
    partial void OnVersionChanged();
    #endregion
	
	public Team()
	{
		this._Players = new EntitySet<Player>(new Action<Player>(this.attach_Players), new Action<Player>(this.detach_Players));
		this._Level = default(EntityRef<Level>);
		OnCreated();
	}
	
	[Column(Storage="_TeamCode", DbType="NChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
	public string TeamCode
	{
		get
		{
			return this._TeamCode;
		}
		set
		{
			if ((this._TeamCode != value))
			{
				this.OnTeamCodeChanging(value);
				this.SendPropertyChanging();
				this._TeamCode = value;
				this.SendPropertyChanged("TeamCode");
				this.OnTeamCodeChanged();
			}
		}
	}
	
	[Column(Storage="_TeamName", DbType="VarChar(20) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string TeamName
	{
		get
		{
			return this._TeamName;
		}
		set
		{
			if ((this._TeamName != value))
			{
				this.OnTeamNameChanging(value);
				this.SendPropertyChanging();
				this._TeamName = value;
				this.SendPropertyChanged("TeamName");
				this.OnTeamNameChanged();
			}
		}
	}
	
	[Column(Storage="_TeamComment", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
	public string TeamComment
	{
		get
		{
			return this._TeamComment;
		}
		set
		{
			if ((this._TeamComment != value))
			{
				this.OnTeamCommentChanging(value);
				this.SendPropertyChanging();
				this._TeamComment = value;
				this.SendPropertyChanged("TeamComment");
				this.OnTeamCommentChanged();
			}
		}
	}
	
	[Column(Storage="_TeamFoundationDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<System.DateTime> TeamFoundationDate
	{
		get
		{
			return this._TeamFoundationDate;
		}
		set
		{
			if ((this._TeamFoundationDate != value))
			{
				this.OnTeamFoundationDateChanging(value);
				this.SendPropertyChanging();
				this._TeamFoundationDate = value;
				this.SendPropertyChanged("TeamFoundationDate");
				this.OnTeamFoundationDateChanged();
			}
		}
	}
	
	[Column(Storage="_TeamLevel", DbType="NChar(2)", UpdateCheck=UpdateCheck.Never)]
	public string TeamLevel
	{
		get
		{
			return this._TeamLevel;
		}
		set
		{
			if ((this._TeamLevel != value))
			{
				if (this._Level.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnTeamLevelChanging(value);
				this.SendPropertyChanging();
				this._TeamLevel = value;
				this.SendPropertyChanged("TeamLevel");
				this.OnTeamLevelChanged();
			}
		}
	}
	
	[Column(Storage="_TeamActive", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<bool> TeamActive
	{
		get
		{
			return this._TeamActive;
		}
		set
		{
			if ((this._TeamActive != value))
			{
				this.OnTeamActiveChanging(value);
				this.SendPropertyChanging();
				this._TeamActive = value;
				this.SendPropertyChanged("TeamActive");
				this.OnTeamActiveChanged();
			}
		}
	}
	
	[Column(Storage="_TeamWins", DbType="Int", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<int> TeamWins
	{
		get
		{
			return this._TeamWins;
		}
		set
		{
			if ((this._TeamWins != value))
			{
				this.OnTeamWinsChanging(value);
				this.SendPropertyChanging();
				this._TeamWins = value;
				this.SendPropertyChanged("TeamWins");
				this.OnTeamWinsChanged();
			}
		}
	}
	
	[Column(Storage="_Version", AutoSync=AutoSync.Always, DbType="rowversion", CanBeNull=true, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary Version
	{
		get
		{
			return this._Version;
		}
		set
		{
			if ((this._Version != value))
			{
				this.OnVersionChanging(value);
				this.SendPropertyChanging();
				this._Version = value;
				this.SendPropertyChanged("Version");
				this.OnVersionChanged();
			}
		}
	}
	
	[Association(Name="Team_Player", Storage="_Players", ThisKey="TeamCode", OtherKey="PlrTeam")]
	public EntitySet<Player> Players
	{
		get
		{
			return this._Players;
		}
		set
		{
			this._Players.Assign(value);
		}
	}
	
	[Association(Name="Level_Team", Storage="_Level", ThisKey="TeamLevel", OtherKey="LevCode", IsForeignKey=true)]
	public Level Level
	{
		get
		{
			return this._Level.Entity;
		}
		set
		{
			Level previousValue = this._Level.Entity;
			if (((previousValue != value) 
						|| (this._Level.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Level.Entity = null;
					previousValue.Teams.Remove(this);
				}
				this._Level.Entity = value;
				if ((value != null))
				{
					value.Teams.Add(this);
					this._TeamLevel = value.LevCode;
				}
				else
				{
					this._TeamLevel = default(string);
				}
				this.SendPropertyChanged("Level");
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
	
	private void attach_Players(Player entity)
	{
		this.SendPropertyChanging();
		entity.Team = this;
	}
	
	private void detach_Players(Player entity)
	{
		this.SendPropertyChanging();
		entity.Team = null;
	}
}
#pragma warning restore 1591
