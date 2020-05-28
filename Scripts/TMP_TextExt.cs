using JetBrains.Annotations;
using System.Text;
using TMPro;

namespace Kogane
{
	/// <summary>
	/// TMP_Text 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class TMP_TextExt
	{
		//================================================================================
		// 変数(static)
		//================================================================================
		private static IStringFormatter m_formatter;

		//================================================================================
		// プロパティ(static)
		//================================================================================
		/// <summary>
		/// string.Format 
		/// </summary>
		public static IStringFormatter Formatter
		{
			private get => m_formatter ?? ( m_formatter = new DefaultStringFormatter() );
			set => m_formatter = value;
		}

		//================================================================================
		// SetText
		//================================================================================
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, string text )
		{
			self.text = text;
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, byte value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, sbyte value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, char value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, short value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, ushort value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, int value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, long value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, uint value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, ulong value )
		{
			self.SetText( value.ToString() );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this TMP_Text self, StringBuilder sb )
		{
			self.SetText( sb.ToString() );
		}

		//================================================================================
		// SetTextIfNotNull
		//================================================================================
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, string text )
		{
			if ( self == null ) return;
			self.SetText( text );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, byte value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, sbyte value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, char value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, short value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, ushort value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, int value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, uint value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, long value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, ulong value )
		{
			if ( self == null ) return;
			self.SetText( value );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetTextIfNotNull( this TMP_Text self, StringBuilder sb )
		{
			if ( self == null ) return;
			self.SetText( sb );
		}

		//================================================================================
		// SetTextT
		//================================================================================
		/// <summary>
		/// テキストを設定します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static void SetText<T>
		(
			this TMP_Text self,
			string        format,
			T             arg1
		)
		{
			self.SetText( Formatter.Format( format, arg1 ) );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static void SetText<T1, T2>
		(
			this TMP_Text self,
			string        format,
			T1            arg1,
			T2            arg2
		)
		{
			self.SetText( Formatter.Format( format, arg1, arg2 ) );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static void SetText<T1, T2, T3>
		(
			this TMP_Text self,
			string        format,
			T1            arg1,
			T2            arg2,
			T3            arg3
		)
		{
			self.SetText( Formatter.Format( format, arg1, arg2, arg3 ) );
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static void SetText<T1, T2, T3, T4>
		(
			this TMP_Text self,
			string        format,
			T1            arg1,
			T2            arg2,
			T3            arg3,
			T4            arg4
		)
		{
			self.SetText
			(
				Formatter.Format
				(
					format,
					arg1,
					arg2,
					arg3,
					arg4
				)
			);
		}

		//================================================================================
		// SetEmpty
		//================================================================================
		/// <summary>
		/// 空文字列を設定します
		/// </summary>
		public static void SetEmpty( this TMP_Text self )
		{
			self.SetText( string.Empty );
		}
	}
}