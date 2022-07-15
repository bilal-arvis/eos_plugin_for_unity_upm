// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

#if DEBUG
	#define EOS_DEBUG
#endif

#if UNITY_EDITOR
	#define EOS_EDITOR
#endif

#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_PS4 || UNITY_XBOXONE || UNITY_SWITCH || UNITY_IOS || UNITY_ANDROID
	#define EOS_UNITY
#endif

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN || PLATFORM_64BITS || PLATFORM_32BITS
	#if UNITY_EDITOR_WIN || UNITY_64 || PLATFORM_64BITS
		#define EOS_PLATFORM_WINDOWS_64
	#else
		#define EOS_PLATFORM_WINDOWS_32
	#endif

#elif UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
	#define EOS_PLATFORM_OSX

#elif UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
	#define EOS_PLATFORM_LINUX

#elif UNITY_PS4
	#define EOS_PLATFORM_PS4

#elif UNITY_XBOXONE
	#define EOS_PLATFORM_XBOXONE

#elif UNITY_SWITCH
	#define EOS_PLATFORM_SWITCH

#elif UNITY_IOS || __IOS__
	#define EOS_PLATFORM_IOS

#elif UNITY_ANDROID || __ANDROID__
	#define EOS_PLATFORM_ANDROID

#endif

#if EOS_EDITOR
	#define EOS_DYNAMIC_BINDINGS
#endif

#if EOS_DYNAMIC_BINDINGS
	#if EOS_PLATFORM_WINDOWS_32
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE3
	#elif EOS_PLATFORM_OSX
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE2
	#else
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE1
	#endif
#endif

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices
{
	public static class WindowsBindings
	{
#if EOS_DYNAMIC_BINDINGS_NAME_TYPE1
		private const string EOS_Platform_CreateName = "EOS_Platform_Create";
#endif

#if EOS_DYNAMIC_BINDINGS_NAME_TYPE2
		private const string EOS_Platform_CreateName = "_EOS_Platform_Create";
#endif

#if EOS_DYNAMIC_BINDINGS_NAME_TYPE3
		private const string EOS_Platform_CreateName = "_EOS_Platform_Create@4";
#endif

#if EOS_DYNAMIC_BINDINGS
		/// <summary>
		/// Hooks the dynamic SDK API bindings. EOS_DYNAMIC_BINDINGS or EOS_EDITOR must be set.
		/// </summary>
		/// <param name="libraryHandle">The library handle to find functions in. The type is platform dependent, but would typically be <see cref="System.IntPtr"/>.</param>
		/// <param name="getFunctionPointer">A delegate that gets a function pointer using the given library handle and function name.</param>
		public static void Hook<TLibraryHandle>(TLibraryHandle libraryHandle, Func<TLibraryHandle, string, IntPtr> getFunctionPointer)
		{
			System.IntPtr functionPointer;

			functionPointer = getFunctionPointer(libraryHandle, EOS_Platform_CreateName);
			if (functionPointer == System.IntPtr.Zero) throw new DynamicBindingException(EOS_Platform_CreateName);
			EOS_Platform_Create = (EOS_Platform_CreateDelegate)Marshal.GetDelegateForFunctionPointer(functionPointer, typeof(EOS_Platform_CreateDelegate));
		}
#endif

#if EOS_DYNAMIC_BINDINGS
		/// <summary>
		/// Unhooks the dynamic SDK API bindings. EOS_DYNAMIC_BINDINGS or EOS_EDITOR must be set.
		/// </summary>
		public static void Unhook()
		{
			EOS_Platform_Create = null;
		}
#endif

#if EOS_DYNAMIC_BINDINGS
		[UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
		internal delegate System.IntPtr EOS_Platform_CreateDelegate(ref Platform.WindowsOptionsInternal options);
		internal static EOS_Platform_CreateDelegate EOS_Platform_Create;
#endif

#if !EOS_DYNAMIC_BINDINGS
		[DllImport(Config.LibraryName)]
		internal static extern System.IntPtr EOS_Platform_Create(ref Platform.WindowsOptionsInternal options);
#endif
	}
}