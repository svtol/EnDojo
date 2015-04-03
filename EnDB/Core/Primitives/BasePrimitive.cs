/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of BasePrimitive.
	/// </summary>
	public abstract class BasePrimitive
	{
		static BasePrimitive()
		{
			
		}
		
		private static String mDefaultConnectionString = null;
		
		public static String DefaultConnectionString
		{
			get{
				return mDefaultConnectionString;
			}
			
			set{
				mDefaultConnectionString = value;
			}
		}
		
		protected BasePrimitive()
		{
			this.mConnectionString = DefaultConnectionString;
		}
		
		private String mConnectionString = null;
		
		public String ConnectionString
		{
			get{
				return this.mConnectionString;
			}
		}
		
		private int mId = 0;
		
		public int Id
		{
			get{
				return this.mId;
			}
			
			set{
				if(this.mId == value)
				{
					return;
				}
				
				this.mId = value;
				
				this.EmitModified();
			}
		}
		
		private bool mIsSaved = false;
		
		public bool IsSaved
		{
			get{
				return this.mIsSaved;
			}
		}
		
		private bool mIsLoaded = false;
		
		public bool IsLoaded
		{
			get
			{
				return this.mIsLoaded;
			}
		}
		
		public bool Load()
		{
			this.EmitLoading();
			
			bool tmpRez = this.LoadHandler();
			
			this.mIsLoaded = tmpRez;
			this.mIsSaved = tmpRez;
			
			this.EmitLoaded();
			
			return tmpRez;
		}
		
		public bool Load(int id)
		{
			this.Id = id;
			
			return this.Load();
		}
		
		protected abstract bool LoadHandler();
		
		public event Action Loading;
		
		private void EmitLoading()
		{
			if(Loading != null)
			{
				Loading();
			}
		}
		
		public event Action Loaded;
		
		private void EmitLoaded()
		{
			if(Loaded != null)
			{
				Loaded();
			}
		}
		
		public bool Save()
		{
			this.EmitSaving();
			
			/*bool tmpRez = this.SaveHandler();
						
			this.mIsLoaded = tmpRez;
			this.mIsSaved = tmpRez;
			
			this.EmitSaved();
			
			return tmpRez;*/
			
			bool tmpRez = false;
			
			if(this.Id == 0)
			{
				tmpRez = this.InsertHandler();
			}else{
				if(this.IsContainsInDBHandler())
				{
					tmpRez = this.UpdateHandler();
				}else{
					tmpRez = this.InsertHandler();
				}
			}
			
			this.mIsLoaded = tmpRez;
			this.mIsSaved = tmpRez;
			
			this.EmitSaved();
			
			return tmpRez;
		}
		
		protected abstract bool SaveHandler();
		
		protected virtual bool IsContainsInDBHandler()
		{
			return false;
		}
		
		protected virtual bool InsertHandler()
		{
			return false;
		}
		
		protected virtual bool UpdateHandler()
		{
			return false;
		}
		
		public event Action Modified;
	
		protected void EmitModified()
		{
			this.mIsSaved = false;
			
			if(Modified != null)
			{
				Modified();
			}
		}
		
		public event Action Saving;
		
		private void EmitSaving()
		{
			if(Saving != null)
			{
				Saving();
			}
		}
		
		public event Action Saved;
		
		private void EmitSaved()
		{
			if(Saved != null)
			{
				Saved();
			}
		}

		public bool Remove()
		{
			this.EmitRemoving();
			
			bool tmpRez = this.RemoveHandler();
			
            this.mIsLoaded = false;
			this.mIsSaved = false;
			
			this.EmitRemoved();
			
			return tmpRez;	
		}
		
		protected abstract bool RemoveHandler();
		
		public event Action Removing;
		
		private void EmitRemoving()
		{
			if(Removing != null)
			{
				Removing();
			}
		}
		
		public event Action Removed;
		
		public void EmitRemoved()
		{
			if(Removed != null)
			{
				Removed();
			}
		}
		
		public override string ToString()
		{
			StringBuilder tmpSb = new StringBuilder();

			tmpSb.AppendLine(System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this).ToString());
			
			tmpSb.Append("Id = ");
			tmpSb.AppendLine(this.Id.ToString());
			
			tmpSb.Append("IsLoaded = ");
			tmpSb.AppendLine(this.IsLoaded.ToString());
			
			tmpSb.Append("IsSaved = ");			
			tmpSb.AppendLine(this.IsSaved.ToString());
			
			return tmpSb.ToString();
		}

	}
}
