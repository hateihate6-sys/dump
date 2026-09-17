	public static int lzcnt(int x) { }

	// RVA: 0x27ED070 Offset: 0x27EC270 VA: 0x1827ED070
	public static int lzcnt(uint x) { }

	// RVA: 0x27ED0C0 Offset: 0x27EC2C0 VA: 0x1827ED0C0
	public static int tzcnt(int x) { }

	// RVA: 0x27ED0C0 Offset: 0x27EC2C0 VA: 0x1827ED0C0
	public static int tzcnt(uint x) { }

	// RVA: 0x27ED110 Offset: 0x27EC310 VA: 0x1827ED110
	public static int tzcnt(ulong x) { }

	// RVA: 0x19C5350 Offset: 0x19C4550 VA: 0x1819C5350
	public static int ceilpow2(int x) { }

	// RVA: 0x27ED180 Offset: 0x27EC380 VA: 0x1827ED180
	public static uint ceilpow2(uint x) { }

	// RVA: 0x27ED1B0 Offset: 0x27EC3B0 VA: 0x1827ED1B0
	public static uint csum(uint2 x) { }

	// RVA: 0x27ED1C0 Offset: 0x27EC3C0 VA: 0x1827ED1C0
	public static uint csum(uint3 x) { }

	// RVA: 0x27ED1D0 Offset: 0x27EC3D0 VA: 0x1827ED1D0
	public static uint csum(uint4 x) { }

	// RVA: 0x27ED1E0 Offset: 0x27EC3E0 VA: 0x1827ED1E0
	public static float f16tof32(uint x) { }

	// RVA: 0x27ED240 Offset: 0x27EC440 VA: 0x1827ED240
	public static uint f32tof16(float x) { }

	// RVA: 0x27ED2C0 Offset: 0x27EC4C0 VA: 0x1827ED2C0
	internal static float4 movelh(float4 a, float4 b) { }

	// RVA: 0x27ED3C0 Offset: 0x27EC5C0 VA: 0x1827ED3C0
	internal static float4 movehl(float4 a, float4 b) { }

	// RVA: 0x27ED4C0 Offset: 0x27EC6C0 VA: 0x1827ED4C0
	public static float3x3 float3x3(quaternion rotation) { }

	// RVA: 0x27ED500 Offset: 0x27EC700 VA: 0x1827ED500
	public static float3 mul(float3x3 a, float3 b) { }

	// RVA: 0x27ED5E0 Offset: 0x27EC7E0 VA: 0x1827ED5E0
	public static float4 mul(float4x4 a, float4 b) { }

	// RVA: 0x27ED790 Offset: 0x27EC990 VA: 0x1827ED790
	public static float4x4 mul(float4x4 a, float4x4 b) { }

	// RVA: 0x11420C0 Offset: 0x11412C0 VA: 0x1811420C0
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x27E9890 Offset: 0x27E8A90 VA: 0x1827E9890
	public static uint hash(quaternion q) { }

	// RVA: 0x27EBD00 Offset: 0x27EAF00 VA: 0x1827EBD00
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x27EDDE0 Offset: 0x27ECFE0 VA: 0x1827EDDE0
	public static uint hash(uint2 v) { }

	// RVA: 0x27EDE30 Offset: 0x27ED030 VA: 0x1827EDE30
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x27EDE40 Offset: 0x27ED040 VA: 0x1827EDE40
	public static uint hash(uint3 v) { }

	// RVA: 0x27EDE90 Offset: 0x27ED090 VA: 0x1827EDE90
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x27EDEB0 Offset: 0x27ED0B0 VA: 0x1827EDEB0
	public static uint hash(uint4 v) { }
}

// Namespace: 
internal sealed class bool2.DebuggerProxy // TypeDefIndex: 15598
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(bool2.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct bool2 : IEquatable<bool2> // TypeDefIndex: 15599
{
	// Fields
	public bool x; // 0x0
	public bool y; // 0x1

	// Methods

	// RVA: 0x1324E10 Offset: 0x1324010 VA: 0x181324E10
	public void .ctor(bool x, bool y) { }

	// RVA: 0x27EDF00 Offset: 0x27ED100 VA: 0x1827EDF00 Slot: 4
	public bool Equals(bool2 rhs) { }

	// RVA: 0x27EDF20 Offset: 0x27ED120 VA: 0x1827EDF20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EDFB0 Offset: 0x27ED1B0 VA: 0x1827EDFB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27EDFC0 Offset: 0x27ED1C0 VA: 0x1827EDFC0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal sealed class bool4.DebuggerProxy // TypeDefIndex: 15600
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(bool4.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct bool4 : IEquatable<bool4> // TypeDefIndex: 15601
{
	// Fields
	public bool x; // 0x0
	public bool y; // 0x1
	public bool z; // 0x2
	public bool w; // 0x3

	// Methods

	// RVA: 0x4E2650 Offset: 0x4E1850 VA: 0x1804E2650
	public void .ctor(bool x, bool y, bool z, bool w) { }

	// RVA: 0x27EE080 Offset: 0x27ED280 VA: 0x1827EE080
	public void .ctor(bool v) { }

	// RVA: 0x27EE090 Offset: 0x27ED290 VA: 0x1827EE090
	public static bool4 op_BitwiseOr(bool4 lhs, bool4 rhs) { }

	// RVA: 0xC6C720 Offset: 0xC6B920 VA: 0x180C6C720 Slot: 4
	public bool Equals(bool4 rhs) { }

	// RVA: 0x27EE0E0 Offset: 0x27ED2E0 VA: 0x1827EE0E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EE180 Offset: 0x27ED380 VA: 0x1827EE180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27EE1E0 Offset: 0x27ED3E0 VA: 0x1827EE1E0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal sealed class float2.DebuggerProxy // TypeDefIndex: 15602
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(float2.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 15603
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public static readonly float2 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public float3 xxx { get; }
	[EditorBrowsable(1)]
	public float3 yyy { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; set; }

	// Methods

	// RVA: 0x4E2470 Offset: 0x4E1670 VA: 0x1804E2470
	public void .ctor(float x, float y) { }

	// RVA: 0x27EE410 Offset: 0x27ED610 VA: 0x1827EE410
	public void .ctor(float v) { }

	// RVA: 0x27EE420 Offset: 0x27ED620 VA: 0x1827EE420
	public void .ctor(int v) { }

	// RVA: 0x27EE440 Offset: 0x27ED640 VA: 0x1827EE440
	public void .ctor(int2 v) { }

	// RVA: 0x27EE460 Offset: 0x27ED660 VA: 0x1827EE460
	public void .ctor(uint2 v) { }

	// RVA: 0x27E9460 Offset: 0x27E8660 VA: 0x1827E9460
	public static float2 op_Implicit(float v) { }

	// RVA: 0x27EE490 Offset: 0x27ED690 VA: 0x1827EE490
	public static float2 op_Implicit(int v) { }

	// RVA: 0x27EE4B0 Offset: 0x27ED6B0 VA: 0x1827EE4B0
	public static float2 op_Implicit(int2 v) { }

	// RVA: 0x27EE4D0 Offset: 0x27ED6D0 VA: 0x1827EE4D0
	public static float2 op_Implicit(uint2 v) { }

	// RVA: 0x27EE500 Offset: 0x27ED700 VA: 0x1827EE500
	public static float2 op_Multiply(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE540 Offset: 0x27ED740 VA: 0x1827EE540
	public static float2 op_Multiply(float2 lhs, float rhs) { }

	// RVA: 0x27EE570 Offset: 0x27ED770 VA: 0x1827EE570
	public static float2 op_Multiply(float lhs, float2 rhs) { }

	// RVA: 0x27EE5A0 Offset: 0x27ED7A0 VA: 0x1827EE5A0
	public static float2 op_Addition(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE5E0 Offset: 0x27ED7E0 VA: 0x1827EE5E0
	public static float2 op_Addition(float2 lhs, float rhs) { }

	// RVA: 0x27EE610 Offset: 0x27ED810 VA: 0x1827EE610
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE650 Offset: 0x27ED850 VA: 0x1827EE650
	public static float2 op_Subtraction(float2 lhs, float rhs) { }

	// RVA: 0x27EE680 Offset: 0x27ED880 VA: 0x1827EE680
	public static float2 op_Division(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE6C0 Offset: 0x27ED8C0 VA: 0x1827EE6C0
	public static float2 op_Division(float2 lhs, float rhs) { }

	// RVA: 0x27EE6F0 Offset: 0x27ED8F0 VA: 0x1827EE6F0
	public static float2 op_Division(float lhs, float2 rhs) { }

	// RVA: 0x27EE710 Offset: 0x27ED910 VA: 0x1827EE710
	public static bool2 op_LessThan(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE750 Offset: 0x27ED950 VA: 0x1827EE750
	public static float2 op_UnaryNegation(float2 val) { }

	// RVA: 0x27EE780 Offset: 0x27ED980 VA: 0x1827EE780
	public static bool2 op_Equality(float2 lhs, float2 rhs) { }

	// RVA: 0x27EE7E0 Offset: 0x27ED9E0 VA: 0x1827EE7E0
	public float3 get_xxx() { }

	// RVA: 0x27EE7F0 Offset: 0x27ED9F0 VA: 0x1827EE7F0
	public float3 get_yyy() { }

	// RVA: 0x132CFF0 Offset: 0x132C1F0 VA: 0x18132CFF0
	public float2 get_xy() { }

	// RVA: 0x27EE800 Offset: 0x27EDA00 VA: 0x1827EE800
	public void set_xy(float2 value) { }

	// RVA: 0x27EE820 Offset: 0x27EDA20 VA: 0x1827EE820 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x27EE850 Offset: 0x27EDA50 VA: 0x1827EE850 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EE8F0 Offset: 0x27EDAF0 VA: 0x1827EE8F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27EE950 Offset: 0x27EDB50 VA: 0x1827EE950 Slot: 3
	public override string ToString() { }

	// RVA: 0x27EEA10 Offset: 0x27EDC10 VA: 0x1827EEA10 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27EEAE0 Offset: 0x27EDCE0 VA: 0x1827EEAE0
	public static Vector2 op_Implicit(float2 v) { }

	// RVA: 0x27EEAE0 Offset: 0x27EDCE0 VA: 0x1827EEAE0
	public static float2 op_Implicit(Vector2 v) { }
}

// Namespace: 
internal sealed class float3.DebuggerProxy // TypeDefIndex: 15604
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(float3.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 15605
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Properties
	[EditorBrowsable(1)]
	public float4 xxxx { get; }
	[EditorBrowsable(1)]
	public float4 yxxy { get; }
	[EditorBrowsable(1)]
	public float4 yyyy { get; }
	[EditorBrowsable(1)]
	public float4 zzyz { get; }
	[EditorBrowsable(1)]
	public float4 zzzz { get; }
	[EditorBrowsable(1)]
	public float3 xyz { get; }
	[EditorBrowsable(1)]
	public float3 yzx { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; }
	[EditorBrowsable(1)]
	public float2 xz { get; }
	[EditorBrowsable(1)]
	public float2 yz { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x482550 Offset: 0x481750 VA: 0x180482550
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x27EEB00 Offset: 0x27EDD00 VA: 0x1827EEB00
	public void .ctor(float2 xy, float z) { }

	// RVA: 0x27EEB20 Offset: 0x27EDD20 VA: 0x1827EEB20
	public void .ctor(float3 xyz) { }

	// RVA: 0x27EEB40 Offset: 0x27EDD40 VA: 0x1827EEB40
	public void .ctor(float v) { }

	// RVA: 0x27EEB50 Offset: 0x27EDD50 VA: 0x1827EEB50
	public void .ctor(int v) { }

	// RVA: 0x27EEB80 Offset: 0x27EDD80 VA: 0x1827EEB80
	public void .ctor(half3 v) { }

	// RVA: 0x27EECB0 Offset: 0x27EDEB0 VA: 0x1827EECB0
	public static float3 op_Implicit(float v) { }

	// RVA: 0x27EECD0 Offset: 0x27EDED0 VA: 0x1827EECD0
	public static float3 op_Implicit(int v) { }

	// RVA: 0x27EED00 Offset: 0x27EDF00 VA: 0x1827EED00
	public static float3 op_Implicit(half3 v) { }

	// RVA: 0x27EED40 Offset: 0x27EDF40 VA: 0x1827EED40
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x27EED80 Offset: 0x27EDF80 VA: 0x1827EED80
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x27EEDB0 Offset: 0x27EDFB0 VA: 0x1827EEDB0
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x27EEDE0 Offset: 0x27EDFE0 VA: 0x1827EEDE0
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x27EEE20 Offset: 0x27EE020 VA: 0x1827EEE20
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x27EEE60 Offset: 0x27EE060 VA: 0x1827EEE60
	public float4 get_xxxx() { }

	// RVA: 0x27EEE80 Offset: 0x27EE080 VA: 0x1827EEE80
	public float4 get_yxxy() { }

	// RVA: 0x27EEEA0 Offset: 0x27EE0A0 VA: 0x1827EEEA0
	public float4 get_yyyy() { }

	// RVA: 0x27EEEC0 Offset: 0x27EE0C0 VA: 0x1827EEEC0
	public float4 get_zzyz() { }

	// RVA: 0x27EEEE0 Offset: 0x27EE0E0 VA: 0x1827EEEE0
	public float4 get_zzzz() { }

	// RVA: 0x27EEF00 Offset: 0x27EE100 VA: 0x1827EEF00
	public float3 get_xyz() { }

	// RVA: 0x27EEF20 Offset: 0x27EE120 VA: 0x1827EEF20
	public float3 get_yzx() { }

	// RVA: 0x132CFF0 Offset: 0x132C1F0 VA: 0x18132CFF0
	public float2 get_xy() { }

	// RVA: 0x533E90 Offset: 0x533090 VA: 0x180533E90
	public float2 get_xz() { }

	// RVA: 0x1327100 Offset: 0x1326300 VA: 0x181327100
	public float2 get_yz() { }

	// RVA: 0x11ED700 Offset: 0x11EC900 VA: 0x1811ED700
	public float get_Item(int index) { }

	// RVA: 0x11EE750 Offset: 0x11ED950 VA: 0x1811EE750
	public void set_Item(int index, float value) { }

	// RVA: 0x27EEF40 Offset: 0x27EE140 VA: 0x1827EEF40 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x27EEF70 Offset: 0x27EE170 VA: 0x1827EEF70 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27E9550 Offset: 0x27E8750 VA: 0x1827E9550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27EF020 Offset: 0x27EE220 VA: 0x1827EF020 Slot: 3
	public override string ToString() { }

	// RVA: 0x27EF130 Offset: 0x27EE330 VA: 0x1827EF130 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27EEF00 Offset: 0x27EE100 VA: 0x1827EEF00
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x27EEF00 Offset: 0x27EE100 VA: 0x1827EEF00
	public static float3 op_Implicit(Vector3 v) { }
}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct float3x3 : IEquatable<float3x3>, IFormattable // TypeDefIndex: 15606
{
	// Fields
	public float3 c0; // 0x0
	public float3 c1; // 0xC
	public float3 c2; // 0x18
	public static readonly float3x3 identity; // 0x0

	// Methods

	// RVA: 0x27EF220 Offset: 0x27EE420 VA: 0x1827EF220
	public void .ctor(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	// RVA: 0x27EF280 Offset: 0x27EE480 VA: 0x1827EF280 Slot: 4
	public bool Equals(float3x3 rhs) { }

	// RVA: 0x27EF330 Offset: 0x27EE530 VA: 0x1827EF330 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EF3D0 Offset: 0x27EE5D0 VA: 0x1827EF3D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27EF490 Offset: 0x27EE690 VA: 0x1827EF490 Slot: 3
	public override string ToString() { }

	// RVA: 0x27EF880 Offset: 0x27EEA80 VA: 0x1827EF880 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27EFC40 Offset: 0x27EEE40 VA: 0x1827EFC40
	public void .ctor(float4x4 f4x4) { }

	// RVA: 0x27EFCA0 Offset: 0x27EEEA0 VA: 0x1827EFCA0
	public void .ctor(quaternion q) { }

	// RVA: 0x27EFF90 Offset: 0x27EF190 VA: 0x1827EFF90
	public static float3x3 op_Explicit(float4x4 f4x4) { }

	// RVA: 0x27F0000 Offset: 0x27EF200 VA: 0x1827F0000
	private static void .cctor() { }
}

// Namespace: 
internal sealed class float4.DebuggerProxy // TypeDefIndex: 15607
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(float4.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 15608
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public float3 xyz { get; set; }
	[EditorBrowsable(1)]
	public float3 yxw { get; }
	[EditorBrowsable(1)]
	public float3 zwx { get; }
	[EditorBrowsable(1)]
	public float3 wzy { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; set; }
	[EditorBrowsable(1)]
	public float2 zw { get; set; }

	// Methods

	// RVA: 0xAF1C60 Offset: 0xAF0E60 VA: 0x180AF1C60
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x27F0060 Offset: 0x27EF260 VA: 0x1827F0060
	public void .ctor(float2 xy, float2 zw) { }

	// RVA: 0x27F00A0 Offset: 0x27EF2A0 VA: 0x1827F00A0
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x27F00C0 Offset: 0x27EF2C0 VA: 0x1827F00C0
	public void .ctor(float v) { }

	// RVA: 0x27F00D0 Offset: 0x27EF2D0 VA: 0x1827F00D0
	public void .ctor(half4 v) { }

	// RVA: 0x27E9880 Offset: 0x27E8A80 VA: 0x1827E9880
	public static float4 op_Implicit(float v) { }

	// RVA: 0x27F0260 Offset: 0x27EF460 VA: 0x1827F0260
	public static float4 op_Implicit(half4 v) { }

	// RVA: 0x27F0280 Offset: 0x27EF480 VA: 0x1827F0280
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x27F02D0 Offset: 0x27EF4D0 VA: 0x1827F02D0
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x27F02F0 Offset: 0x27EF4F0 VA: 0x1827F02F0
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x27F0310 Offset: 0x27EF510 VA: 0x1827F0310
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x27F0360 Offset: 0x27EF560 VA: 0x1827F0360
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x27F03B0 Offset: 0x27EF5B0 VA: 0x1827F03B0
	public static float4 op_Division(float4 lhs, float4 rhs) { }

	// RVA: 0x27F0400 Offset: 0x27EF600 VA: 0x1827F0400
	public static float4 op_Division(float4 lhs, float rhs) { }

	// RVA: 0x27F0420 Offset: 0x27EF620 VA: 0x1827F0420
	public static bool4 op_LessThan(float4 lhs, float4 rhs) { }

	// RVA: 0x27F0460 Offset: 0x27EF660 VA: 0x1827F0460
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0x27EEF00 Offset: 0x27EE100 VA: 0x1827EEF00
	public float3 get_xyz() { }

	// RVA: 0x27EEB20 Offset: 0x27EDD20 VA: 0x1827EEB20
	public void set_xyz(float3 value) { }

	// RVA: 0x27F0480 Offset: 0x27EF680 VA: 0x1827F0480
	public float3 get_yxw() { }

	// RVA: 0x27F04A0 Offset: 0x27EF6A0 VA: 0x1827F04A0
	public float3 get_zwx() { }

	// RVA: 0x27F04C0 Offset: 0x27EF6C0 VA: 0x1827F04C0
	public float3 get_wzy() { }

	// RVA: 0x132CFF0 Offset: 0x132C1F0 VA: 0x18132CFF0
	public float2 get_xy() { }

	// RVA: 0x27EE800 Offset: 0x27EDA00 VA: 0x1827EE800
	public void set_xy(float2 value) { }

	// RVA: 0x132ACE0 Offset: 0x1329EE0 VA: 0x18132ACE0
	public float2 get_zw() { }

	// RVA: 0x27F04E0 Offset: 0x27EF6E0 VA: 0x1827F04E0
	public void set_zw(float2 value) { }

	// RVA: 0x27F0500 Offset: 0x27EF700 VA: 0x1827F0500 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x27F0540 Offset: 0x27EF740 VA: 0x1827F0540 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27E9890 Offset: 0x27E8A90 VA: 0x1827E9890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F0600 Offset: 0x27EF800 VA: 0x1827F0600 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F0830 Offset: 0x27EFA30 VA: 0x1827F0830 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27F0A60 Offset: 0x27EFC60 VA: 0x1827F0A60
	public static float4 op_Implicit(Vector4 v) { }

	// RVA: 0x27F0A60 Offset: 0x27EFC60 VA: 0x1827F0A60
	public static Vector4 op_Implicit(float4 v) { }
}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct float4x4 : IEquatable<float4x4>, IFormattable // TypeDefIndex: 15609
{
	// Fields
	public float4 c0; // 0x0
	public float4 c1; // 0x10
	public float4 c2; // 0x20
	public float4 c3; // 0x30
	public static readonly float4x4 identity; // 0x0
	public static readonly float4x4 zero; // 0x40

	// Properties
	public float4 Item { get; }

	// Methods

	// RVA: 0x27F0A80 Offset: 0x27EFC80 VA: 0x1827F0A80
	public void .ctor(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0x27F0AB0 Offset: 0x27EFCB0 VA: 0x1827F0AB0
	public void .ctor(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	// RVA: 0x11E8E40 Offset: 0x11E8040 VA: 0x1811E8E40
	public ref float4 get_Item(int index) { }

	// RVA: 0x27F0BB0 Offset: 0x27EFDB0 VA: 0x1827F0BB0 Slot: 4
	public bool Equals(float4x4 rhs) { }

	// RVA: 0x27F0D20 Offset: 0x27EFF20 VA: 0x1827F0D20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27F0DD0 Offset: 0x27EFFD0 VA: 0x1827F0DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F0E10 Offset: 0x27F0010 VA: 0x1827F0E10 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F1480 Offset: 0x27F0680 VA: 0x1827F1480 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27F1A80 Offset: 0x27F0C80 VA: 0x1827F1A80
	public static float4x4 op_Implicit(Matrix4x4 m) { }

	// RVA: 0x27F1AD0 Offset: 0x27F0CD0 VA: 0x1827F1AD0
	public static Matrix4x4 op_Implicit(float4x4 m) { }

	// RVA: 0x27F1B80 Offset: 0x27F0D80 VA: 0x1827F1B80
	public static float4x4 Scale(float x, float y, float z) { }

	// RVA: 0x27F1BF0 Offset: 0x27F0DF0 VA: 0x1827F1BF0
	public static float4x4 Scale(float3 scales) { }

	// RVA: 0x27F1C70 Offset: 0x27F0E70 VA: 0x1827F1C70
	public static float4x4 Translate(float3 vector) { }

	// RVA: 0x27F1CE0 Offset: 0x27F0EE0 VA: 0x1827F1CE0
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

	// RVA: 0x27F1ED0 Offset: 0x27F10D0 VA: 0x1827F1ED0
	private static void .cctor() { }
}

// Namespace: Unity.Mathematics
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct half : IEquatable<half>, IFormattable // TypeDefIndex: 15610
{
	// Fields
	public ushort value; // 0x0
	public static readonly half zero; // 0x0

	// Methods

	// RVA: 0x27F1F40 Offset: 0x27F1140 VA: 0x1827F1F40
	public void .ctor(float v) { }

	// RVA: 0x27F1F60 Offset: 0x27F1160 VA: 0x1827F1F60
	public static float op_Implicit(half d) { }

	// RVA: 0x27F1FC0 Offset: 0x27F11C0 VA: 0x1827F1FC0
	public static bool op_Equality(half lhs, half rhs) { }

	// RVA: 0x23AAEF0 Offset: 0x23AA0F0 VA: 0x1823AAEF0 Slot: 4
	public bool Equals(half rhs) { }

	// RVA: 0x27F1FD0 Offset: 0x27F11D0 VA: 0x1827F1FD0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x11E93A0 Offset: 0x11E85A0 VA: 0x1811E93A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F2060 Offset: 0x27F1260 VA: 0x1827F2060 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F2120 Offset: 0x27F1320 VA: 0x1827F2120 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class half3.DebuggerProxy // TypeDefIndex: 15611
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(half3.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct half3 : IEquatable<half3>, IFormattable // TypeDefIndex: 15612
{
	// Fields
	public half x; // 0x0
	public half y; // 0x2
	public half z; // 0x4

	// Methods

	// RVA: 0x27F21F0 Offset: 0x27F13F0 VA: 0x1827F21F0
	public void .ctor(half x, half y, half z) { }

	// RVA: 0x27F2200 Offset: 0x27F1400 VA: 0x1827F2200 Slot: 4
	public bool Equals(half3 rhs) { }

	// RVA: 0x27F2230 Offset: 0x27F1430 VA: 0x1827F2230 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27F22D0 Offset: 0x27F14D0 VA: 0x1827F22D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F2310 Offset: 0x27F1510 VA: 0x1827F2310 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F2430 Offset: 0x27F1630 VA: 0x1827F2430 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class half4.DebuggerProxy // TypeDefIndex: 15613
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(half4.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct half4 : IEquatable<half4>, IFormattable // TypeDefIndex: 15614
{
	// Fields
	public half x; // 0x0
	public half y; // 0x2
	public half z; // 0x4
	public half w; // 0x6
	public static readonly half4 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public half3 xyz { get; }

	// Methods

	// RVA: 0x27F2520 Offset: 0x27F1720 VA: 0x1827F2520
	public half3 get_xyz() { }

	// RVA: 0x27F2540 Offset: 0x27F1740 VA: 0x1827F2540 Slot: 4
	public bool Equals(half4 rhs) { }

	// RVA: 0x27F2570 Offset: 0x27F1770 VA: 0x1827F2570 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27F2620 Offset: 0x27F1820 VA: 0x1827F2620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F2670 Offset: 0x27F1870 VA: 0x1827F2670 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F28B0 Offset: 0x27F1AB0 VA: 0x1827F28B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class int2.DebuggerProxy // TypeDefIndex: 15615
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(int2.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 15616
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4
	public static readonly int2 zero; // 0x0

	// Methods

	// RVA: 0x8A2690 Offset: 0x8A1890 VA: 0x1808A2690
	public void .ctor(int x, int y) { }

	// RVA: 0x27F2AD0 Offset: 0x27F1CD0 VA: 0x1827F2AD0
	public void .ctor(int v) { }

	// RVA: 0x27F2AE0 Offset: 0x27F1CE0 VA: 0x1827F2AE0
	public void .ctor(float2 v) { }

	// RVA: 0x27F2B00 Offset: 0x27F1D00 VA: 0x1827F2B00
	public static int2 op_Implicit(int v) { }

	// RVA: 0x27F2B10 Offset: 0x27F1D10 VA: 0x1827F2B10
	public static int2 op_Explicit(float2 v) { }

	// RVA: 0x27F2B30 Offset: 0x27F1D30 VA: 0x1827F2B30
	public static int2 op_Addition(int2 lhs, int2 rhs) { }

	// RVA: 0x467E10 Offset: 0x467010 VA: 0x180467E10 Slot: 4
	public bool Equals(int2 rhs) { }

	// RVA: 0x27F2B50 Offset: 0x27F1D50 VA: 0x1827F2B50 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27F2BE0 Offset: 0x27F1DE0 VA: 0x1827F2BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F2C30 Offset: 0x27F1E30 VA: 0x1827F2C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F2CF0 Offset: 0x27F1EF0 VA: 0x1827F2CF0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class int4.DebuggerProxy // TypeDefIndex: 15617
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(int4.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct int4 : IEquatable<int4>, IFormattable // TypeDefIndex: 15618
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4
	public int z; // 0x8
	public int w; // 0xC
	public static readonly int4 zero; // 0x0

	// Properties
	public int Item { get; }

	// Methods

	// RVA: 0x11ECA90 Offset: 0x11EBC90 VA: 0x1811ECA90
	public int get_Item(int index) { }

	// RVA: 0x2463830 Offset: 0x2462A30 VA: 0x182463830 Slot: 4
	public bool Equals(int4 rhs) { }

	// RVA: 0x27F2DC0 Offset: 0x27F1FC0 VA: 0x1827F2DC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EBD60 Offset: 0x27EAF60 VA: 0x1827EBD60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F2E70 Offset: 0x27F2070 VA: 0x1827F2E70 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F3090 Offset: 0x27F2290 VA: 0x1827F3090 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: Unity.Mathematics
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 15619
{
	// Fields
	public float4 value; // 0x0
	public static readonly quaternion identity; // 0x0

	// Methods

	// RVA: 0x27F0A60 Offset: 0x27EFC60 VA: 0x1827F0A60
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x27F0A60 Offset: 0x27EFC60 VA: 0x1827F0A60
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xAF1C60 Offset: 0xAF0E60 VA: 0x180AF1C60
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x161EE90 Offset: 0x161E090 VA: 0x18161EE90
	public void .ctor(float4 value) { }

	// RVA: 0x27F32C0 Offset: 0x27F24C0 VA: 0x1827F32C0
	public static quaternion EulerXYZ(float3 xyz) { }

	// RVA: 0x27F3430 Offset: 0x27F2630 VA: 0x1827F3430
	public static quaternion EulerXYZ(float x, float y, float z) { }

	// RVA: 0x27F0500 Offset: 0x27EF700 VA: 0x1827F0500 Slot: 4
	public bool Equals(quaternion x) { }

	// RVA: 0x27F3470 Offset: 0x27F2670 VA: 0x1827F3470 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x27E9890 Offset: 0x27E8A90 VA: 0x1827E9890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F3530 Offset: 0x27F2730 VA: 0x1827F3530 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F3760 Offset: 0x27F2960 VA: 0x1827F3760 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x27F3990 Offset: 0x27F2B90 VA: 0x1827F3990
	private static void .cctor() { }
}

// Namespace: 
internal sealed class uint2.DebuggerProxy // TypeDefIndex: 15620
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(uint2.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct uint2 : IEquatable<uint2>, IFormattable // TypeDefIndex: 15621
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4

	// Properties
	[EditorBrowsable(1)]
	public uint2 xy { get; }

	// Methods

	// RVA: 0x8A2690 Offset: 0x8A1890 VA: 0x1808A2690
	public void .ctor(uint x, uint y) { }

	// RVA: 0x27F39E0 Offset: 0x27F2BE0 VA: 0x1827F39E0
	public static uint2 op_Multiply(uint2 lhs, uint2 rhs) { }

	// RVA: 0x27F3A00 Offset: 0x27F2C00 VA: 0x1827F3A00
	public static uint2 op_LeftShift(uint2 x, int n) { }

	// RVA: 0x27F3A30 Offset: 0x27F2C30 VA: 0x1827F3A30
	public static uint2 op_RightShift(uint2 x, int n) { }

	// RVA: 0x27F3A60 Offset: 0x27F2C60 VA: 0x1827F3A60
	public static uint2 op_BitwiseAnd(uint2 lhs, uint rhs) { }

	// RVA: 0x27F3A80 Offset: 0x27F2C80 VA: 0x1827F3A80
	public static uint2 op_BitwiseOr(uint2 lhs, uint2 rhs) { }

	// RVA: 0x27F3AA0 Offset: 0x27F2CA0 VA: 0x1827F3AA0
	public uint2 get_xy() { }

	// RVA: 0x467E10 Offset: 0x467010 VA: 0x180467E10 Slot: 4
	public bool Equals(uint2 rhs) { }

	// RVA: 0x27F3AC0 Offset: 0x27F2CC0 VA: 0x1827F3AC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27F3B50 Offset: 0x27F2D50 VA: 0x1827F3B50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F3BA0 Offset: 0x27F2DA0 VA: 0x1827F3BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F3C60 Offset: 0x27F2E60 VA: 0x1827F3C60 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class uint3.DebuggerProxy // TypeDefIndex: 15622
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(uint3.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct uint3 : IEquatable<uint3>, IFormattable // TypeDefIndex: 15623
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8

	// Properties
	[EditorBrowsable(1)]
	public uint4 xyzz { get; }
	[EditorBrowsable(1)]
	public uint2 xy { get; }

	// Methods

	// RVA: 0x2460C80 Offset: 0x245FE80 VA: 0x182460C80
	public void .ctor(uint x, uint y, uint z) { }

	// RVA: 0x27F3D30 Offset: 0x27F2F30 VA: 0x1827F3D30
	public static uint3 op_Multiply(uint3 lhs, uint3 rhs) { }

	// RVA: 0x27F3D60 Offset: 0x27F2F60 VA: 0x1827F3D60
	public static uint3 op_Addition(uint3 lhs, uint3 rhs) { }

	// RVA: 0x27F3D80 Offset: 0x27F2F80 VA: 0x1827F3D80
	public static uint3 op_Addition(uint3 lhs, uint rhs) { }

	// RVA: 0x27F3DB0 Offset: 0x27F2FB0 VA: 0x1827F3DB0
	public static uint3 op_BitwiseAnd(uint3 lhs, uint rhs) { }

	// RVA: 0x27F3DD0 Offset: 0x27F2FD0 VA: 0x1827F3DD0
	public static uint3 op_ExclusiveOr(uint3 lhs, uint3 rhs) { }

	// RVA: 0x27F3DF0 Offset: 0x27F2FF0 VA: 0x1827F3DF0
	public uint4 get_xyzz() { }

	// RVA: 0x27F3AA0 Offset: 0x27F2CA0 VA: 0x1827F3AA0
	public uint2 get_xy() { }

	// RVA: 0x27F3E10 Offset: 0x27F3010 VA: 0x1827F3E10 Slot: 4
	public bool Equals(uint3 rhs) { }

	// RVA: 0x27F3E30 Offset: 0x27F3030 VA: 0x1827F3E30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EDE40 Offset: 0x27ED040 VA: 0x1827EDE40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F3EE0 Offset: 0x27F30E0 VA: 0x1827F3EE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F3FE0 Offset: 0x27F31E0 VA: 0x1827F3FE0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal sealed class uint4.DebuggerProxy // TypeDefIndex: 15624
{}

// Namespace: Unity.Mathematics
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(uint4.DebuggerProxy))]
[Il2CppEagerStaticClassConstruction]
[Serializable]
public struct uint4 : IEquatable<uint4>, IFormattable // TypeDefIndex: 15625
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC
	public static readonly uint4 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public uint4 xyzw { set; }
	[EditorBrowsable(1)]
	public uint4 yzxx { get; }
	[EditorBrowsable(1)]
	public uint4 yzxy { get; }
	[EditorBrowsable(1)]
	public uint4 yzxz { get; }
	[EditorBrowsable(1)]
	public uint4 zwxy { get; }
	public int Item { set; }

	// Methods

	// RVA: 0xB54A70 Offset: 0xB53C70 VA: 0x180B54A70
	public void .ctor(uint x, uint y, uint z, uint w) { }

	// RVA: 0x27F40D0 Offset: 0x27F32D0 VA: 0x1827F40D0
	public void .ctor(uint v) { }

	// RVA: 0x27F40E0 Offset: 0x27F32E0 VA: 0x1827F40E0
	public static uint4 op_Implicit(uint v) { }

	// RVA: 0x27F40F0 Offset: 0x27F32F0 VA: 0x1827F40F0
	public static uint4 op_Multiply(uint4 lhs, uint4 rhs) { }

	// RVA: 0x27F4120 Offset: 0x27F3320 VA: 0x1827F4120
	public static uint4 op_Multiply(uint4 lhs, uint rhs) { }

	// RVA: 0x27F4150 Offset: 0x27F3350 VA: 0x1827F4150
	public static uint4 op_Addition(uint4 lhs, uint4 rhs) { }

	// RVA: 0x27F4180 Offset: 0x27F3380 VA: 0x1827F4180
	public static bool4 op_GreaterThan(uint4 lhs, uint rhs) { }

	// RVA: 0x27F41B0 Offset: 0x27F33B0 VA: 0x1827F41B0
	public static uint4 op_RightShift(uint4 x, int n) { }

	// RVA: 0x27F41F0 Offset: 0x27F33F0 VA: 0x1827F41F0
	public static uint4 op_BitwiseAnd(uint4 lhs, uint4 rhs) { }

	// RVA: 0x27F4220 Offset: 0x27F3420 VA: 0x1827F4220
	public static uint4 op_BitwiseAnd(uint4 lhs, uint rhs) { }

	// RVA: 0x27F4250 Offset: 0x27F3450 VA: 0x1827F4250
	public static uint4 op_ExclusiveOr(uint4 lhs, uint4 rhs) { }

	// RVA: 0x27F4280 Offset: 0x27F3480 VA: 0x1827F4280
	public void set_xyzw(uint4 value) { }

	// RVA: 0x27F42A0 Offset: 0x27F34A0 VA: 0x1827F42A0
	public uint4 get_yzxx() { }

	// RVA: 0x27F42C0 Offset: 0x27F34C0 VA: 0x1827F42C0
	public uint4 get_yzxy() { }

	// RVA: 0x27F42E0 Offset: 0x27F34E0 VA: 0x1827F42E0
	public uint4 get_yzxz() { }

	// RVA: 0x27F4300 Offset: 0x27F3500 VA: 0x1827F4300
	public uint4 get_zwxy() { }

	// RVA: 0x11EDB30 Offset: 0x11ECD30 VA: 0x1811EDB30
	public void set_Item(int index, uint value) { }

	// RVA: 0x2463830 Offset: 0x2462A30 VA: 0x182463830 Slot: 4
	public bool Equals(uint4 rhs) { }

	// RVA: 0x27F4320 Offset: 0x27F3520 VA: 0x1827F4320 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x27EDEB0 Offset: 0x27ED0B0 VA: 0x1827EDEB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27F43D0 Offset: 0x27F35D0 VA: 0x1827F43D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x27F45F0 Offset: 0x27F37F0 VA: 0x1827F45F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15626
{}

// Namespace: 
public enum CommandEvent.Type // TypeDefIndex: 15627
{
	// Fields
	public int value__; // 0x0
	public const CommandEvent.Type Validate = 1;
	public const CommandEvent.Type Execute = 2;
}

// Namespace: 
public enum CommandEvent.Command // TypeDefIndex: 15628
{
	// Fields
	public int value__; // 0x0
	public const CommandEvent.Command Invalid = 0;
	public const CommandEvent.Command Cut = 1;
	public const CommandEvent.Command Copy = 2;
	public const CommandEvent.Command Paste = 3;
	public const CommandEvent.Command SelectAll = 4;
	public const CommandEvent.Command DeselectAll = 5;
	public const CommandEvent.Command InvertSelection = 6;
	public const CommandEvent.Command Duplicate = 7;
	public const CommandEvent.Command Rename = 8;
	public const CommandEvent.Command Delete = 9;
	public const CommandEvent.Command SoftDelete = 10;
	public const CommandEvent.Command Find = 11;
	public const CommandEvent.Command SelectChildren = 12;
	public const CommandEvent.Command SelectPrefabRoot = 13;
	public const CommandEvent.Command UndoRedoPerformed = 14;
	public const CommandEvent.Command OnLostFocus = 15;
	public const CommandEvent.Command NewKeyboardFocus = 16;
	public const CommandEvent.Command ModifierKeysChanged = 17;
	public const CommandEvent.Command EyeDropperUpdate = 18;
	public const CommandEvent.Command EyeDropperClicked = 19;
	public const CommandEvent.Command EyeDropperCancelled = 20;
	public const CommandEvent.Command ColorPickerChanged = 21;
	public const CommandEvent.Command FrameSelected = 22;
	public const CommandEvent.Command FrameSelectedWithLock = 23;
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct CommandEvent : IEventProperties // TypeDefIndex: 15629
{
	// Fields
	public CommandEvent.Type type; // 0x0
	public CommandEvent.Command command; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBA74A0 Offset: 0xBA66A0 VA: 0x180BA74A0
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4B8C80 Offset: 0x4B7E80 VA: 0x1804B8C80 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x73C880 Offset: 0x73BA80 VA: 0x18073C880
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FA7EB0 Offset: 0x2FA70B0 VA: 0x182FA7EB0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public enum Event.Type // TypeDefIndex: 15630
{
	// Fields
	public int value__; // 0x0
	public const Event.Type Invalid = 0;
	public const Event.Type KeyEvent = 1;
	public const Event.Type PointerEvent = 2;
	public const Event.Type TextInputEvent = 3;
	public const Event.Type IMECompositionEvent = 4;
	public const Event.Type CommandEvent = 5;
	public const Event.Type NavigationEvent = 6;
}

// Namespace: 
private interface Event.IMapFn<TOutputType> // TypeDefIndex: 15631
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TOutputType Map<TEventType>(ref TEventType ev);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Event.IMapFn<__Il2CppFullySharedGenericType>.Map<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private struct Event.MapAsObject : Event.IMapFn<IEventProperties> // TypeDefIndex: 15632
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public IEventProperties Map<TEventType>(ref TEventType ev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FF9E0 Offset: 0x11FEBE0 VA: 0x1811FF9E0
	|-Event.MapAsObject.Map<CommandEvent>
	|-Event.MapAsObject.Map<IMECompositionEvent>
	|-Event.MapAsObject.Map<TextInputEvent>
	|
	|-RVA: 0x11FFA30 Offset: 0x11FEC30 VA: 0x1811FFA30
	|-Event.MapAsObject.Map<KeyEvent>
	|
	|-RVA: 0x11FFAA0 Offset: 0x11FECA0 VA: 0x1811FFAA0
	|-Event.MapAsObject.Map<NavigationEvent>
	|
	|-RVA: 0x11FFB00 Offset: 0x11FED00 VA: 0x1811FFB00
	|-Event.MapAsObject.Map<PointerEvent>
	|
	|-RVA: 0x11FFB80 Offset: 0x11FED80 VA: 0x1811FFB80
	|-Event.MapAsObject.Map<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private struct Event.MapAsEventSource : Event.IMapFn<EventSource> // TypeDefIndex: 15633
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public EventSource Map<TEventType>(ref TEventType ev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FF950 Offset: 0x11FEB50 VA: 0x1811FF950
	|-Event.MapAsEventSource.Map<CommandEvent>
	|-Event.MapAsEventSource.Map<IMECompositionEvent>
	|-Event.MapAsEventSource.Map<TextInputEvent>
	|
	|-RVA: 0x11FF980 Offset: 0x11FEB80 VA: 0x1811FF980
	|-Event.MapAsEventSource.Map<KeyEvent>
	|
	|-RVA: 0x11FF7C0 Offset: 0x11FE9C0 VA: 0x1811FF7C0
	|-Event.MapAsEventSource.Map<NavigationEvent>
	|
	|-RVA: 0x11FF9B0 Offset: 0x11FEBB0 VA: 0x1811FF9B0
	|-Event.MapAsEventSource.Map<PointerEvent>
	|
	|-RVA: 0x11FF880 Offset: 0x11FEA80 VA: 0x1811FF880
	|-Event.MapAsEventSource.Map<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private struct Event.MapAsEventModifiers : Event.IMapFn<EventModifiers> // TypeDefIndex: 15634
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public EventModifiers Map<TEventType>(ref TEventType ev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FF7C0 Offset: 0x11FE9C0 VA: 0x1811FF7C0
	|-Event.MapAsEventModifiers.Map<CommandEvent>
	|-Event.MapAsEventModifiers.Map<IMECompositionEvent>
	|-Event.MapAsEventModifiers.Map<TextInputEvent>
	|
	|-RVA: 0x11FF7F0 Offset: 0x11FE9F0 VA: 0x1811FF7F0
	|-Event.MapAsEventModifiers.Map<KeyEvent>
	|
	|-RVA: 0x11FF820 Offset: 0x11FEA20 VA: 0x1811FF820
	|-Event.MapAsEventModifiers.Map<NavigationEvent>
	|
	|-RVA: 0x11FF850 Offset: 0x11FEA50 VA: 0x1811FF850
	|-Event.MapAsEventModifiers.Map<PointerEvent>
	|
	|-RVA: 0x11FF880 Offset: 0x11FEA80 VA: 0x1811FF880
	|-Event.MapAsEventModifiers.Map<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct Event : IEventProperties // TypeDefIndex: 15635
{
	// Fields
	public static Event.Type[] TypesWithState; // 0x0
	private Event.Type _type; // 0x0
	private object _managedEvent; // 0x8
	private KeyEvent _keyEvent; // 0x10
	private PointerEvent _pointerEvent; // 0x10
	private TextInputEvent _textInputEvent; // 0x10
	private CommandEvent _commandEvent; // 0x10
	private NavigationEvent _navigationEvent; // 0x10

	// Properties
	public Event.Type type { get; }
	private IEventProperties asObject { get; }
	public EventSource eventSource { get; }
	public EventModifiers eventModifiers { get; }

	// Methods

	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public Event.Type get_type() { }

	// RVA: 0x2FA7F90 Offset: 0x2FA7190 VA: 0x182FA7F90
	private IEventProperties get_asObject() { }

	// RVA: 0x2FA8000 Offset: 0x2FA7200 VA: 0x182FA8000 Slot: 4
	public EventSource get_eventSource() { }

	// RVA: 0x2FA8070 Offset: 0x2FA7270 VA: 0x182FA8070 Slot: 5
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x2FA80E0 Offset: 0x2FA72E0 VA: 0x182FA80E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FA82F0 Offset: 0x2FA74F0 VA: 0x182FA82F0
	public static Event From(KeyEvent keyEvent) { }

	// RVA: 0x2FA8370 Offset: 0x2FA7570 VA: 0x182FA8370
	public static Event From(PointerEvent pointerEvent) { }

	// RVA: 0x2FA83E0 Offset: 0x2FA75E0 VA: 0x182FA83E0
	public static Event From(TextInputEvent textInputEvent) { }

	// RVA: 0x2FA8460 Offset: 0x2FA7660 VA: 0x182FA8460
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	// RVA: 0x2FA85C0 Offset: 0x2FA77C0 VA: 0x182FA85C0
	public static Event From(CommandEvent commandEvent) { }

	// RVA: 0x2FA8640 Offset: 0x2FA7840 VA: 0x182FA8640
	public static Event From(NavigationEvent navigationEvent) { }

	// RVA: -1 Offset: -1
	private TOutputType Map<TOutputType, TMapType>(TMapType fn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110ADB0 Offset: 0x1109FB0 VA: 0x18110ADB0
	|-Event.Map<EventModifiers, Event.MapAsEventModifiers>
	|
	|-RVA: 0x110AF90 Offset: 0x110A190 VA: 0x18110AF90
	|-Event.Map<Int32Enum, Event.MapAsEventSource>
	|
	|-RVA: 0x110B170 Offset: 0x110A370 VA: 0x18110B170
	|-Event.Map<object, Event.MapAsObject>
	|
	|-RVA: 0x110B390 Offset: 0x110A590 VA: 0x18110B390
	|-Event.Map<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private TOutputType Map<TOutputType, TMapType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110AAC0 Offset: 0x1109CC0 VA: 0x18110AAC0
	|-Event.Map<EventModifiers, Event.MapAsEventModifiers>
	|
	|-RVA: 0x110AB50 Offset: 0x1109D50 VA: 0x18110AB50
	|-Event.Map<Int32Enum, Event.MapAsEventSource>
	|
	|-RVA: 0x110ABE0 Offset: 0x1109DE0 VA: 0x18110ABE0
	|-Event.Map<object, Event.MapAsObject>
	|
	|-RVA: 0x110AC70 Offset: 0x1109E70 VA: 0x18110AC70
	|-Event.Map<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FA86C0 Offset: 0x2FA78C0 VA: 0x182FA86C0
	private static void .cctor() { }
}

// Namespace: 
[Flags]
public enum EventModifiers.Modifiers // TypeDefIndex: 15636
{
	// Fields
	public uint value__; // 0x0
	public const EventModifiers.Modifiers LeftShift = 1;
	public const EventModifiers.Modifiers RightShift = 2;
	public const EventModifiers.Modifiers Shift = 3;
	public const EventModifiers.Modifiers LeftCtrl = 4;
	public const EventModifiers.Modifiers RightCtrl = 8;
	public const EventModifiers.Modifiers Ctrl = 12;
	public const EventModifiers.Modifiers LeftAlt = 16;
	public const EventModifiers.Modifiers RightAlt = 32;
	public const EventModifiers.Modifiers Alt = 48;
	public const EventModifiers.Modifiers LeftMeta = 64;
	public const EventModifiers.Modifiers RightMeta = 128;
	public const EventModifiers.Modifiers Meta = 192;
	public const EventModifiers.Modifiers CapsLock = 256;
	public const EventModifiers.Modifiers Numlock = 512;
	public const EventModifiers.Modifiers FunctionKey = 1024;
	public const EventModifiers.Modifiers Numeric = 2048;
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct EventModifiers // TypeDefIndex: 15637
{
	// Fields
	private uint _state; // 0x0

	// Properties
	public bool isShiftPressed { get; }

	// Methods

	// RVA: 0x2FA87A0 Offset: 0x2FA79A0 VA: 0x182FA87A0
	public bool IsPressed(EventModifiers.Modifiers mod) { }

	// RVA: 0x2FA87B0 Offset: 0x2FA79B0 VA: 0x182FA87B0
	public bool get_isShiftPressed() { }

	// RVA: 0x2FA87C0 Offset: 0x2FA79C0 VA: 0x182FA87C0
	public void SetPressed(EventModifiers.Modifiers modifier, bool pressed) { }

	// RVA: 0x2FA87E0 Offset: 0x2FA79E0 VA: 0x182FA87E0
	private static void Append(ref string str, string value) { }

	// RVA: 0x2FA8890 Offset: 0x2FA7A90 VA: 0x182FA8890 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum EventSource // TypeDefIndex: 15638
{
	// Fields
	public int value__; // 0x0
	public const EventSource Unspecified = 0;
	public const EventSource Keyboard = 1;
	public const EventSource Gamepad = 2;
	public const EventSource Mouse = 3;
	public const EventSource Pen = 4;
	public const EventSource Touch = 5;
}

// Namespace: UnityEngine.InputForUI
internal interface IEventProperties // TypeDefIndex: 15639
{
	// Properties
	public abstract EventSource eventSource { get; }
	public abstract EventModifiers eventModifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventSource get_eventSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract EventModifiers get_eventModifiers();
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct IMECompositionEvent : IEventProperties // TypeDefIndex: 15640
{
	// Fields
	public string compositionString; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBA74A0 Offset: 0xBA66A0 VA: 0x180BA74A0
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4B8C80 Offset: 0x4B7E80 VA: 0x1804B8C80 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x73C880 Offset: 0x73BA80 VA: 0x18073C880
	public void set_playerId(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FA8AE0 Offset: 0x2FA7CE0 VA: 0x182FA8AE0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public enum KeyEvent.Type // TypeDefIndex: 15641
{
	// Fields
	public int value__; // 0x0
	public const KeyEvent.Type KeyPressed = 1;
	public const KeyEvent.Type KeyRepeated = 2;
	public const KeyEvent.Type KeyReleased = 3;
	public const KeyEvent.Type State = 4;
}

// Namespace: 
[CompilerGenerated]
private sealed class KeyEvent.ButtonsState.<GetAllPressed>d__8 : IEnumerable<KeyCode>, IEnumerable, IEnumerator<KeyCode>, IEnumerator, IDisposable // TypeDefIndex: 15642
{
	// Fields
	private int <>1__state; // 0x10
	private KeyCode <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public KeyEvent.ButtonsState <>4__this; // 0x1C
	public KeyEvent.ButtonsState <>3__<>4__this; // 0x44
	private uint <index>5__1; // 0x6C

	// Properties
	private KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x895290 Offset: 0x894490 VA: 0x180895290
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2FA8EF0 Offset: 0x2FA80F0 VA: 0x182FA8EF0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x73C870 Offset: 0x73BA70 VA: 0x18073C870 Slot: 6
	private KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2FA8F50 Offset: 0x2FA8150 VA: 0x182FA8F50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x2FA8F90 Offset: 0x2FA8190 VA: 0x182FA8F90 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2FA8FE0 Offset: 0x2FA81E0 VA: 0x182FA8FE0 Slot: 4
	private IEnumerator<KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x2FA8FE0 Offset: 0x2FA81E0 VA: 0x182FA8FE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct KeyEvent.ButtonsState.<buttons>e__FixedBuffer // TypeDefIndex: 15643
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
public struct KeyEvent.ButtonsState // TypeDefIndex: 15644
{
	// Fields
	[FixedBuffer(typeof(byte), 40)]
	private KeyEvent.ButtonsState.<buttons>e__FixedBuffer buttons; // 0x0

	// Methods

	// RVA: 0x2FA8CE0 Offset: 0x2FA7EE0 VA: 0x182FA8CE0
	internal static bool ShouldBeProcessed(KeyCode keyCode) { }

	// RVA: 0x2FA8CF0 Offset: 0x2FA7EF0 VA: 0x182FA8CF0
	private bool GetUnchecked(uint index) { }

	// RVA: 0x2FA8D10 Offset: 0x2FA7F10 VA: 0x182FA8D10
	private void SetUnchecked(uint index) { }

	// RVA: 0x2FA8D30 Offset: 0x2FA7F30 VA: 0x182FA8D30
	private void ClearUnchecked(uint index) { }

	// RVA: 0x2FA8D50 Offset: 0x2FA7F50 VA: 0x182FA8D50
	public bool IsPressed(KeyCode keyCode) { }

	[IteratorStateMachine(typeof(KeyEvent.ButtonsState.<GetAllPressed>d__8))]
	// RVA: 0x2FA8D80 Offset: 0x2FA7F80 VA: 0x182FA8D80
	public IEnumerable<KeyCode> GetAllPressed() { }

	// RVA: 0x2FA8E00 Offset: 0x2FA8000 VA: 0x182FA8E00
	public void SetPressed(KeyCode keyCode, bool pressed) { }

	// RVA: 0x2FA8E30 Offset: 0x2FA8030 VA: 0x182FA8E30 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct KeyEvent : IEventProperties // TypeDefIndex: 15645
{
	// Fields
	public KeyEvent.Type type; // 0x0
	public KeyCode keyCode; // 0x4
	public KeyEvent.ButtonsState buttonsState; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x40

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A7E7B0 Offset: 0x1A7D9B0 VA: 0x181A7E7B0
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x7FFD20 Offset: 0x7FEF20 VA: 0x1807FFD20 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x7FFD30 Offset: 0x7FEF30 VA: 0x1807FFD30
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0xA849E0 Offset: 0xA83BE0 VA: 0x180A849E0
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x780190 Offset: 0x77F390 VA: 0x180780190 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x7801A0 Offset: 0x77F3A0 VA: 0x1807801A0
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FA8B40 Offset: 0x2FA7D40 VA: 0x182FA8B40 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public enum NavigationEvent.Type // TypeDefIndex: 15646
{
	// Fields
	public int value__; // 0x0
	public const NavigationEvent.Type Move = 1;
	public const NavigationEvent.Type Submit = 2;
	public const NavigationEvent.Type Cancel = 3;
}

// Namespace: 
public enum NavigationEvent.Direction // TypeDefIndex: 15647
{
	// Fields
	public int value__; // 0x0
	public const NavigationEvent.Direction None = 0;
	public const NavigationEvent.Direction Left = 1;
	public const NavigationEvent.Direction Up = 2;
	public const NavigationEvent.Direction Right = 3;
	public const NavigationEvent.Direction Down = 4;
	public const NavigationEvent.Direction Next = 5;
	public const NavigationEvent.Direction Previous = 6;
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct NavigationEvent : IEventProperties // TypeDefIndex: 15648
{
	// Fields
	public NavigationEvent.Type type; // 0x0
	public NavigationEvent.Direction direction; // 0x4
	public bool shouldBeUsed; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x20

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAC9D10 Offset: 0xAC8F10 VA: 0x180AC9D10
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x73C8A0 Offset: 0x73BAA0 VA: 0x18073C8A0
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EDA70 Offset: 0x4ECC70 VA: 0x1804EDA70 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x4EDA80 Offset: 0x4ECC80 VA: 0x1804EDA80
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FA9090 Offset: 0x2FA8290 VA: 0x182FA9090 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FA9280 Offset: 0x2FA8480 VA: 0x182FA9280
	internal static NavigationEvent.Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6) { }
}

// Namespace: 
public enum PointerEvent.Type // TypeDefIndex: 15649
{
	// Fields
	public int value__; // 0x0
	public const PointerEvent.Type PointerMoved = 1;
	public const PointerEvent.Type Scroll = 2;
	public const PointerEvent.Type ButtonPressed = 3;
	public const PointerEvent.Type ButtonReleased = 4;
	public const PointerEvent.Type State = 5;
	public const PointerEvent.Type TouchCanceled = 6;
}

// Namespace: 
[Flags]
public enum PointerEvent.Button // TypeDefIndex: 15650
{
	// Fields
	public uint value__; // 0x0
	public const PointerEvent.Button None = 0;
	public const PointerEvent.Button Primary = 1;
	public const PointerEvent.Button FingerInTouch = 1;
	public const PointerEvent.Button PenTipInTouch = 1;
	public const PointerEvent.Button PenEraserInTouch = 2;
	public const PointerEvent.Button PenBarrelButton = 4;
	public const PointerEvent.Button MouseLeft = 1;
	public const PointerEvent.Button MouseRight = 2;
	public const PointerEvent.Button MouseMiddle = 4;
	public const PointerEvent.Button MouseForward = 8;
	public const PointerEvent.Button MouseBack = 16;
}

// Namespace: 
public struct PointerEvent.ButtonsState // TypeDefIndex: 15651
{
	// Fields
	private uint _state; // 0x0

	// Methods

	// RVA: 0x2FA87C0 Offset: 0x2FA79C0 VA: 0x182FA87C0
	public void Set(PointerEvent.Button button, bool pressed) { }

	// RVA: 0x2FAA280 Offset: 0x2FA9480 VA: 0x182FAA280
	public bool Get(PointerEvent.Button button) { }

	// RVA: 0x22626A0 Offset: 0x22618A0 VA: 0x1822626A0
	public void Reset() { }

	// RVA: 0x2FAA290 Offset: 0x2FA9490 VA: 0x182FAA290 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct PointerEvent : IEventProperties // TypeDefIndex: 15652
{
	// Fields
	public PointerEvent.Type type; // 0x0
	public int pointerIndex; // 0x4
	public Vector2 position; // 0x8
	public Vector2 deltaPosition; // 0x10
	public Vector2 scroll; // 0x18
	public int displayIndex; // 0x20
	public Vector2 tilt; // 0x24
	public float twist; // 0x2C
	public float pressure; // 0x30
	public bool isInverted; // 0x34
	public PointerEvent.Button button; // 0x38
	public PointerEvent.ButtonsState buttonsState; // 0x3C
	public int clickCount; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x54
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventModifiers <eventModifiers>k__BackingField; // 0x58

	// Properties
	public float azimuth { get; }
	public float altitude { get; }
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	// RVA: 0x2FA92F0 Offset: 0x2FA84F0 VA: 0x182FA92F0
	public float get_azimuth() { }

	// RVA: 0x2FA93D0 Offset: 0x2FA85D0 VA: 0x182FA93D0
	public float get_altitude() { }

	[CompilerGenerated]
	// RVA: 0xB1CC30 Offset: 0xB1BE30 VA: 0x180B1CC30
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x685990 Offset: 0x684B90 VA: 0x180685990 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x5845A0 Offset: 0x5837A0 VA: 0x1805845A0
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0xCA8EE0 Offset: 0xCA80E0 VA: 0x180CA8EE0
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x675C80 Offset: 0x674E80 VA: 0x180675C80 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x75EC50 Offset: 0x75DE50 VA: 0x18075EC50
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FA9420 Offset: 0x2FA8620 VA: 0x182FA9420 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FAA270 Offset: 0x2FA9470 VA: 0x182FAA270
	internal static PointerEvent.Button ButtonFromButtonIndex(int index) { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct TextInputEvent : IEventProperties // TypeDefIndex: 15653
{
	// Fields
	public char character; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBA74A0 Offset: 0xBA66A0 VA: 0x180BA74A0
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4B8C80 Offset: 0x4B7E80 VA: 0x1804B8C80 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x73C880 Offset: 0x73BA80 VA: 0x18073C880
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x2FAA330 Offset: 0x2FA9530 VA: 0x182FAA330 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private struct EventProvider.Registration // TypeDefIndex: 15654
{
	// Fields
	public EventConsumer handler; // 0x0
	public int priority; // 0x8
	public Nullable<int> playerId; // 0xC
	public HashSet<Event.Type> _types; // 0x18
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal static class EventProvider // TypeDefIndex: 15655
{
	// Fields
	private static IEventProviderImpl s_impl; // 0x0
	private static EventSanitizer s_sanitizer; // 0x8
	private static IEventProviderImpl s_implMockBackup; // 0x10
	private static bool m_IsEnabled; // 0x18
	private static bool m_IsInitialized; // 0x19
	private static List<EventProvider.Registration> _registrations; // 0x20

	// Methods

	// RVA: 0x2FAA430 Offset: 0x2FA9630 VA: 0x182FAA430
	internal static void Dispatch(in Event ev) { }

	[RequiredByNativeCode]
	// RVA: 0x2FAA700 Offset: 0x2FA9900 VA: 0x182FAA700
	internal static void NotifyUpdate() { }

	// RVA: 0x2FAA8A0 Offset: 0x2FA9AA0 VA: 0x182FAA8A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal sealed class EventConsumer : MulticastDelegate // TypeDefIndex: 15656
{
	// Methods

	// RVA: 0x1786B80 Offset: 0x1785D80 VA: 0x181786B80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual bool Invoke(in Event ev) { }
}

// Namespace: UnityEngine.InputForUI
internal interface IEventProviderImpl // TypeDefIndex: 15657
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();
}

// Namespace: UnityEngine.InputForUI
internal class InputEventPartialProvider // TypeDefIndex: 15658
{
	// Fields
	private Event _ev; // 0x10
	private KeyEvent.ButtonsState _keyboardButtonsState; // 0x18
	internal EventModifiers _eventModifiers; // 0x40
	internal bool _sendNavigationEventOnTabKey; // 0x44
	private IDictionary<string, CommandEvent.Command> _IMGUICommandToInputForUICommandType; // 0x48

	// Methods

	// RVA: 0x2FAAB60 Offset: 0x2FA9D60 VA: 0x182FAAB60 Slot: 4
	public void Update() { }

	// RVA: 0x2FAAFF0 Offset: 0x2FAA1F0 VA: 0x182FAAFF0
	private DiscreteTime GetTimestamp(in Event ev) { }

	// RVA: 0x2FAB060 Offset: 0x2FAA260 VA: 0x182FAB060
	private void UpdateEventModifiers(in Event ev) { }

	// RVA: 0x2FAB7D0 Offset: 0x2FAA9D0 VA: 0x182FAB7D0
	private KeyEvent ToKeyEvent(in Event ev) { }

	// RVA: 0x2FABA00 Offset: 0x2FAAC00 VA: 0x182FABA00
	private TextInputEvent ToTextInputEvent(in Event ev) { }

	// RVA: 0x2FABB00 Offset: 0x2FAAD00 VA: 0x182FABB00
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	// RVA: 0x2FABD40 Offset: 0x2FAAF40 VA: 0x182FABD40
	private CommandEvent ToCommandEvent(in Event ev) { }
}

// Namespace: 
private struct InputManagerProvider.ButtonEventsIterator : IEnumerator // TypeDefIndex: 15659
{
	// Fields
	private uint _mask; // 0x0
	private int _bit; // 0x4

	// Properties
	public bool Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2FAF6D0 Offset: 0x2FAE8D0 VA: 0x182FAF6D0
	public bool get_Current() { }

	// RVA: 0x2FAF6E0 Offset: 0x2FAE8E0 VA: 0x182FAF6E0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2FAF720 Offset: 0x2FAE920 VA: 0x182FAF720 Slot: 6
	public void Reset() { }

	// RVA: 0x2FAF730 Offset: 0x2FAE930 VA: 0x182FAF730 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FAF760 Offset: 0x2FAE960 VA: 0x182FAF760
	public static InputManagerProvider.ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current) { }
}

// Namespace: 
public struct InputManagerProvider.Configuration // TypeDefIndex: 15660
{
	// Fields
	public string HorizontalAxis; // 0x0
	public string VerticalAxis; // 0x8
	public string SubmitButton; // 0x10
	public string CancelButton; // 0x18
	public string NavigateNextButton; // 0x20
	public string NavigatePreviousButton; // 0x28
	public float InputActionsPerSecond; // 0x30
	public float RepeatDelay; // 0x34

	// Methods

	// RVA: 0x2FAF7C0 Offset: 0x2FAE9C0 VA: 0x182FAF7C0
	public static InputManagerProvider.Configuration GetDefaultConfiguration() { }
}

// Namespace: 
internal interface InputManagerProvider.IInput // TypeDefIndex: 15661
{
	// Properties
	public abstract string compositionString { get; }
	public abstract bool touchSupported { get; }
	public abstract int touchCount { get; }
	public abstract bool mousePresent { get; }
	public abstract Vector3 mousePosition { get; }
	public abstract Vector2 mouseScrollDelta { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_compositionString();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool GetKey(KeyCode keyCode);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool GetButtonDown(string button);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float GetAxisRaw(string axis);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PenData GetLastPenContactEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_touchSupported();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_touchCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Touch GetTouch(int index);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_mousePresent();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetMouseButton(int button);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool GetMouseButtonDown(int button);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool GetMouseButtonUp(int button);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector3 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Vector2 get_mouseScrollDelta();
}

// Namespace: 
private class InputManagerProvider.Input : InputManagerProvider.IInput // TypeDefIndex: 15662
{
	// Properties
	public string compositionString { get; }
	public bool touchSupported { get; }
	public int touchCount { get; }
	public bool mousePresent { get; }
	public Vector3 mousePosition { get; }
	public Vector2 mouseScrollDelta { get; }

	// Methods

	// RVA: 0x2FAFAF0 Offset: 0x2FAECF0 VA: 0x182FAFAF0 Slot: 4
	public string get_compositionString() { }

	// RVA: 0x2FAFB00 Offset: 0x2FAED00 VA: 0x182FAFB00 Slot: 5
	public bool GetKey(KeyCode key) { }

	// RVA: 0x2FAFB50 Offset: 0x2FAED50 VA: 0x182FAFB50 Slot: 6
	public bool GetButtonDown(string button) { }

	// RVA: 0x2FAFB60 Offset: 0x2FAED60 VA: 0x182FAFB60 Slot: 7
	public float GetAxisRaw(string axis) { }

	// RVA: 0x2FAFB70 Offset: 0x2FAED70 VA: 0x182FAFB70 Slot: 8
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x2FAFC00 Offset: 0x2FAEE00 VA: 0x182FAFC00 Slot: 9
	public bool get_touchSupported() { }

	// RVA: 0x2E87EC0 Offset: 0x2E870C0 VA: 0x182E87EC0 Slot: 10
	public int get_touchCount() { }

	// RVA: 0x2FAFC10 Offset: 0x2FAEE10 VA: 0x182FAFC10 Slot: 11
	public Touch GetTouch(int index) { }

	// RVA: 0x2FAFCC0 Offset: 0x2FAEEC0 VA: 0x182FAFCC0 Slot: 12
	public bool get_mousePresent() { }

	// RVA: 0x2FAFCD0 Offset: 0x2FAEED0 VA: 0x182FAFCD0 Slot: 13
	public bool GetMouseButton(int button) { }

	// RVA: 0x2FAFD20 Offset: 0x2FAEF20 VA: 0x182FAFD20 Slot: 14
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x2FAFD70 Offset: 0x2FAEF70 VA: 0x182FAFD70 Slot: 15
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x2FAFDC0 Offset: 0x2FAEFC0 VA: 0x182FAFDC0 Slot: 16
	public Vector3 get_mousePosition() { }

	// RVA: 0x2FAFE30 Offset: 0x2FAF030 VA: 0x182FAFE30 Slot: 17
	public Vector2 get_mouseScrollDelta() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
internal interface InputManagerProvider.ITime // TypeDefIndex: 15663
{
	// Properties
	public abstract RationalTime timeAsRational { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RationalTime get_timeAsRational();
}

// Namespace: 
private class InputManagerProvider.Time : InputManagerProvider.ITime // TypeDefIndex: 15664
{
	// Properties
	public RationalTime timeAsRational { get; }

	// Methods

	// RVA: 0x2FAFE90 Offset: 0x2FAF090 VA: 0x182FAFE90 Slot: 4
	public RationalTime get_timeAsRational() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.InputForUI
internal class InputManagerProvider : IEventProviderImpl // TypeDefIndex: 15665
{
	// Fields
	private InputEventPartialProvider _inputEventPartialProvider; // 0x10
	private string _compositionString; // 0x18
	private InputManagerProvider.Configuration _configuration; // 0x20
	private InputManagerProvider.IInput _input; // 0x58
	private InputManagerProvider.ITime _time; // 0x60
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; // 0x68
	private PointerState _mouseState; // 0x70
	private bool _isPenPresent; // 0x98
	private bool _seenAtLeastOnePenPosition; // 0x99
	private Vector2 _lastSeenPenPositionForDetection; // 0x9C
	private PointerState _penState; // 0xA8
	private PenData _lastPenData; // 0xD0
	private Dictionary<int, int> _touchFingerIdToFingerIndex; // 0xF8
	private int _touchNextFingerIndex; // 0x100
	private PointerState _touchState; // 0x108

	// Properties
	private EventModifiers _eventModifiers { get; }

	// Methods

	// RVA: 0x2FABFA0 Offset: 0x2FAB1A0 VA: 0x182FABFA0
	private EventModifiers get__eventModifiers() { }

	// RVA: 0x2FABFC0 Offset: 0x2FAB1C0 VA: 0x182FABFC0
	public void .ctor() { }

	// RVA: 0x2FAC350 Offset: 0x2FAB550 VA: 0x182FAC350 Slot: 4
	public void Update() { }

	// RVA: 0x2FAC840 Offset: 0x2FABA40 VA: 0x182FAC840
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	// RVA: 0x2FACF00 Offset: 0x2FAC100 VA: 0x182FACF00
	private void DetectPen() { }

	// RVA: 0x2FACFC0 Offset: 0x2FAC1C0 VA: 0x182FACFC0
	private static PointerEvent.Button PenStatusToButton(PenStatus status) { }

	// RVA: 0x2FACFE0 Offset: 0x2FAC1E0 VA: 0x182FACFE0
	private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData) { }

	// RVA: 0x2FAD4B0 Offset: 0x2FAC6B0 VA: 0x182FAD4B0
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted = False) { }

	// RVA: 0x2FADB30 Offset: 0x2FACD30 VA: 0x182FADB30
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	// RVA: 0x2FADED0 Offset: 0x2FAD0D0 VA: 0x182FADED0
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	// RVA: 0x2FAE070 Offset: 0x2FAD270 VA: 0x182FAE070
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	// RVA: 0x2FAE2A0 Offset: 0x2FAD4A0 VA: 0x182FAE2A0
	private void DirectionNavigation(DiscreteTime currentTime) { }

	// RVA: 0x2FAE660 Offset: 0x2FAD860 VA: 0x182FAE660
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	// RVA: 0x2FAE990 Offset: 0x2FADB90 VA: 0x182FAE990
	private EventSource GetEventSourceFromPressedKey() { }

	// RVA: 0x2FAEAB0 Offset: 0x2FADCB0 VA: 0x182FAEAB0
	private bool InputManagerJoystickWasPressed() { }

	// RVA: 0x2FAEB30 Offset: 0x2FADD30 VA: 0x182FAEB30
	private bool InputManagerKeyboardWasPressed() { }

	// RVA: 0x2FAEBB0 Offset: 0x2FADDB0 VA: 0x182FAEBB0
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	// RVA: 0x2FAECA0 Offset: 0x2FADEA0 VA: 0x182FAECA0
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	// RVA: 0x2FAED20 Offset: 0x2FADF20 VA: 0x182FAED20
	private ValueTuple<Vector2, bool> ReadCurrentNavigationMoveVector() { }

	// RVA: 0x2FAEE40 Offset: 0x2FAE040 VA: 0x182FAEE40
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	// RVA: 0x2FAEEF0 Offset: 0x2FAE0F0 VA: 0x182FAEEF0
	internal static float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x2FAF000 Offset: 0x2FAE200 VA: 0x182FAF000
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x2FAF0A0 Offset: 0x2FAE2A0 VA: 0x182FAF0A0
	internal static float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x2FAF0F0 Offset: 0x2FAE2F0 VA: 0x182FAF0F0
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay) { }

	// RVA: 0x2FAF3D0 Offset: 0x2FAE5D0 VA: 0x182FAF3D0
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x2FAF590 Offset: 0x2FAE790 VA: 0x182FAF590
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x2FAF6B0 Offset: 0x2FAE8B0 VA: 0x182FAF6B0
	private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }
}

// Namespace: UnityEngine.InputForUI
internal class NavigationEventRepeatHelper // TypeDefIndex: 15666
{
	// Fields
	private int m_ConsecutiveMoveCount; // 0x10
	private NavigationEvent.Direction m_LastDirection; // 0x14
	private DiscreteTime m_PrevActionTime; // 0x18
	private readonly DiscreteTime m_InitialRepeatDelay; // 0x20
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; // 0x28

	// Methods

	// RVA: 0x2FAFF00 Offset: 0x2FAF100 VA: 0x182FAFF00
	public void Reset() { }

	// RVA: 0x2FAFF70 Offset: 0x2FAF170 VA: 0x182FAFF70
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame) { }

	// RVA: 0x2FB0040 Offset: 0x2FAF240 VA: 0x182FB0040
	public void .ctor() { }
}

// Namespace: UnityEngine.InputForUI
internal struct PointerState // TypeDefIndex: 15667
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private PointerEvent.Button <LastPressedButton>k__BackingField; // 0x0
	private PointerEvent.ButtonsState _buttonsState; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <NextPressTime>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <ClickCount>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <LastPosition>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <LastDisplayIndex>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <LastPositionValid>k__BackingField; // 0x20
	private static readonly DiscreteTime kClickDelay; // 0x0

	// Properties
	public PointerEvent.Button LastPressedButton { get; set; }
	public PointerEvent.ButtonsState ButtonsState { get; }
	public DiscreteTime NextPressTime { get; set; }
	public int ClickCount { get; set; }
	public Vector2 LastPosition { get; set; }
	public int LastDisplayIndex { get; set; }
	public bool LastPositionValid { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public PointerEvent.Button get_LastPressedButton() { }

	[CompilerGenerated]
	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	private void set_LastPressedButton(PointerEvent.Button value) { }

	// RVA: 0x1324F70 Offset: 0x1324170 VA: 0x181324F70
	public PointerEvent.ButtonsState get_ButtonsState() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x5C0480 Offset: 0x5BF680 VA: 0x1805C0480
	public DiscreteTime get_NextPressTime() { }

	[CompilerGenerated]
	// RVA: 0xBA74A0 Offset: 0xBA66A0 VA: 0x180BA74A0
	private void set_NextPressTime(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4B8C80 Offset: 0x4B7E80 VA: 0x1804B8C80
	public int get_ClickCount() { }

	[CompilerGenerated]
	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	private void set_ClickCount(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1951520 Offset: 0x1950720 VA: 0x181951520
	public Vector2 get_LastPosition() { }

	[CompilerGenerated]
	// RVA: 0x2FB00F0 Offset: 0x2FAF2F0 VA: 0x182FB00F0
	private void set_LastPosition(Vector2 value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x607860 Offset: 0x606A60 VA: 0x180607860
	public int get_LastDisplayIndex() { }

	[CompilerGenerated]
	// RVA: 0x73C8A0 Offset: 0x73BAA0 VA: 0x18073C8A0
	private void set_LastDisplayIndex(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4CC200 Offset: 0x4CB400 VA: 0x1804CC200
	public bool get_LastPositionValid() { }

	[CompilerGenerated]
	// RVA: 0x54F7B0 Offset: 0x54E9B0 VA: 0x18054F7B0
	public void set_LastPositionValid(bool value) { }

	// RVA: 0x2FB0100 Offset: 0x2FAF300 VA: 0x182FB0100
	public void OnButtonDown(DiscreteTime currentTime, PointerEvent.Button button) { }

	// RVA: 0x2FB0250 Offset: 0x2FAF450 VA: 0x182FB0250
	public void OnButtonUp(DiscreteTime currentTime, PointerEvent.Button button) { }

	// RVA: 0x2FB02D0 Offset: 0x2FAF4D0 VA: 0x182FB02D0
	public void OnButtonChange(DiscreteTime currentTime, PointerEvent.Button button, bool previousState, bool newState) { }

	// RVA: 0x2FB0390 Offset: 0x2FAF590 VA: 0x182FB0390
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	// RVA: 0x2FB0410 Offset: 0x2FAF610 VA: 0x182FB0410
	public void Reset() { }

	// RVA: 0x2FB04F0 Offset: 0x2FAF6F0 VA: 0x182FB04F0
	private static void .cctor() { }
}

// Namespace: 
private interface EventSanitizer.IEventSanitizer // TypeDefIndex: 15668
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void BeforeProviderUpdate();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AfterProviderUpdate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Inspect(in Event ev);
}

// Namespace: UnityEngine.InputForUI
internal struct EventSanitizer // TypeDefIndex: 15669
{
	// Fields
	private EventSanitizer.IEventSanitizer[] _sanitizers; // 0x0

	// Methods

	// RVA: 0x2FB05E0 Offset: 0x2FAF7E0 VA: 0x182FB05E0
	public void Reset() { }

	// RVA: 0x2FB0760 Offset: 0x2FAF960 VA: 0x182FB0760
	public void BeforeProviderUpdate() { }

	// RVA: 0x2FB0890 Offset: 0x2FAFA90 VA: 0x182FB0890
	public void AfterProviderUpdate() { }

	// RVA: 0x2FB09C0 Offset: 0x2FAFBC0 VA: 0x182FB09C0
	public void Inspect(in Event ev) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 15670
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 15671
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137 /*Metadata offset 0x7EF5D0*/; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15672
{}

// Namespace: 
internal static class SR // TypeDefIndex: 15673
{
	// Methods

	// RVA: 0x25888F0 Offset: 0x2587AF0 VA: 0x1825888F0
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: 
private enum BigInteger.GetBytesMode // TypeDefIndex: 15674
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;
}

// Namespace: System.Numerics
[IsReadOnly]
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 15675
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }

	// Methods

	// RVA: 0x25889E0 Offset: 0x2587BE0 VA: 0x1825889E0
	public void .ctor(int value) { }

	// RVA: 0x2588B20 Offset: 0x2587D20 VA: 0x182588B20
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2588E00 Offset: 0x2588000 VA: 0x182588E00
	public void .ctor(byte[] value) { }

	// RVA: 0x2588EF0 Offset: 0x25880F0 VA: 0x182588EF0
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x754CF0 Offset: 0x753EF0 VA: 0x180754CF0
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x2589950 Offset: 0x2588B50 VA: 0x182589950
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x2589C90 Offset: 0x2588E90 VA: 0x182589C90
	public static BigInteger get_Zero() { }

	// RVA: 0x2589CF0 Offset: 0x2588EF0 VA: 0x182589CF0
	public static BigInteger get_MinusOne() { }

	// RVA: 0x2589D50 Offset: 0x2588F50 VA: 0x182589D50
	public static BigInteger Parse(string value) { }

	// RVA: 0x2589E20 Offset: 0x2589020 VA: 0x182589E20
	public static BigInteger Parse(string value, NumberStyles style) { }

	// RVA: 0x2589ED0 Offset: 0x25890D0 VA: 0x182589ED0
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2589F30 Offset: 0x2589130 VA: 0x182589F30
	public static BigInteger Divide(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x2589FC0 Offset: 0x25891C0 VA: 0x182589FC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x258A020 Offset: 0x2589220 VA: 0x18258A020 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x258A0D0 Offset: 0x25892D0 VA: 0x18258A0D0 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x258A1F0 Offset: 0x25893F0 VA: 0x18258A1F0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x258A3C0 Offset: 0x25895C0 VA: 0x18258A3C0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x258A4D0 Offset: 0x25896D0 VA: 0x18258A4D0
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x258A590 Offset: 0x2589790 VA: 0x18258A590
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x258A640 Offset: 0x2589840 VA: 0x18258A640
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x258ABC0 Offset: 0x2589DC0 VA: 0x18258ABC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x258AC90 Offset: 0x2589E90 VA: 0x18258AC90 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x258AD90 Offset: 0x2589F90 VA: 0x18258AD90
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x258AF50 Offset: 0x258A150 VA: 0x18258AF50
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x258B170 Offset: 0x258A370 VA: 0x18258B170
	public static BigInteger op_Implicit(byte value) { }

	// RVA: 0x258B1A0 Offset: 0x258A3A0 VA: 0x18258B1A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x258B1C0 Offset: 0x258A3C0 VA: 0x18258B1C0
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x258B1E0 Offset: 0x258A3E0 VA: 0x18258B1E0
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x258B270 Offset: 0x258A470 VA: 0x18258B270
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x258B3A0 Offset: 0x258A5A0 VA: 0x18258B3A0
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x258B670 Offset: 0x258A870 VA: 0x18258B670
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x258BAF0 Offset: 0x258ACF0 VA: 0x18258BAF0
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x258BB60 Offset: 0x258AD60 VA: 0x18258BB60
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x258BD80 Offset: 0x258AF80 VA: 0x18258BD80
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x258C0B0 Offset: 0x258B2B0 VA: 0x18258C0B0
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x258C470 Offset: 0x258B670 VA: 0x18258C470
	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x258C730 Offset: 0x258B930 VA: 0x18258C730
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x258C910 Offset: 0x258BB10 VA: 0x18258C910
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x258C980 Offset: 0x258BB80 VA: 0x18258C980
	private static void .cctor() { }
}

// Namespace: System.Numerics
internal static class BigIntegerCalculator // TypeDefIndex: 15676
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x258CE40 Offset: 0x258C040 VA: 0x18258CE40
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x258CF10 Offset: 0x258C110 VA: 0x18258CF10
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x258D030 Offset: 0x258C230 VA: 0x18258D030
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x258D0E0 Offset: 0x258C2E0 VA: 0x18258D0E0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x258D150 Offset: 0x258C350 VA: 0x18258D150
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x258D210 Offset: 0x258C410 VA: 0x18258D210
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x258D3B0 Offset: 0x258C5B0 VA: 0x18258D3B0
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x258D460 Offset: 0x258C660 VA: 0x18258D460
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x258D4E0 Offset: 0x258C6E0 VA: 0x18258D4E0
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x258D5C0 Offset: 0x258C7C0 VA: 0x18258D5C0
	public static uint Remainder(uint[] left, uint right) { }

	// RVA: 0x258D630 Offset: 0x258C830 VA: 0x18258D630
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x258D770 Offset: 0x258C970 VA: 0x18258D770
	public static uint[] Remainder(uint[] left, uint[] right) { }

	// RVA: 0x258D870 Offset: 0x258CA70 VA: 0x18258D870
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x258DC40 Offset: 0x258CE40 VA: 0x18258DC40
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x258DC70 Offset: 0x258CE70 VA: 0x18258DC70
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x258DCC0 Offset: 0x258CEC0 VA: 0x18258DCC0
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x258DD00 Offset: 0x258CF00 VA: 0x18258DD00
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x258DD80 Offset: 0x258CF80 VA: 0x18258DD80
	private static int LeadingZeros(uint value) { }

	// RVA: 0x258DDF0 Offset: 0x258CFF0 VA: 0x18258DDF0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x258DEE0 Offset: 0x258D0E0 VA: 0x18258DEE0
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x258E310 Offset: 0x258D510 VA: 0x18258E310
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x258E3E0 Offset: 0x258D5E0 VA: 0x18258E3E0
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x258E510 Offset: 0x258D710 VA: 0x18258E510
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x258EA70 Offset: 0x258DC70 VA: 0x18258EA70
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x258EB80 Offset: 0x258DD80 VA: 0x18258EB80
	private static void .cctor() { }
}

// Namespace: 
private struct BigNumber.BigNumberBuffer // TypeDefIndex: 15677
{
	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x25911C0 Offset: 0x25903C0 VA: 0x1825911C0
	public static BigNumber.BigNumberBuffer Create() { }
}

// Namespace: System.Numerics
internal static class BigNumber // TypeDefIndex: 15678
{
	// Methods

	// RVA: 0x258EC00 Offset: 0x258DE00 VA: 0x18258EC00
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x258EEA0 Offset: 0x258E0A0 VA: 0x18258EEA0
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x258F140 Offset: 0x258E340 VA: 0x18258F140
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x258F350 Offset: 0x258E550 VA: 0x18258F350
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x258F4C0 Offset: 0x258E6C0 VA: 0x18258F4C0
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x258F790 Offset: 0x258E990 VA: 0x18258F790
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x258FC00 Offset: 0x258EE00 VA: 0x18258FC00
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x258FD50 Offset: 0x258EF50 VA: 0x18258FD50
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x2590350 Offset: 0x258F550 VA: 0x182590350
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x2590440 Offset: 0x258F640 VA: 0x182590440
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}

// Namespace: System.Numerics
internal static class NumericsHelpers // TypeDefIndex: 15679
{
	// Methods

	// RVA: 0x2591270 Offset: 0x2590470 VA: 0x182591270
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x2591310 Offset: 0x2590510 VA: 0x182591310
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x2591320 Offset: 0x2590520 VA: 0x182591320
	public static uint Abs(int a) { }

	// RVA: 0x2591330 Offset: 0x2590530 VA: 0x182591330
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x2591330 Offset: 0x2590530 VA: 0x182591330
	public static int CombineHash(int n1, int n2) { }
}

// Namespace: 
internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 15680
{
	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	public bool sign; // 0x8
	public char* overrideDigits; // 0x10

	// Properties
	public char* digits { get; }

	// Methods

	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public char* get_digits() { }
}

// Namespace: 
private class FormatProvider.Number // TypeDefIndex: 15681
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x2591700 Offset: 0x2590900 VA: 0x182591700
	private static bool IsWhite(char ch) { }

	// RVA: 0x2591720 Offset: 0x2590920 VA: 0x182591720
	private static char* MatchChars(char* p, char* pEnd, string str) { }

	// RVA: 0x25917E0 Offset: 0x25909E0 VA: 0x1825917E0
	private static char* MatchChars(char* p, char* pEnd, char* str) { }

	// RVA: 0x2591830 Offset: 0x2590A30 VA: 0x182591830
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x25922F0 Offset: 0x25914F0 VA: 0x1825922F0
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2592370 Offset: 0x2591570 VA: 0x182592370
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2592500 Offset: 0x2591700 VA: 0x182592500
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x2592570 Offset: 0x2591770 VA: 0x182592570
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x2592710 Offset: 0x2591910 VA: 0x182592710
	internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2592DB0 Offset: 0x2591FB0 VA: 0x182592DB0
	private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2593000 Offset: 0x2592200 VA: 0x182593000
	private static int wcslen(char* s) { }

	// RVA: 0x2593020 Offset: 0x2592220 VA: 0x182593020
	private static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x2593430 Offset: 0x2592630 VA: 0x182593430
	private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2593630 Offset: 0x2592830 VA: 0x182593630
	private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x2593760 Offset: 0x2592960 VA: 0x182593760
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2593900 Offset: 0x2592B00 VA: 0x182593900
	private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2593B70 Offset: 0x2592D70 VA: 0x182593B70
	private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2593DC0 Offset: 0x2592FC0 VA: 0x182593DC0
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x2593EB0 Offset: 0x25930B0 VA: 0x182593EB0
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0x2593FC0 Offset: 0x25931C0 VA: 0x182593FC0
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x2594C40 Offset: 0x2593E40 VA: 0x182594C40
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 15682
{
	// Methods

	// RVA: 0x2591340 Offset: 0x2590540 VA: 0x182591340
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x25914C0 Offset: 0x25906C0 VA: 0x1825914C0
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}

// Namespace: System.Text
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 15683
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x2278700 Offset: 0x2277900 VA: 0x182278700
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510
	public int get_Length() { }

	// RVA: 0x25955B0 Offset: 0x25947B0 VA: 0x1825955B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2595690 Offset: 0x2594890 VA: 0x182595690
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x25957E0 Offset: 0x25949E0 VA: 0x1825957E0
	public void Insert(int index, char value, int count) { }

	// RVA: 0x2595AA0 Offset: 0x2594CA0 VA: 0x182595AA0
	public void Append(char c) { }

	// RVA: 0x2595B20 Offset: 0x2594D20 VA: 0x182595B20
	public void Append(string s) { }

	// RVA: 0x2595BC0 Offset: 0x2594DC0 VA: 0x182595BC0
	private void AppendSlow(string s) { }

	// RVA: 0x2595D60 Offset: 0x2594F60 VA: 0x182595D60
	public void Append(char c, int count) { }

	// RVA: 0x2595E40 Offset: 0x2595040 VA: 0x182595E40
	public void Append(char* value, int length) { }

	// RVA: 0x2595F20 Offset: 0x2595120 VA: 0x182595F20
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x2596000 Offset: 0x2595200 VA: 0x182596000
	private void GrowAndAppend(char c) { }

	// RVA: 0x2596040 Offset: 0x2595240 VA: 0x182596040
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x2596240 Offset: 0x2595440 VA: 0x182596240
	public void Dispose() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15684
{}

// Namespace: UnityEngine
public enum AudioDataLoadState // TypeDefIndex: 15685
{
	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;
}

// Namespace: UnityEngine
public enum FFTWindow // TypeDefIndex: 15686
{
	// Fields
	public int value__; // 0x0
	public const FFTWindow Rectangular = 0;
	public const FFTWindow Triangle = 1;
	public const FFTWindow Hamming = 2;
	public const FFTWindow Hanning = 3;
	public const FFTWindow Blackman = 4;
	public const FFTWindow BlackmanHarris = 5;
}

// Namespace: UnityEngine
public enum AudioRolloffMode // TypeDefIndex: 15687
{
	// Fields
	public int value__; // 0x0
	public const AudioRolloffMode Logarithmic = 0;
	public const AudioRolloffMode Linear = 1;
	public const AudioRolloffMode Custom = 2;
}

// Namespace: UnityEngine
public enum AudioSourceCurveType // TypeDefIndex: 15688
{
	// Fields
	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;
}

// Namespace: 
public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 15689
{
	// Methods

	// RVA: 0x488CA0 Offset: 0x487EA0 VA: 0x180488CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(bool deviceWasChanged) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", 0)]
public sealed class AudioSettings // TypeDefIndex: 15690
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Properties
	public static double dspTime { get; }
	public static int outputSampleRate { get; }

	// Methods

	[NativeMethod(Name = "AudioSettings::GetSampleRate", IsFreeFunction = True)]
	// RVA: 0x2EB0890 Offset: 0x2EAFA90 VA: 0x182EB0890
	private static int GetSampleRate() { }

	[NativeMethod(Name = "GetDSPTime", IsThreadSafe = True)]
	// RVA: 0x2EB08E0 Offset: 0x2EAFAE0 VA: 0x182EB08E0
	public static double get_dspTime() { }

	// RVA: 0x2EB0890 Offset: 0x2EAFA90 VA: 0x182EB0890
	public static int get_outputSampleRate() { }

	[RequiredByNativeCode]
	// RVA: 0x2EB0930 Offset: 0x2EAFB30 VA: 0x182EB0930
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x2EB0990 Offset: 0x2EAFB90 VA: 0x182EB0990
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x2EB09F0 Offset: 0x2EAFBF0 VA: 0x182EB09F0
	internal static void InvokeOnAudioSystemStartedUp() { }
}

// Namespace: 
public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 15691
{
	// Methods

	// RVA: 0x46FF20 Offset: 0x46F120 VA: 0x18046FF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(float[] data) { }
}

// Namespace: 
public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 15692
{
	// Methods

	// RVA: 0x46FBC0 Offset: 0x46EDC0 VA: 0x18046FBC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(int position) { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioClipBindings", 2)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioClip : AudioResource // TypeDefIndex: 15693
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }
	[NativeProperty("SampleCount")]
	public int samples { get; }
	[NativeProperty("ChannelCount")]
	public int channels { get; }
	public int frequency { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x2EB0A50 Offset: 0x2EAFC50 VA: 0x182EB0A50
	private void .ctor() { }

	// RVA: 0x2EB0B50 Offset: 0x2EAFD50 VA: 0x182EB0B50
	private static bool GetData(AudioClip clip, Span<float> data, int samplesOffset) { }

	// RVA: 0x2EB0C80 Offset: 0x2EAFE80 VA: 0x182EB0C80
	private static AudioClip Construct_Internal() { }

	// RVA: 0x2EB0D00 Offset: 0x2EAFF00 VA: 0x182EB0D00
	private string GetName() { }

	// RVA: 0x2EB0E30 Offset: 0x2EB0030 VA: 0x182EB0E30
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x2EB1000 Offset: 0x2EB0200 VA: 0x182EB1000
	public float get_length() { }

	// RVA: 0x2EB10A0 Offset: 0x2EB02A0 VA: 0x182EB10A0
	public int get_samples() { }

	// RVA: 0x2EB1140 Offset: 0x2EB0340 VA: 0x182EB1140
	public int get_channels() { }

	// RVA: 0x2EB11E0 Offset: 0x2EB03E0 VA: 0x182EB11E0
	public int get_frequency() { }

	// RVA: 0x2EB1280 Offset: 0x2EB0480 VA: 0x182EB1280
	public bool LoadAudioData() { }

	// RVA: 0x2EB1320 Offset: 0x2EB0520 VA: 0x182EB1320
	public bool UnloadAudioData() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	// RVA: 0x2EB13C0 Offset: 0x2EB05C0 VA: 0x182EB13C0
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x2EB1460 Offset: 0x2EB0660 VA: 0x182EB1460
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x2EB16E0 Offset: 0x2EB08E0 VA: 0x182EB16E0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x2EB1710 Offset: 0x2EB0910 VA: 0x182EB1710
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGenerated]
	// RVA: 0x2EB1B00 Offset: 0x2EB0D00 VA: 0x182EB1B00
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2EB1BF0 Offset: 0x2EB0DF0 VA: 0x182EB1BF0
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2EB1CE0 Offset: 0x2EB0EE0 VA: 0x182EB1CE0
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2EB1DD0 Offset: 0x2EB0FD0 VA: 0x182EB1DD0
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCode]
	// RVA: 0x2EB1EC0 Offset: 0x2EB10C0 VA: 0x182EB1EC0
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x2EB1EE0 Offset: 0x2EB10E0 VA: 0x182EB1EE0
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	// RVA: 0x2EB1F00 Offset: 0x2EB1100 VA: 0x182EB1F00
	private static bool GetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset) { }

	// RVA: 0x2EB1F70 Offset: 0x2EB1170 VA: 0x182EB1F70
	private static IntPtr Construct_Internal_Injected() { }

	// RVA: 0x2EB1FC0 Offset: 0x2EB11C0 VA: 0x182EB1FC0
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2EB2020 Offset: 0x2EB1220 VA: 0x182EB2020
	private static void CreateUserSound_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x2EB20B0 Offset: 0x2EB12B0 VA: 0x182EB20B0
	private static float get_length_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB2100 Offset: 0x2EB1300 VA: 0x182EB2100
	private static int get_samples_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB2150 Offset: 0x2EB1350 VA: 0x182EB2150
	private static int get_channels_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB21A0 Offset: 0x2EB13A0 VA: 0x182EB21A0
	private static int get_frequency_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB21F0 Offset: 0x2EB13F0 VA: 0x182EB21F0
	private static bool LoadAudioData_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB2240 Offset: 0x2EB1440 VA: 0x182EB2240
	private static bool UnloadAudioData_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB2290 Offset: 0x2EB1490 VA: 0x182EB2290
	private static AudioDataLoadState get_loadState_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
public class AudioBehaviour : Behaviour // TypeDefIndex: 15694
{
	// Methods

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioListenerBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 15695
{
	// Properties
	public static float volume { set; }
	[NativeProperty("ListenerPause")]
	public static bool pause { set; }

	// Methods

	[NativeThrows]
	// RVA: 0x2EB22E0 Offset: 0x2EB14E0 VA: 0x182EB22E0
	private static void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x2EB2400 Offset: 0x2EB1600 VA: 0x182EB2400
	public static void set_volume(float value) { }

	// RVA: 0x2EB2460 Offset: 0x2EB1660 VA: 0x182EB2460
	public static void set_pause(bool value) { }

	// RVA: 0x2EB24B0 Offset: 0x2EB16B0 VA: 0x182EB24B0
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x2EB24C0 Offset: 0x2EB16C0 VA: 0x182EB24C0
	private static void GetSpectrumDataHelper_Injected(out BlittableArrayWrapper samples, int channel, FFTWindow window) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", 2)]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 15696
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativeProperty("SecPosition")]
	public float time { get; set; }
	[NativeProperty("SamplePosition")]
	public int timeSamples { get; set; }
	public AudioClip clip { get; set; }
	public AudioResource resource { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool loop { get; set; }
	public bool playOnAwake { set; }
	[NativeProperty("StereoPan")]
	public float panStereo { get; set; }
	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend { get; set; }
	public float reverbZoneMix { set; }
	public bool bypassEffects { set; }
	public bool bypassListenerEffects { set; }
	public bool bypassReverbZones { set; }
	public float dopplerLevel { set; }
	public float spread { get; set; }
	public int priority { set; }
	public bool mute { get; set; }
	public float minDistance { set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { set; }

	// Methods

	// RVA: 0x2EB2530 Offset: 0x2EB1730 VA: 0x182EB2530
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x2EB25F0 Offset: 0x2EB17F0 VA: 0x182EB25F0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x2EB26C0 Offset: 0x2EB18C0 VA: 0x182EB26C0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x2EB2790 Offset: 0x2EB1990 VA: 0x182EB2790
	private void Play(double delay) { }

	// RVA: 0x2EB2840 Offset: 0x2EB1A40 VA: 0x182EB2840
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x2EB2980 Offset: 0x2EB1B80 VA: 0x182EB2980
	private void Stop(bool stopOneShots) { }

	[NativeThrows]
	// RVA: 0x2EB2A30 Offset: 0x2EB1C30 VA: 0x182EB2A30
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x2EB2B20 Offset: 0x2EB1D20 VA: 0x182EB2B20
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	[NativeThrows]
	// RVA: 0x2EB2C40 Offset: 0x2EB1E40 VA: 0x182EB2C40
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x2EB2DD0 Offset: 0x2EB1FD0 VA: 0x182EB2DD0
	public float get_volume() { }

	// RVA: 0x2EB2E70 Offset: 0x2EB2070 VA: 0x182EB2E70
	public void set_volume(float value) { }

	// RVA: 0x2EB2530 Offset: 0x2EB1730 VA: 0x182EB2530
	public float get_pitch() { }

	// RVA: 0x2EB25F0 Offset: 0x2EB17F0 VA: 0x182EB25F0
	public void set_pitch(float value) { }

	// RVA: 0x2EB2F20 Offset: 0x2EB2120 VA: 0x182EB2F20
	public float get_time() { }

	// RVA: 0x2EB2FC0 Offset: 0x2EB21C0 VA: 0x182EB2FC0
	public void set_time(float value) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2EB3070 Offset: 0x2EB2270 VA: 0x182EB3070
	public int get_timeSamples() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2EB3110 Offset: 0x2EB2310 VA: 0x182EB3110
	public void set_timeSamples(int value) { }

	// RVA: 0x2EB31C0 Offset: 0x2EB23C0 VA: 0x182EB31C0
	public AudioClip get_clip() { }

	// RVA: 0x2EB32D0 Offset: 0x2EB24D0 VA: 0x182EB32D0
	public void set_clip(AudioClip value) { }

	// RVA: 0x2EB33B0 Offset: 0x2EB25B0 VA: 0x182EB33B0
	public AudioResource get_resource() { }

	// RVA: 0x2EB32D0 Offset: 0x2EB24D0 VA: 0x182EB32D0
	public void set_resource(AudioResource value) { }

	// RVA: 0x2EB3470 Offset: 0x2EB2670 VA: 0x182EB3470
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x2EB3530 Offset: 0x2EB2730 VA: 0x182EB3530
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocs]
	// RVA: 0x2EB3610 Offset: 0x2EB2810 VA: 0x182EB3610
	public void Play() { }

	// RVA: 0x2EB3620 Offset: 0x2EB2820 VA: 0x182EB3620
	public void Play(ulong delay) { }

	// RVA: 0x2EB3630 Offset: 0x2EB2830 VA: 0x182EB3630
	public void PlayDelayed(float delay) { }

	// RVA: 0x2EB3670 Offset: 0x2EB2870 VA: 0x182EB3670
	public void PlayScheduled(double time) { }

	[ExcludeFromDocs]
	// RVA: 0x2EB36A0 Offset: 0x2EB28A0 VA: 0x182EB36A0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x2EB36B0 Offset: 0x2EB28B0 VA: 0x182EB36B0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x2EB38F0 Offset: 0x2EB2AF0 VA: 0x182EB38F0
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x2EB39A0 Offset: 0x2EB2BA0 VA: 0x182EB39A0
	public void Stop() { }

	// RVA: 0x2EB3A40 Offset: 0x2EB2C40 VA: 0x182EB3A40
	public void Pause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x2EB3AE0 Offset: 0x2EB2CE0 VA: 0x182EB3AE0
	public bool get_isPlaying() { }

	// RVA: 0x2EB3B80 Offset: 0x2EB2D80 VA: 0x182EB3B80
	public bool get_loop() { }

	// RVA: 0x2EB3C20 Offset: 0x2EB2E20 VA: 0x182EB3C20
	public void set_loop(bool value) { }

	// RVA: 0x2EB3CD0 Offset: 0x2EB2ED0 VA: 0x182EB3CD0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x2EB3D80 Offset: 0x2EB2F80 VA: 0x182EB3D80
	public float get_panStereo() { }

	// RVA: 0x2EB3E20 Offset: 0x2EB3020 VA: 0x182EB3E20
	public void set_panStereo(float value) { }

	// RVA: 0x2EB3ED0 Offset: 0x2EB30D0 VA: 0x182EB3ED0
	public float get_spatialBlend() { }

	// RVA: 0x2EB3F70 Offset: 0x2EB3170 VA: 0x182EB3F70
	public void set_spatialBlend(float value) { }

	// RVA: 0x2EB2A30 Offset: 0x2EB1C30 VA: 0x182EB2A30
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x2EB2B20 Offset: 0x2EB1D20 VA: 0x182EB2B20
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x2EB4020 Offset: 0x2EB3220 VA: 0x182EB4020
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x2EB40D0 Offset: 0x2EB32D0 VA: 0x182EB40D0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x2EB4180 Offset: 0x2EB3380 VA: 0x182EB4180
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x2EB4230 Offset: 0x2EB3430 VA: 0x182EB4230
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x2EB42E0 Offset: 0x2EB34E0 VA: 0x182EB42E0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x2EB4390 Offset: 0x2EB3590 VA: 0x182EB4390
	public float get_spread() { }

	// RVA: 0x2EB4430 Offset: 0x2EB3630 VA: 0x182EB4430
	public void set_spread(float value) { }

	// RVA: 0x2EB44E0 Offset: 0x2EB36E0 VA: 0x182EB44E0
	public void set_priority(int value) { }

	// RVA: 0x2EB4590 Offset: 0x2EB3790 VA: 0x182EB4590
	public bool get_mute() { }

	// RVA: 0x2EB4630 Offset: 0x2EB3830 VA: 0x182EB4630
	public void set_mute(bool value) { }

	// RVA: 0x2EB46E0 Offset: 0x2EB38E0 VA: 0x182EB46E0
	public void set_minDistance(float value) { }

	// RVA: 0x2EB4790 Offset: 0x2EB3990 VA: 0x182EB4790
	public float get_maxDistance() { }

	// RVA: 0x2EB4830 Offset: 0x2EB3A30 VA: 0x182EB4830
	public void set_maxDistance(float value) { }

	// RVA: 0x2EB48E0 Offset: 0x2EB3AE0 VA: 0x182EB48E0
	public void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x2EB4990 Offset: 0x2EB3B90 VA: 0x182EB4990
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x2EB49A0 Offset: 0x2EB3BA0 VA: 0x182EB49A0
	private static float GetPitch_Injected(IntPtr source) { }

	// RVA: 0x2EB49F0 Offset: 0x2EB3BF0 VA: 0x182EB49F0
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	// RVA: 0x2EB4A50 Offset: 0x2EB3C50 VA: 0x182EB4A50
	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	// RVA: 0x2EB4AB0 Offset: 0x2EB3CB0 VA: 0x182EB4AB0
	private static void Play_Injected(IntPtr _unity_self, double delay) { }

	// RVA: 0x2EB4B10 Offset: 0x2EB3D10 VA: 0x182EB4B10
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	// RVA: 0x2EB4B80 Offset: 0x2EB3D80 VA: 0x182EB4B80
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	// RVA: 0x2EB4BE0 Offset: 0x2EB3DE0 VA: 0x182EB4BE0
	private static void SetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type, IntPtr curve) { }

	// RVA: 0x2EB4C50 Offset: 0x2EB3E50 VA: 0x182EB4C50
	private static IntPtr GetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type) { }

	// RVA: 0x2EB4CB0 Offset: 0x2EB3EB0 VA: 0x182EB4CB0
	private static void GetSpectrumDataHelper_Injected(IntPtr source, out BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	// RVA: 0x2EB4D30 Offset: 0x2EB3F30 VA: 0x182EB4D30
	private static float get_volume_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB4D80 Offset: 0x2EB3F80 VA: 0x182EB4D80
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB4DE0 Offset: 0x2EB3FE0 VA: 0x182EB4DE0
	private static float get_time_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB4E30 Offset: 0x2EB4030 VA: 0x182EB4E30
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB4E90 Offset: 0x2EB4090 VA: 0x182EB4E90
	private static int get_timeSamples_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB4EE0 Offset: 0x2EB40E0 VA: 0x182EB4EE0
	private static void set_timeSamples_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2EB4F40 Offset: 0x2EB4140 VA: 0x182EB4F40
	private static IntPtr get_resource_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB4F90 Offset: 0x2EB4190 VA: 0x182EB4F90
	private static void set_resource_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x2EB4FF0 Offset: 0x2EB41F0 VA: 0x182EB4FF0
	private static IntPtr get_outputAudioMixerGroup_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5040 Offset: 0x2EB4240 VA: 0x182EB5040
	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x2EB50A0 Offset: 0x2EB42A0 VA: 0x182EB50A0
	private static void SetScheduledEndTime_Injected(IntPtr _unity_self, double time) { }

	// RVA: 0x2EB5100 Offset: 0x2EB4300 VA: 0x182EB5100
	private static void Pause_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5150 Offset: 0x2EB4350 VA: 0x182EB5150
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB51A0 Offset: 0x2EB43A0 VA: 0x182EB51A0
	private static bool get_loop_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB51F0 Offset: 0x2EB43F0 VA: 0x182EB51F0
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB5250 Offset: 0x2EB4450 VA: 0x182EB5250
	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB52B0 Offset: 0x2EB44B0 VA: 0x182EB52B0
	private static float get_panStereo_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5300 Offset: 0x2EB4500 VA: 0x182EB5300
	private static void set_panStereo_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB5360 Offset: 0x2EB4560 VA: 0x182EB5360
	private static float get_spatialBlend_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB53B0 Offset: 0x2EB45B0 VA: 0x182EB53B0
	private static void set_spatialBlend_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB5410 Offset: 0x2EB4610 VA: 0x182EB5410
	private static void set_reverbZoneMix_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB5470 Offset: 0x2EB4670 VA: 0x182EB5470
	private static void set_bypassEffects_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB54D0 Offset: 0x2EB46D0 VA: 0x182EB54D0
	private static void set_bypassListenerEffects_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB5530 Offset: 0x2EB4730 VA: 0x182EB5530
	private static void set_bypassReverbZones_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB5590 Offset: 0x2EB4790 VA: 0x182EB5590
	private static void set_dopplerLevel_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB55F0 Offset: 0x2EB47F0 VA: 0x182EB55F0
	private static float get_spread_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5640 Offset: 0x2EB4840 VA: 0x182EB5640
	private static void set_spread_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB56A0 Offset: 0x2EB48A0 VA: 0x182EB56A0
	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2EB5700 Offset: 0x2EB4900 VA: 0x182EB5700
	private static bool get_mute_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5750 Offset: 0x2EB4950 VA: 0x182EB5750
	private static void set_mute_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2EB57B0 Offset: 0x2EB49B0 VA: 0x182EB57B0
	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB5810 Offset: 0x2EB4A10 VA: 0x182EB5810
	private static float get_maxDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x2EB5860 Offset: 0x2EB4A60 VA: 0x182EB5860
	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB58C0 Offset: 0x2EB4AC0 VA: 0x182EB58C0
	private static void set_rolloffMode_Injected(IntPtr _unity_self, AudioRolloffMode value) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioLowPassFilter : Behaviour // TypeDefIndex: 15697
{
	// Properties
	public float cutoffFrequency { set; }

	// Methods

	// RVA: 0x2EB5920 Offset: 0x2EB4B20 VA: 0x182EB5920
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x2EB59D0 Offset: 0x2EB4BD0 VA: 0x182EB59D0
	private static void set_cutoffFrequency_Injected(IntPtr _unity_self, float value) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioHighPassFilter : Behaviour // TypeDefIndex: 15698
{}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioDistortionFilter : Behaviour // TypeDefIndex: 15699
{}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioEchoFilter : Behaviour // TypeDefIndex: 15700
{
	// Methods

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioReverbFilter : Behaviour // TypeDefIndex: 15701
{
	// Properties
	public float dryLevel { set; }
	public float room { set; }

	// Methods

	// RVA: 0x2EB5A30 Offset: 0x2EB4C30 VA: 0x182EB5A30
	public void set_dryLevel(float value) { }

	// RVA: 0x2EB5AE0 Offset: 0x2EB4CE0 VA: 0x182EB5AE0
	public void set_room(float value) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x2EB5B90 Offset: 0x2EB4D90 VA: 0x182EB5B90
	private static void set_dryLevel_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2EB5BF0 Offset: 0x2EB4DF0 VA: 0x182EB5BF0
	private static void set_room_Injected(IntPtr _unity_self, float value) { }
}

// Namespace: UnityEngine
[StaticAccessor("GetAudioManager()", 0)]
public sealed class Microphone // TypeDefIndex: 15702
{
	// Properties
	public static string[] devices { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2EB5C50 Offset: 0x2EB4E50 VA: 0x182EB5C50
	private static int GetMicrophoneDeviceIDFromName(string name) { }

	// RVA: 0x2EB5D90 Offset: 0x2EB4F90 VA: 0x182EB5D90
	private static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency) { }

	// RVA: 0x2EB5E40 Offset: 0x2EB5040 VA: 0x182EB5E40
	private static void EndRecord(int deviceID) { }

	// RVA: 0x2EB5E90 Offset: 0x2EB5090 VA: 0x182EB5E90
	private static bool IsRecording(int deviceID) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2EB5EE0 Offset: 0x2EB50E0 VA: 0x182EB5EE0
	private static int GetRecordPosition(int deviceID) { }

	// RVA: 0x2EB5F30 Offset: 0x2EB5130 VA: 0x182EB5F30
	public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency) { }

	// RVA: 0x2EB6200 Offset: 0x2EB5400 VA: 0x182EB6200
	public static void End(string deviceName) { }

	[NativeName("GetRecordDevices")]
	// RVA: 0x2EB6260 Offset: 0x2EB5460 VA: 0x182EB6260
	public static string[] get_devices() { }

	// RVA: 0x2EB62B0 Offset: 0x2EB54B0 VA: 0x182EB62B0
	public static bool IsRecording(string deviceName) { }

	// RVA: 0x2EB6320 Offset: 0x2EB5520 VA: 0x182EB6320
	public static int GetPosition(string deviceName) { }

	// RVA: 0x2EB6390 Offset: 0x2EB5590 VA: 0x182EB6390
	private static int GetMicrophoneDeviceIDFromName_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x2EB63E0 Offset: 0x2EB55E0 VA: 0x182EB63E0
	private static IntPtr StartRecord_Injected(int deviceID, bool loop, float lengthSec, int frequency) { }
}

// Namespace: 
public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 15703
{
	// Methods

	// RVA: 0xBEA660 Offset: 0xBE9860 VA: 0x180BEA660
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46EB30 Offset: 0x46DD30 VA: 0x18046EB30 Slot: 12
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }
}

// Namespace: UnityEngine.Experimental.Audio
[StaticAccessor("AudioSampleProviderBindings", 2)]
[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
public class AudioSampleProvider // TypeDefIndex: 15704
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2EB6460 Offset: 0x2EB5660 VA: 0x182EB6460
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2EB6490 Offset: 0x2EB5690 VA: 0x182EB6490
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioResource.h")]
public abstract class AudioResource : Object // TypeDefIndex: 15705
{
	// Methods

	// RVA: 0x2EB64C0 Offset: 0x2EB56C0 VA: 0x182EB64C0
	protected internal void .ctor() { }
}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 15706
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x16C0C90 Offset: 0x16BFE90 VA: 0x1816C0C90 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2EB6510 Offset: 0x2EB5710 VA: 0x182EB6510 Slot: 5
	public bool Equals(AudioClipPlayable other) { }
}

// Namespace: UnityEngine.Audio
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
public class AudioMixer : Object // TypeDefIndex: 15707
{
	// Methods

	// RVA: 0x2EB65D0 Offset: 0x2EB57D0 VA: 0x182EB65D0
	internal void .ctor() { }

	[NativeMethod]
	// RVA: 0x2EB6620 Offset: 0x2EB5820 VA: 0x182EB6620
	public bool SetFloat(string name, float value) { }

	[NativeMethod]
	// RVA: 0x2EB67C0 Offset: 0x2EB59C0 VA: 0x182EB67C0
	public bool GetFloat(string name, out float value) { }

	// RVA: 0x2EB6960 Offset: 0x2EB5B60 VA: 0x182EB6960
	private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }

	// RVA: 0x2EB69D0 Offset: 0x2EB5BD0 VA: 0x182EB69D0
	private static bool GetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out float value) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object // TypeDefIndex: 15708
{
	// Methods

	// RVA: 0x2EB6A40 Offset: 0x2EB5C40 VA: 0x182EB6A40
	internal void .ctor() { }
}

// Namespace: UnityEngine.Audio
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 15709
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x16C0C90 Offset: 0x16BFE90 VA: 0x1816C0C90 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2EB6A90 Offset: 0x2EB5C90 VA: 0x182EB6A90 Slot: 5
	public bool Equals(AudioMixerPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object // TypeDefIndex: 15710
{}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[StaticAccessor("AudioPlayableOutputBindings", 2)]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
public struct AudioPlayableOutput // TypeDefIndex: 15711
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15712
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 15713
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 15714
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 15715
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x2517E70 Offset: 0x2517070 VA: 0x182517E70
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 15716
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x490E20 Offset: 0x490020 VA: 0x180490E20
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NativeIntegerAttribute : Attribute // TypeDefIndex: 15717
{
	// Fields
	public readonly bool[] TransformFlags; // 0x10

	// Methods

	// RVA: 0x2517F30 Offset: 0x2517130 VA: 0x182517F30
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(2, AllowMultiple = False, Inherited = False)]
internal sealed class RefSafetyRulesAttribute : Attribute // TypeDefIndex: 15718
{
	// Fields
	public readonly int Version; // 0x10

	// Methods

	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	public void .ctor(int ) { }
}

// Namespace: System.Runtime.CompilerServices
[NullableContext(1)]
[Nullable(0)]
[Usage(32767, AllowMultiple = True, Inherited = False)]
[ExcludeFromCodeCoverage]
public sealed class CompilerFeatureRequiredAttribute : Attribute // TypeDefIndex: 15719
{
	// Fields
	[CompilerGenerated]
	private readonly string <FeatureName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void .ctor(string featureName) { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[ExcludeFromCodeCoverage]
public static class IsExternalInit // TypeDefIndex: 15720
{}

// Namespace: System.Runtime.CompilerServices
[Usage(1774, Inherited = False)]
[ExcludeFromCodeCoverage]
public sealed class SkipLocalsInitAttribute : Attribute // TypeDefIndex: 15721
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: NorthwoodLib
public sealed class ActionDispatcher // TypeDefIndex: 15722
{
	// Fields
	private readonly ConcurrentQueue<Action> _actionQueue; // 0x10

	// Methods

	// RVA: 0x2517FE0 Offset: 0x25171E0 VA: 0x182517FE0
	public void Dispatch(Action action) { }

	// RVA: 0x2518040 Offset: 0x2517240 VA: 0x182518040
	public void Invoke() { }

	// RVA: 0x2518130 Offset: 0x2517330 VA: 0x182518130
	public void .ctor() { }
}

// Namespace: NorthwoodLib
public sealed class NativeMemory // TypeDefIndex: 15723
{
	// Fields
	public readonly void* Data; // 0x10
	public readonly int Length; // 0x18

	// Methods

	// RVA: -1 Offset: -1
	public T* ToPointer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	|-NativeMemory.ToPointer<byte>
	|-NativeMemory.ToPointer<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct OperatingSystem.OSVERSIONINFO.<szCSDVersion>e__FixedBuffer // TypeDefIndex: 15724
{
	// Fields
	public ushort FixedElementField; // 0x0
}

// Namespace: 
private struct OperatingSystem.OSVERSIONINFO // TypeDefIndex: 15725
{
	// Fields
	public uint dwOSVersionInfoSize; // 0x0
	public uint dwMajorVersion; // 0x4
	public uint dwMinorVersion; // 0x8
	public uint dwBuildNumber; // 0xC
	private uint dwPlatformId; // 0x10
	[FixedBuffer(typeof(ushort), 128)]
	public OperatingSystem.OSVERSIONINFO.<szCSDVersion>e__FixedBuffer szCSDVersion; // 0x14
	public ushort wServicePackMajor; // 0x114
	public ushort wServicePackMinor; // 0x116
	private ushort wSuiteMask; // 0x118
	public byte wProductType; // 0x11A
	private byte wReserved; // 0x11B
}

// Namespace: NorthwoodLib
[Extension]
public static class OperatingSystem // TypeDefIndex: 15726
{
	// Fields
	public static readonly bool UsesNativeData; // 0x0
	[Obsolete("Use WineInfo.UsesWine instead")]
	public static readonly bool UsesWine; // 0x1
	public static readonly Version Version; // 0x8
	public static readonly string VersionString; // 0x10
	public static readonly Architecture ProcessArchitecture; // 0x18
	public static readonly Architecture SystemArchitecture; // 0x1C

	// Methods

	// RVA: 0x25181F0 Offset: 0x25173F0 VA: 0x1825181F0
	private static void .cctor() { }

	// RVA: 0x25187D0 Offset: 0x25179D0 VA: 0x1825187D0
	private static bool TryGetUnixOs(out Version version, out string name) { }

	// RVA: 0x25190A0 Offset: 0x25182A0 VA: 0x1825190A0
	private static extern uint GetVersion(OperatingSystem.OSVERSIONINFO* lpVersionInformation) { }

	// RVA: 0x2519120 Offset: 0x2518320 VA: 0x182519120
	private static extern int NtStatusToDosCode(uint status) { }

	// RVA: 0x25191A0 Offset: 0x25183A0 VA: 0x1825191A0
	private static extern int GetVersionFallback(OperatingSystem.OSVERSIONINFO* lpVersionInformation) { }

	// RVA: 0x2519230 Offset: 0x2518430 VA: 0x182519230
	private static extern int GetProductInfo(uint idwOSMajorVersion, uint dwOSMinorVersion, uint dwSpMajorVersion, uint dwSpMinorVersion, uint* pdwReturnedProductType) { }

	// RVA: 0x25192E0 Offset: 0x25184E0 VA: 0x1825192E0
	private static extern int GetArchitecture(void* process, ushort* processArchitecture, ushort* systemArchitecture) { }

	// RVA: 0x2519380 Offset: 0x2518580 VA: 0x182519380
	private static extern void* GetCurrentProcess() { }

	// RVA: 0x25193F0 Offset: 0x25185F0 VA: 0x1825193F0
	private static bool TryGetWindowsVersion(out Version version, out string name) { }

	// RVA: 0x251A650 Offset: 0x2519850 VA: 0x18251A650
	private static void ParseWindowsVersion(OperatingSystem.OSVERSIONINFO osVersionInfo, out Version version, out bool server, out string servicePack, out Version servicePackVersion) { }

	// RVA: 0x251AB10 Offset: 0x2519D10 VA: 0x18251AB10
	internal static Nullable<int> GetWindowsRegistryBuild() { }

	// RVA: 0x251AD70 Offset: 0x2519F70 VA: 0x18251AD70
	internal static bool TryCheckWindowsFileVersion(out Version version, Nullable<int> realBuild) { }

	// RVA: 0x251B190 Offset: 0x251A390 VA: 0x18251B190
	private static bool IsValidWindowsVersion(Version version) { }

	// RVA: 0x251B220 Offset: 0x251A420 VA: 0x18251B220
	private static bool IsValidWindowsVersion(int major, int minor) { }

	[Extension]
	// RVA: 0x251B240 Offset: 0x251A440 VA: 0x18251B240
	private static string PrintVersion(Version version) { }

	// RVA: 0x251B400 Offset: 0x251A600 VA: 0x18251B400
	private static string ProcessWindowsVersion(Version version, bool server, string displayVersion) { }

	// RVA: 0x251BBA0 Offset: 0x251ADA0 VA: 0x18251BBA0
	private static string GetProductInfo(Version osVersion, Version spVersion) { }

	// RVA: 0x251CAD0 Offset: 0x251BCD0 VA: 0x18251CAD0
	private static string GetHklmString(string key, string value) { }

	// RVA: 0x251CC10 Offset: 0x251BE10 VA: 0x18251CC10
	internal static bool TryGetWindowsArchitecture(out Architecture processArchitecture, out Architecture systemArchitecture) { }

	[CompilerGenerated]
	// RVA: 0x251CE80 Offset: 0x251C080 VA: 0x18251CE80
	internal static extern int <GetHklmString>g__RegGetValue|27_0(IntPtr hkey, ushort* key, ushort* value, uint flags, uint* type, void* data, uint* dataLength) { }

	[CompilerGenerated]
	// RVA: 0x251CF30 Offset: 0x251C130 VA: 0x18251CF30
	internal static Architecture <TryGetWindowsArchitecture>g__FromWindowsArch|28_0(ushort arch) { }
}

// Namespace: NorthwoodLib
public static class PlatformSettings // TypeDefIndex: 15727
{
	// Fields
	[CompilerGenerated]
	private static Action<string, LogType> Logged; // 0x0

	// Properties
	public static string Version { get; }

	// Methods

	// RVA: 0x251D000 Offset: 0x251C200 VA: 0x18251D000
	public static string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x251D040 Offset: 0x251C240 VA: 0x18251D040
	public static void add_Logged(Action<string, LogType> value) { }

	[CompilerGenerated]
	// RVA: 0x251D170 Offset: 0x251C370 VA: 0x18251D170
	public static void remove_Logged(Action<string, LogType> value) { }

	// RVA: 0x251D2A0 Offset: 0x251C4A0 VA: 0x18251D2A0
	internal static void Log(string message, LogType type) { }
}

// Namespace: NorthwoodLib
[Extension]
public static class StringUtils // TypeDefIndex: 15728
{
	// Fields
	private static readonly Regex UnicodeRegex; // 0x0
	private static readonly Regex TagRegex; // 0x8

	// Methods

	[Extension]
	// RVA: 0x251D310 Offset: 0x251C510 VA: 0x18251D310
	public static string TruncateToLast(string text, int maxSize, char character) { }

	// RVA: 0x251D380 Offset: 0x251C580 VA: 0x18251D380
	public static string Base64Encode(string plainText) { }

	// RVA: 0x251D4F0 Offset: 0x251C6F0 VA: 0x18251D4F0
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x251D610 Offset: 0x251C810 VA: 0x18251D610
	public static string StripUnicodeCharacters(string input, string replacement = "") { }

	// RVA: 0x251D700 Offset: 0x251C900 VA: 0x18251D700
	public static string StripTags(string input) { }

	// RVA: 0x251D7F0 Offset: 0x251C9F0 VA: 0x18251D7F0
	private static void .cctor() { }
}

// Namespace: NorthwoodLib
public static class WineInfo // TypeDefIndex: 15729
{
	// Fields
	public static readonly bool UsesWine; // 0x0
	public static readonly bool UsesProton; // 0x1
	public static readonly string WineVersion; // 0x8
	public static readonly string WineHost; // 0x10

	// Methods

	// RVA: 0x251D990 Offset: 0x251CB90 VA: 0x18251D990
	private static extern byte* GetWineVersion() { }

	// RVA: 0x251DA00 Offset: 0x251CC00 VA: 0x18251DA00
	private static extern byte* GetWineBuildId() { }

	// RVA: 0x251DA70 Offset: 0x251CC70 VA: 0x18251DA70
	private static extern void GetWineHostVersion(byte** sysname, byte** release) { }

	// RVA: 0x251DB00 Offset: 0x251CD00 VA: 0x18251DB00
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x251EB80 Offset: 0x251DD80 VA: 0x18251EB80
	internal static MemoryMappedFile <.cctor>g__GetKernelBaseMemoryMap|9_0() { }
}

// Namespace: NorthwoodLib.Pools
public sealed class HashSetPool<T> // TypeDefIndex: 15730
{
	// Fields
	public static readonly HashSetPool<T> Shared; // 0x0
	private readonly ConcurrentQueue<HashSet<T>> _pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public HashSet<T> Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2136300 Offset: 0x2135500 VA: 0x182136300
	|-HashSetPool<ByteEnum>.Rent
	|
	|-RVA: 0x21367F0 Offset: 0x21359F0 VA: 0x1821367F0
	|-HashSetPool<Int32Enum>.Rent
	|
	|-RVA: 0x21369A0 Offset: 0x2135BA0 VA: 0x1821369A0
	|-HashSetPool<ItemIdentifier>.Rent
	|
	|-RVA: 0x2136B50 Offset: 0x2135D50 VA: 0x182136B50
	|-HashSetPool<object>.Rent
	|
	|-RVA: 0x2136C60 Offset: 0x2135E60 VA: 0x182136C60
	|-HashSetPool<float>.Rent
	|
	|-RVA: 0x2136E10 Offset: 0x2136010 VA: 0x182136E10
	|-HashSetPool<ushort>.Rent
	|
	|-RVA: 0x2136FC0 Offset: 0x21361C0 VA: 0x182136FC0
	|-HashSetPool<uint>.Rent
	|
	|-RVA: 0x1348670 Offset: 0x1347870 VA: 0x181348670
	|-HashSetPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Return(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21364B0 Offset: 0x21356B0 VA: 0x1821364B0
	|-HashSetPool<ByteEnum>.Return
	|-HashSetPool<Int32Enum>.Return
	|-HashSetPool<ItemIdentifier>.Return
	|-HashSetPool<object>.Return
	|-HashSetPool<float>.Return
	|-HashSetPool<ushort>.Return
	|-HashSetPool<uint>.Return
	|
	|-RVA: 0x2137170 Offset: 0x2136370 VA: 0x182137170
	|-HashSetPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2136550 Offset: 0x2135750 VA: 0x182136550
	|-HashSetPool<ByteEnum>..ctor
	|-HashSetPool<Int32Enum>..ctor
	|-HashSetPool<ItemIdentifier>..ctor
	|-HashSetPool<object>..ctor
	|-HashSetPool<float>..ctor
	|-HashSetPool<ushort>..ctor
	|-HashSetPool<uint>..ctor
	|
	|-RVA: 0x21371F0 Offset: 0x21363F0 VA: 0x1821371F0
	|-HashSetPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2136610 Offset: 0x2135810 VA: 0x182136610
	|-HashSetPool<ByteEnum>..cctor
	|-HashSetPool<Int32Enum>..cctor
	|-HashSetPool<ItemIdentifier>..cctor
	|-HashSetPool<object>..cctor
	|-HashSetPool<float>..cctor
	|-HashSetPool<ushort>..cctor
	|-HashSetPool<uint>..cctor
	|
	|-RVA: 0x21372B0 Offset: 0x21364B0 VA: 0x1821372B0
	|-HashSetPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: NorthwoodLib.Pools
public sealed class ListPool<T> // TypeDefIndex: 15731
{
	// Fields
	public static readonly ListPool<T> Shared; // 0x0
	private readonly ConcurrentQueue<List<T>> _pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public List<T> Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1345AA0 Offset: 0x1344CA0 VA: 0x181345AA0
	|-ListPool<AhpProcessSnapshot>.Rent
	|-ListPool<AuthenticatorPlayerObject>.Rent
	|-ListPool<byte>.Rent
	|-ListPool<ByteEnum>.Rent
	|-ListPool<DisplayInfo>.Rent
	|-ListPool<int>.Rent
	|-ListPool<Int32Enum>.Rent
	|-ListPool<object>.Rent
	|-ListPool<RaycastResult>.Rent
	|-ListPool<Resolution>.Rent
	|-ListPool<ushort>.Rent
	|-ListPool<Vector2>.Rent
	|-ListPool<Vector3>.Rent
	|
	|-RVA: 0x1348670 Offset: 0x1347870 VA: 0x181348670
	|-ListPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1
	public List<T> Rent(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1345C10 Offset: 0x1344E10 VA: 0x181345C10
	|-ListPool<AhpProcessSnapshot>.Rent
	|
	|-RVA: 0x13461F0 Offset: 0x13453F0 VA: 0x1813461F0
	|-ListPool<AuthenticatorPlayerObject>.Rent
	|
	|-RVA: 0x1346570 Offset: 0x1345770 VA: 0x181346570
	|-ListPool<byte>.Rent
	|
	|-RVA: 0x1346870 Offset: 0x1345A70 VA: 0x181346870
	|-ListPool<ByteEnum>.Rent
	|
	|-RVA: 0x1346B70 Offset: 0x1345D70 VA: 0x181346B70
	|-ListPool<DisplayInfo>.Rent
	|
	|-RVA: 0x1346E70 Offset: 0x1346070 VA: 0x181346E70
	|-ListPool<int>.Rent
	|
	|-RVA: 0x1347170 Offset: 0x1346370 VA: 0x181347170
	|-ListPool<Int32Enum>.Rent
	|
	|-RVA: 0x1347470 Offset: 0x1346670 VA: 0x181347470
	|-ListPool<object>.Rent
	|
	|-RVA: 0x1347770 Offset: 0x1346970 VA: 0x181347770
	|-ListPool<RaycastResult>.Rent
	|
	|-RVA: 0x1347A70 Offset: 0x1346C70 VA: 0x181347A70
	|-ListPool<Resolution>.Rent
	|
	|-RVA: 0x1347D70 Offset: 0x1346F70 VA: 0x181347D70
	|-ListPool<ushort>.Rent
	|
	|-RVA: 0x1348070 Offset: 0x1347270 VA: 0x181348070
	|-ListPool<Vector2>.Rent
	|
	|-RVA: 0x1348370 Offset: 0x1347570 VA: 0x181348370
	|-ListPool<Vector3>.Rent
	|
	|-RVA: 0x1348720 Offset: 0x1347920 VA: 0x181348720
	|-ListPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1
	public List<T> Rent(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1345D90 Offset: 0x1344F90 VA: 0x181345D90
	|-ListPool<AhpProcessSnapshot>.Rent
	|
	|-RVA: 0x1346370 Offset: 0x1345570 VA: 0x181346370
	|-ListPool<AuthenticatorPlayerObject>.Rent
	|
	|-RVA: 0x13466F0 Offset: 0x13458F0 VA: 0x1813466F0
	|-ListPool<byte>.Rent
	|
	|-RVA: 0x13469F0 Offset: 0x1345BF0 VA: 0x1813469F0
	|-ListPool<ByteEnum>.Rent
	|
	|-RVA: 0x1346CF0 Offset: 0x1345EF0 VA: 0x181346CF0
	|-ListPool<DisplayInfo>.Rent
	|
	|-RVA: 0x1346FF0 Offset: 0x13461F0 VA: 0x181346FF0
	|-ListPool<int>.Rent
	|
	|-RVA: 0x13472F0 Offset: 0x13464F0 VA: 0x1813472F0
	|-ListPool<Int32Enum>.Rent
	|
	|-RVA: 0x13475F0 Offset: 0x13467F0 VA: 0x1813475F0
	|-ListPool<object>.Rent
	|
	|-RVA: 0x13478F0 Offset: 0x1346AF0 VA: 0x1813478F0
	|-ListPool<RaycastResult>.Rent
	|
	|-RVA: 0x1347BF0 Offset: 0x1346DF0 VA: 0x181347BF0
	|-ListPool<Resolution>.Rent
	|
	|-RVA: 0x1347EF0 Offset: 0x13470F0 VA: 0x181347EF0
	|-ListPool<ushort>.Rent
	|
	|-RVA: 0x13481F0 Offset: 0x13473F0 VA: 0x1813481F0
	|-ListPool<Vector2>.Rent
	|
	|-RVA: 0x13484F0 Offset: 0x13476F0 VA: 0x1813484F0
	|-ListPool<Vector3>.Rent
	|
	|-RVA: 0x1348870 Offset: 0x1347A70 VA: 0x181348870
	|-ListPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Return(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1345F10 Offset: 0x1345110 VA: 0x181345F10
	|-ListPool<AhpProcessSnapshot>.Return
	|-ListPool<byte>.Return
	|-ListPool<ByteEnum>.Return
	|-ListPool<int>.Return
	|-ListPool<Int32Enum>.Return
	|-ListPool<Resolution>.Return
	|-ListPool<ushort>.Return
	|-ListPool<Vector2>.Return
	|-ListPool<Vector3>.Return
	|
	|-RVA: 0x13464F0 Offset: 0x13456F0 VA: 0x1813464F0
	|-ListPool<AuthenticatorPlayerObject>.Return
	|-ListPool<DisplayInfo>.Return
	|-ListPool<object>.Return
	|-ListPool<RaycastResult>.Return
	|
	|-RVA: 0x1348910 Offset: 0x1347B10 VA: 0x181348910
	|-ListPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1345F50 Offset: 0x1345150 VA: 0x181345F50
	|-ListPool<AhpProcessSnapshot>..ctor
	|-ListPool<AuthenticatorPlayerObject>..ctor
	|-ListPool<byte>..ctor
	|-ListPool<ByteEnum>..ctor
	|-ListPool<DisplayInfo>..ctor
	|-ListPool<int>..ctor
	|-ListPool<Int32Enum>..ctor
	|-ListPool<object>..ctor
	|-ListPool<RaycastResult>..ctor
	|-ListPool<Resolution>..ctor
	|-ListPool<ushort>..ctor
	|-ListPool<Vector2>..ctor
	|-ListPool<Vector3>..ctor
	|
	|-RVA: 0x1348990 Offset: 0x1347B90 VA: 0x181348990
	|-ListPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1346010 Offset: 0x1345210 VA: 0x181346010
	|-ListPool<AhpProcessSnapshot>..cctor
	|-ListPool<AuthenticatorPlayerObject>..cctor
	|-ListPool<byte>..cctor
	|-ListPool<ByteEnum>..cctor
	|-ListPool<DisplayInfo>..cctor
	|-ListPool<int>..cctor
	|-ListPool<Int32Enum>..cctor
	|-ListPool<object>..cctor
	|-ListPool<RaycastResult>..cctor
	|-ListPool<Resolution>..cctor
	|-ListPool<ushort>..cctor
	|-ListPool<Vector2>..cctor
	|-ListPool<Vector3>..cctor
	|
	|-RVA: 0x1348A50 Offset: 0x1347C50 VA: 0x181348A50
	|-ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: NorthwoodLib.Pools
public sealed class StringBuilderPool // TypeDefIndex: 15732
{
	// Fields
	public static readonly StringBuilderPool Shared; // 0x0
	private readonly ConcurrentQueue<StringBuilder> _pool; // 0x10

	// Methods

	// RVA: 0x251EC20 Offset: 0x251DE20 VA: 0x18251EC20 Slot: 4
	public StringBuilder Rent() { }

	// RVA: 0x251ED60 Offset: 0x251DF60 VA: 0x18251ED60
	public StringBuilder Rent(int capacity) { }

	// RVA: 0x251EED0 Offset: 0x251E0D0 VA: 0x18251EED0
	public StringBuilder Rent(string text) { }

	// RVA: 0x251F010 Offset: 0x251E210 VA: 0x18251F010 Slot: 5
	public void Return(StringBuilder stringBuilder) { }

	// RVA: 0x251F080 Offset: 0x251E280 VA: 0x18251F080
	public string ToStringReturn(StringBuilder stringBuilder) { }

	// RVA: 0x251F120 Offset: 0x251E320 VA: 0x18251F120
	public void .ctor() { }

	// RVA: 0x251F1E0 Offset: 0x251E3E0 VA: 0x18251F1E0
	private static void .cctor() { }
}

// Namespace: NorthwoodLib.Logging
public enum LogType // TypeDefIndex: 15733
{
	// Fields
	public int value__; // 0x0
	public const LogType Debug = 0;
	public const LogType Info = 1;
	public const LogType Warning = 2;
	public const LogType Error = 3;
}

// Namespace: 
internal struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 15734
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 15735
{
	// Fields
	internal static string[] 0FBD2048AFD8BDEE1CF102A721A601FFFA2F661A88BDEA5D49E055704AD3C157_B11; // 0x0
	internal static readonly long 3274B8912B2ED4E8511DF67D8B73AC1AD70F29B63C6F28C8B3678509FFAE23FE = 9128624228627024; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 332149C784A4C1CBD14E90CA81FB1AED28E8104F99095FDBB26EA58AD0CADEC0 /*Metadata offset 0x7EF610*/; // 0x10
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15736
{}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class Polygon : Triangulatable // TypeDefIndex: 15737
{
	// Fields
	protected List<TriangulationPoint> _points; // 0x10
	protected List<TriangulationPoint> _steinerPoints; // 0x18
	protected List<Polygon> _holes; // 0x20
	protected List<DelaunayTriangle> _triangles; // 0x28

	// Properties
	public TriangulationMode TriangulationMode { get; }
	public IList<DelaunayTriangle> Triangles { get; }

	// Methods

	// RVA: 0x2811700 Offset: 0x2810900 VA: 0x182811700
	public void .ctor(IList<PolygonPoint> points) { }

	// RVA: 0x2811950 Offset: 0x2810B50 VA: 0x182811950
	public void .ctor(IEnumerable<PolygonPoint> points) { }

	// RVA: 0x529680 Offset: 0x528880 VA: 0x180529680 Slot: 8
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x2811A40 Offset: 0x2810C40 VA: 0x182811A40
	public void AddHole(Polygon poly) { }

	// RVA: 0x4CC240 Offset: 0x4CB440 VA: 0x1804CC240 Slot: 5
	public IList<DelaunayTriangle> get_Triangles() { }

	// RVA: 0x2811B80 Offset: 0x2810D80 VA: 0x182811B80 Slot: 6
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x2811BE0 Offset: 0x2810DE0 VA: 0x182811BE0 Slot: 7
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x2811C50 Offset: 0x2810E50 VA: 0x182811C50 Slot: 4
	public void Prepare(TriangulationContext tcx) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint : TriangulationPoint // TypeDefIndex: 15738
{
	// Methods

	// RVA: 0x28121B0 Offset: 0x28113B0 VA: 0x1828121B0
	public void .ctor(double x, double y, int index = -1) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DelaunayTriangle // TypeDefIndex: 15739
{
	// Fields
	public FixedArray3<TriangulationPoint> Points; // 0x10
	public FixedArray3<DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	[CompilerGenerated]
	private bool <IsInterior>k__BackingField; // 0x46

	// Properties
	public bool IsInterior { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x28121C0 Offset: 0x28113C0 VA: 0x1828121C0
	public bool get_IsInterior() { }

	[CompilerGenerated]
	// RVA: 0x28121D0 Offset: 0x28113D0 VA: 0x1828121D0
	public void set_IsInterior(bool value) { }

	// RVA: 0x28121E0 Offset: 0x28113E0 VA: 0x1828121E0
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x2812330 Offset: 0x2811530 VA: 0x182812330
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x28123D0 Offset: 0x28115D0 VA: 0x1828123D0
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x2812400 Offset: 0x2811600 VA: 0x182812400
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2812450 Offset: 0x2811650 VA: 0x182812450
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x2812520 Offset: 0x2811720 VA: 0x182812520
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x2812810 Offset: 0x2811A10 VA: 0x182812810
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2812850 Offset: 0x2811A50 VA: 0x182812850
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x28128E0 Offset: 0x2811AE0 VA: 0x1828128E0
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x2812970 Offset: 0x2811B70 VA: 0x182812970
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x28129F0 Offset: 0x2811BF0 VA: 0x1828129F0
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x2812A70 Offset: 0x2811C70 VA: 0x182812A70
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x2812AF0 Offset: 0x2811CF0 VA: 0x182812AF0
	private void RotateCW() { }

	// RVA: 0x2812C30 Offset: 0x2811E30 VA: 0x182812C30
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x2812DF0 Offset: 0x2811FF0 VA: 0x182812DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2812F40 Offset: 0x2812140 VA: 0x182812F40
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x2812FB0 Offset: 0x28121B0 VA: 0x182812FB0
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x2813030 Offset: 0x2812230 VA: 0x182813030
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x2813120 Offset: 0x2812320 VA: 0x182813120
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x2813160 Offset: 0x2812360 VA: 0x182813160
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x28131A0 Offset: 0x28123A0 VA: 0x1828131A0
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x28131F0 Offset: 0x28123F0 VA: 0x1828131F0
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x2813240 Offset: 0x2812440 VA: 0x182813240
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x2813280 Offset: 0x2812480 VA: 0x182813280
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x28132C0 Offset: 0x28124C0 VA: 0x1828132C0
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x2813310 Offset: 0x2812510 VA: 0x182813310
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFront // TypeDefIndex: 15740
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x2813360 Offset: 0x2812560 VA: 0x182813360
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x2813470 Offset: 0x2812670 VA: 0x182813470 Slot: 3
	public override string ToString() { }

	// RVA: 0x49BDC0 Offset: 0x49AFC0 VA: 0x18049BDC0
	private AdvancingFrontNode FindSearchNode(double x) { }

	// RVA: 0x2813580 Offset: 0x2812780 VA: 0x182813580
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x2813610 Offset: 0x2812810 VA: 0x182813610
	private AdvancingFrontNode LocateNode(double x) { }

	// RVA: 0x28136A0 Offset: 0x28128A0 VA: 0x1828136A0
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFrontNode // TypeDefIndex: 15741
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Properties
	public bool HasNext { get; }
	public bool HasPrev { get; }

	// Methods

	// RVA: 0x28137F0 Offset: 0x28129F0 VA: 0x1828137F0
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x22C37B0 Offset: 0x22C29B0 VA: 0x1822C37B0
	public bool get_HasNext() { }

	// RVA: 0x2510480 Offset: 0x250F680 VA: 0x182510480
	public bool get_HasPrev() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep // TypeDefIndex: 15742
{
	// Methods

	// RVA: 0x2813860 Offset: 0x2812A60 VA: 0x182813860
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x28139E0 Offset: 0x2812BE0 VA: 0x1828139E0
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x2813C30 Offset: 0x2812E30 VA: 0x182813C30
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x2814370 Offset: 0x2813570 VA: 0x182814370
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x2814510 Offset: 0x2813710 VA: 0x182814510
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x2814660 Offset: 0x2813860 VA: 0x182814660
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x28149A0 Offset: 0x2813BA0 VA: 0x1828149A0
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x2814CD0 Offset: 0x2813ED0 VA: 0x182814CD0
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2814E70 Offset: 0x2814070 VA: 0x182814E70
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815110 Offset: 0x2814310 VA: 0x182815110
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815230 Offset: 0x2814430 VA: 0x182815230
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815450 Offset: 0x2814650 VA: 0x182815450
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815670 Offset: 0x2814870 VA: 0x182815670
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x28157D0 Offset: 0x28149D0 VA: 0x1828157D0
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x28159F0 Offset: 0x2814BF0 VA: 0x1828159F0
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815B10 Offset: 0x2814D10 VA: 0x182815B10
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815D30 Offset: 0x2814F30 VA: 0x182815D30
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2815E90 Offset: 0x2815090 VA: 0x182815E90
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x2815FA0 Offset: 0x28151A0 VA: 0x182815FA0
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x2816200 Offset: 0x2815400 VA: 0x182816200
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2816750 Offset: 0x2815950 VA: 0x182816750
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x28168C0 Offset: 0x2815AC0 VA: 0x1828168C0
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x2816A30 Offset: 0x2815C30 VA: 0x182816A30
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2816CC0 Offset: 0x2815EC0 VA: 0x182816CC0
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x2816E90 Offset: 0x2816090 VA: 0x182816E90
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2817330 Offset: 0x2816530 VA: 0x182817330
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2817550 Offset: 0x2816750 VA: 0x182817550
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x28175C0 Offset: 0x28167C0 VA: 0x1828175C0
	private static double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x28176E0 Offset: 0x28168E0 VA: 0x1828176E0
	private static double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x28177B0 Offset: 0x28169B0 VA: 0x1828177B0
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x28179D0 Offset: 0x2816BD0 VA: 0x1828179D0
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x2817C80 Offset: 0x2816E80 VA: 0x182817C80
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepBasin // TypeDefIndex: 15743
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public double width; // 0x28
	public bool leftHighest; // 0x30

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint : TriangulationConstraint // TypeDefIndex: 15744
{
	// Methods

	// RVA: 0x2818280 Offset: 0x2817480 VA: 0x182818280
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepContext : TriangulationContext // TypeDefIndex: 15745
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGenerated]
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGenerated]
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override bool IsDebugEnabled { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51A280 Offset: 0x519480 VA: 0x18051A280
	public TriangulationPoint get_Head() { }

	[CompilerGenerated]
	// RVA: 0x51A290 Offset: 0x519490 VA: 0x18051A290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGenerated]
	// RVA: 0x51A2F0 Offset: 0x5194F0 VA: 0x18051A2F0
	public TriangulationPoint get_Tail() { }

	[CompilerGenerated]
	// RVA: 0x51A300 Offset: 0x519500 VA: 0x18051A300
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x2818590 Offset: 0x2817790 VA: 0x182818590
	public void .ctor() { }

	// RVA: 0x2818870 Offset: 0x2817A70 VA: 0x182818870 Slot: 7
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x2818880 Offset: 0x2817A80 VA: 0x182818880
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x28188E0 Offset: 0x2817AE0 VA: 0x1828188E0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x28188F0 Offset: 0x2817AF0 VA: 0x1828188F0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2818A00 Offset: 0x2817C00 VA: 0x182818A00 Slot: 6
	public override void Clear() { }

	// RVA: 0x2818AE0 Offset: 0x2817CE0 VA: 0x182818AE0
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2818AE0 Offset: 0x2817CE0 VA: 0x182818AE0
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x2818B00 Offset: 0x2817D00 VA: 0x182818B00
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x2818BA0 Offset: 0x2817DA0 VA: 0x182818BA0
	public void CreateAdvancingFront() { }

	// RVA: 0x28191E0 Offset: 0x28183E0 VA: 0x1828191E0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x28192D0 Offset: 0x28184D0 VA: 0x1828192D0 Slot: 4
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x2819830 Offset: 0x2818A30 VA: 0x182819830
	public void FinalizeTriangulation() { }

	// RVA: 0x28198D0 Offset: 0x2818AD0 VA: 0x1828198D0 Slot: 5
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepDebugContext : TriangulationDebugContext // TypeDefIndex: 15746
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Properties
	public DelaunayTriangle PrimaryTriangle { set; }
	public DelaunayTriangle SecondaryTriangle { set; }
	public TriangulationPoint ActivePoint { set; }
	public AdvancingFrontNode ActiveNode { set; }
	public DTSweepConstraint ActiveConstraint { set; }

	// Methods

	// RVA: 0x2819940 Offset: 0x2818B40 VA: 0x182819940
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x28199E0 Offset: 0x2818BE0 VA: 0x1828199E0
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x2819A80 Offset: 0x2818C80 VA: 0x182819A80
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x2819B20 Offset: 0x2818D20 VA: 0x182819B20
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x2819BC0 Offset: 0x2818DC0 VA: 0x182819BC0
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x2819C60 Offset: 0x2818E60 VA: 0x182819C60 Slot: 4
	public override void Clear() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent // TypeDefIndex: 15747
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator : IComparer<TriangulationPoint> // TypeDefIndex: 15748
{
	// Methods

	// RVA: 0x2819E20 Offset: 0x2819020 VA: 0x182819E20 Slot: 4
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointOnEdgeException : NotImplementedException // TypeDefIndex: 15749
{
	// Fields
	public readonly TriangulationPoint A; // 0x90
	public readonly TriangulationPoint B; // 0x98
	public readonly TriangulationPoint C; // 0xA0

	// Methods

	// RVA: 0x2819E90 Offset: 0x2819090 VA: 0x182819E90
	public void .ctor(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal interface Triangulatable // TypeDefIndex: 15750
{
	// Properties
	public abstract IList<DelaunayTriangle> Triangles { get; }
	public abstract TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Prepare(TriangulationContext tcx);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<DelaunayTriangle> get_Triangles();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddTriangle(DelaunayTriangle t);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddTriangles(IEnumerable<DelaunayTriangle> list);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TriangulationMode get_TriangulationMode();
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum Orientation // TypeDefIndex: 15751
{
	// Fields
	public int value__; // 0x0
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointSet : Triangulatable // TypeDefIndex: 15752
{
	// Fields
	[CompilerGenerated]
	private IList<TriangulationPoint> <Points>k__BackingField; // 0x10
	[CompilerGenerated]
	private IList<DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Properties
	public IList<TriangulationPoint> Points { get; set; }
	public IList<DelaunayTriangle> Triangles { get; set; }
	public virtual TriangulationMode TriangulationMode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0 Slot: 9
	public IList<TriangulationPoint> get_Points() { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	private void set_Points(IList<TriangulationPoint> value) { }

	[CompilerGenerated]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70 Slot: 5
	public IList<DelaunayTriangle> get_Triangles() { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	// RVA: 0x2819FE0 Offset: 0x28191E0 VA: 0x182819FE0
	public void .ctor(List<TriangulationPoint> points) { }

	// RVA: 0x462F00 Offset: 0x462100 VA: 0x180462F00 Slot: 10
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x281A0B0 Offset: 0x28192B0 VA: 0x18281A0B0 Slot: 6
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x281A110 Offset: 0x2819310 VA: 0x18281A110 Slot: 7
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x281A390 Offset: 0x2819590 VA: 0x18281A390 Slot: 11
	public virtual void Prepare(TriangulationContext tcx) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint // TypeDefIndex: 15753
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationContext // TypeDefIndex: 15754
{
	// Fields
	[CompilerGenerated]
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly List<DelaunayTriangle> Triangles; // 0x18
	public readonly List<TriangulationPoint> Points; // 0x20
	[CompilerGenerated]
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	[CompilerGenerated]
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <StepCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Properties
	public TriangulationDebugContext DebugContext { get; }
	public TriangulationMode TriangulationMode { get; set; }
	public Triangulatable Triangulatable { get; set; }
	public int StepCount { get; set; }
	public virtual bool IsDebugEnabled { get; }
	public DTSweepDebugContext DTDebugContext { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public TriangulationDebugContext get_DebugContext() { }

	[CompilerGenerated]
	// RVA: 0x56C2D0 Offset: 0x56B4D0 VA: 0x18056C2D0
	public TriangulationMode get_TriangulationMode() { }

	[CompilerGenerated]
	// RVA: 0x722920 Offset: 0x721B20 VA: 0x180722920
	protected void set_TriangulationMode(TriangulationMode value) { }

	[CompilerGenerated]
	// RVA: 0x512620 Offset: 0x511820 VA: 0x180512620
	public Triangulatable get_Triangulatable() { }

	[CompilerGenerated]
	// RVA: 0x4C5350 Offset: 0x4C4550 VA: 0x1804C5350
	private void set_Triangulatable(Triangulatable value) { }

	[CompilerGenerated]
	// RVA: 0x7FFD20 Offset: 0x7FEF20 VA: 0x1807FFD20
	public int get_StepCount() { }

	[CompilerGenerated]
	// RVA: 0x7FFD30 Offset: 0x7FEF30 VA: 0x1807FFD30
	private void set_StepCount(int value) { }

	// RVA: 0x270D470 Offset: 0x270C670 VA: 0x18270D470
	public void Done() { }

	// RVA: 0x281A510 Offset: 0x2819710 VA: 0x18281A510 Slot: 4
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void Update(string message) { }

	// RVA: 0x281A630 Offset: 0x2819830 VA: 0x18281A630 Slot: 6
	public virtual void Clear() { }

	[CompilerGenerated]
	// RVA: 0x2818870 Offset: 0x2817A70 VA: 0x182818870 Slot: 7
	public virtual bool get_IsDebugEnabled() { }

	// RVA: 0x281A6C0 Offset: 0x28198C0 VA: 0x18281A6C0
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x281A740 Offset: 0x2819940 VA: 0x18281A740
	protected void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationDebugContext // TypeDefIndex: 15755
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationMode // TypeDefIndex: 15756
{
	// Fields
	public int value__; // 0x0
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationPoint // TypeDefIndex: 15757
{
	// Fields
	[CompilerGenerated]
	private List<DTSweepConstraint> <Edges>k__BackingField; // 0x10
	public double X; // 0x18
	public double Y; // 0x20
	public int Index; // 0x28

	// Properties
	public List<DTSweepConstraint> Edges { get; set; }
	public bool HasEdges { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public List<DTSweepConstraint> get_Edges() { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	private void set_Edges(List<DTSweepConstraint> value) { }

	// RVA: 0x28121B0 Offset: 0x28113B0 VA: 0x1828121B0
	public void .ctor(double x, double y, int index = -1) { }

	// RVA: 0x281A8A0 Offset: 0x2819AA0 VA: 0x18281A8A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x281A9B0 Offset: 0x2819BB0 VA: 0x18281A9B0
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x22C37B0 Offset: 0x22C29B0 VA: 0x1822C37B0
	public bool get_HasEdges() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil // TypeDefIndex: 15758
{
	// Fields
	public static double EPSILON; // 0x0

	// Methods

	// RVA: 0x281AAF0 Offset: 0x2819CF0 VA: 0x18281AAF0
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x281AC30 Offset: 0x2819E30 VA: 0x18281AC30
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x281ACF0 Offset: 0x2819EF0 VA: 0x18281ACF0
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x281AE10 Offset: 0x281A010 VA: 0x18281AE10
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FixedArray3.<Enumerate>d__10<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 15759
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public FixedArray3<T> <>4__this; // 0x0
	public FixedArray3<T> <>3__<>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737DA0 Offset: 0x736FA0 VA: 0x180737DA0
	|-FixedArray3.<Enumerate>d__10<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-FixedArray3.<Enumerate>d__10<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956D90 Offset: 0x1955F90 VA: 0x181956D90
	|-FixedArray3.<Enumerate>d__10<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	|-FixedArray3.<Enumerate>d__10<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569480 Offset: 0x1568680 VA: 0x181569480
	|-FixedArray3.<Enumerate>d__10<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	|-FixedArray3.<Enumerate>d__10<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956EA0 Offset: 0x19560A0 VA: 0x181956EA0
	|-FixedArray3.<Enumerate>d__10<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956F90 Offset: 0x1956190 VA: 0x181956F90
	|-FixedArray3.<Enumerate>d__10<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
[DefaultMember("Item")]
internal struct FixedArray3<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 15760
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F800E0 Offset: 0x1F7F2E0 VA: 0x181F800E0
	|-FixedArray3<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F80150 Offset: 0x1F7F350 VA: 0x181F80150
	|-FixedArray3<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F802D0 Offset: 0x1F7F4D0 VA: 0x181F802D0
	|-FixedArray3<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F80350 Offset: 0x1F7F550 VA: 0x181F80350
	|-FixedArray3<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F803D0 Offset: 0x1F7F5D0 VA: 0x181F803D0
	|-FixedArray3<object>.Clear
	*/

	[IteratorStateMachine(typeof(FixedArray3.<Enumerate>d__10<T>))]
	// RVA: -1 Offset: -1
	private IEnumerable<T> Enumerate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F804D0 Offset: 0x1F7F6D0 VA: 0x181F804D0
	|-FixedArray3<object>.Enumerate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F805C0 Offset: 0x1F7F7C0 VA: 0x181F805C0
	|-FixedArray3<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F80650 Offset: 0x1F7F850 VA: 0x181F80650
	|-FixedArray3<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FixedBitArray3.<Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable // TypeDefIndex: 15761
{
	// Fields
	private int <>1__state; // 0x10
	private bool <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public FixedBitArray3 <>4__this; // 0x1C
	public FixedBitArray3 <>3__<>4__this; // 0x1F
	private int <i>5__2; // 0x24

	// Properties
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x895290 Offset: 0x894490 VA: 0x180895290
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x281B020 Offset: 0x281A220 VA: 0x18281B020 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x56C500 Offset: 0x56B700 VA: 0x18056C500 Slot: 6
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x281B0E0 Offset: 0x281A2E0 VA: 0x18281B0E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x281B120 Offset: 0x281A320 VA: 0x18281B120 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x281B150 Offset: 0x281A350 VA: 0x18281B150 Slot: 4
	private IEnumerator<bool> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x281B150 Offset: 0x281A350 VA: 0x18281B150 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
[DefaultMember("Item")]
internal struct FixedBitArray3 : IEnumerable<bool>, IEnumerable // TypeDefIndex: 15762
{
	// Fields
	public bool _0; // 0x0
	public bool _1; // 0x1
	public bool _2; // 0x2

	// Properties
	public bool Item { get; set; }

	// Methods

	// RVA: 0x281AE60 Offset: 0x281A060 VA: 0x18281AE60
	public bool get_Item(int index) { }

	// RVA: 0x281AED0 Offset: 0x281A0D0 VA: 0x18281AED0
	public void set_Item(int index, bool value) { }

	// RVA: 0x281AF40 Offset: 0x281A140 VA: 0x18281AF40
	public void Clear() { }

	[IteratorStateMachine(typeof(FixedBitArray3.<Enumerate>d__10))]
	// RVA: 0x281AF50 Offset: 0x281A150 VA: 0x18281AF50
	private IEnumerable<bool> Enumerate() { }

	// RVA: 0x281AFC0 Offset: 0x281A1C0 VA: 0x18281AFC0 Slot: 4
	public IEnumerator<bool> GetEnumerator() { }

	// RVA: 0x281AFC0 Offset: 0x281A1C0 VA: 0x18281AFC0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15763
{}

// Namespace: UnityEngine.VFX
public enum VFXSpace // TypeDefIndex: 15764
{
	// Fields
	public int value__; // 0x0
	public const VFXSpace None = -1;
	public const VFXSpace Local = 0;
	public const VFXSpace World = 1;
}

// Namespace: UnityEngine.VFX
[Flags]
public enum VFXCameraBufferTypes // TypeDefIndex: 15765
{
	// Fields
	public int value__; // 0x0
	public const VFXCameraBufferTypes None = 0;
	public const VFXCameraBufferTypes Depth = 1;
	public const VFXCameraBufferTypes Color = 2;
	public const VFXCameraBufferTypes Normal = 4;
}

// Namespace: 
internal static class VFXEventAttribute.BindingsMarshaller // TypeDefIndex: 15766
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(VFXEventAttribute eventAttibute) { }

	// RVA: 0x3118D80 Offset: 0x3117F80 VA: 0x183118D80
	public static VFXEventAttribute ConvertToManaged(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
[RequiredByNativeCode]
public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 15767
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20

	// Properties
	internal VisualEffectAsset vfxAsset { get; }

	// Methods

	// RVA: 0x31183E0 Offset: 0x31175E0 VA: 0x1831183E0
	private void .ctor(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	// RVA: 0xAC9D10 Offset: 0xAC8F10 VA: 0x180AC9D10
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x3118440 Offset: 0x3117640 VA: 0x183118440
	private void .ctor() { }

	// RVA: 0x31184A0 Offset: 0x31176A0 VA: 0x1831184A0
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	// RVA: 0x3118540 Offset: 0x3117740 VA: 0x183118540
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

	// RVA: 0x31185B0 Offset: 0x31177B0 VA: 0x1831185B0
	internal static IntPtr Internal_Create() { }

	// RVA: 0x3118600 Offset: 0x3117800 VA: 0x183118600
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	// RVA: 0x31187A0 Offset: 0x31179A0 VA: 0x1831187A0
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	// RVA: 0x2F3A7B0 Offset: 0x2F399B0 VA: 0x182F3A7B0
	internal VisualEffectAsset get_vfxAsset() { }

	// RVA: 0x3118870 Offset: 0x3117A70 VA: 0x183118870
	private void Release() { }

	// RVA: 0x3118930 Offset: 0x3117B30 VA: 0x183118930 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3118970 Offset: 0x3117B70 VA: 0x183118970 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x31189D0 Offset: 0x3117BD0 VA: 0x1831189D0
	internal static void Internal_Destroy(IntPtr ptr) { }

	[NativeName("SetValueFromScript<UInt32>")]
	// RVA: 0x3118A20 Offset: 0x3117C20 VA: 0x183118A20
	public void SetUint(int nameID, uint i) { }

	[NativeName("SetValueFromScript<float>")]
	// RVA: 0x3118AB0 Offset: 0x3117CB0 VA: 0x183118AB0
	public void SetFloat(int nameID, float f) { }

	[NativeName("SetValueFromScript<Vector3f>")]
	// RVA: 0x3118B40 Offset: 0x3117D40 VA: 0x183118B40
	public void SetVector3(int nameID, Vector3 v) { }

	// RVA: 0x3118BD0 Offset: 0x3117DD0 VA: 0x183118BD0
	private static void Internal_InitFromAsset_Injected(IntPtr _unity_self, IntPtr vfxAsset) { }

	// RVA: 0x3118C30 Offset: 0x3117E30 VA: 0x183118C30
	private static void SetUint_Injected(IntPtr _unity_self, int nameID, uint i) { }

	// RVA: 0x3118CA0 Offset: 0x3117EA0 VA: 0x183118CA0
	private static void SetFloat_Injected(IntPtr _unity_self, int nameID, float f) { }

	// RVA: 0x3118D10 Offset: 0x3117F10 VA: 0x183118D10
	private static void SetVector3_Injected(IntPtr _unity_self, int nameID, in Vector3 v) { }
}

// Namespace: 
internal static class VFXExpressionValues.BindingsMarshaller // TypeDefIndex: 15768
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(VFXExpressionValues vFXExpressionValues) { }
}

// Namespace: UnityEngine.VFX
[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
[RequiredByNativeCode]
public class VFXExpressionValues // TypeDefIndex: 15769
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3118DC0 Offset: 0x3117FC0 VA: 0x183118DC0
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

	[NativeThrows]
	[NativeName("GetValueFromScript<bool>")]
	// RVA: 0x3118E10 Offset: 0x3118010 VA: 0x183118E10
	public bool GetBool(int nameID) { }

	[NativeThrows]
	[NativeName("GetValueFromScript<int>")]
	// RVA: 0x3118E90 Offset: 0x3118090 VA: 0x183118E90
	public int GetInt(int nameID) { }

	[NativeThrows]
	[NativeName("GetValueFromScript<UInt32>")]
	// RVA: 0x3118F10 Offset: 0x3118110 VA: 0x183118F10
	public uint GetUInt(int nameID) { }

	[NativeName("GetValueFromScript<float>")]
	[NativeThrows]
	// RVA: 0x3118F90 Offset: 0x3118190 VA: 0x183118F90
	public float GetFloat(int nameID) { }

	[NativeThrows]
	[NativeName("GetValueFromScript<Vector3f>")]
	// RVA: 0x3119010 Offset: 0x3118210 VA: 0x183119010
	public Vector3 GetVector3(int nameID) { }

	// RVA: 0x31190B0 Offset: 0x31182B0 VA: 0x1831190B0
	private static bool GetBool_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x3119110 Offset: 0x3118310 VA: 0x183119110
	private static int GetInt_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x3119170 Offset: 0x3118370 VA: 0x183119170
	private static uint GetUInt_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x31191D0 Offset: 0x31183D0 VA: 0x1831191D0
	private static float GetFloat_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x3119230 Offset: 0x3118430 VA: 0x183119230
	private static void GetVector3_Injected(IntPtr _unity_self, int nameID, out Vector3 ret) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXCameraXRSettings // TypeDefIndex: 15770
{
	// Fields
	public uint viewTotal; // 0x0
	public uint viewCount; // 0x4
	public uint viewOffset; // 0x8
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXBatchedEffectInfo // TypeDefIndex: 15771
{
	// Fields
	public VisualEffectAsset vfxAsset; // 0x0
	public uint activeBatchCount; // 0x8
	public uint inactiveBatchCount; // 0xC
	public uint activeInstanceCount; // 0x10
	public uint unbatchedInstanceCount; // 0x14
	public uint totalInstanceCapacity; // 0x18
	public uint maxInstancePerBatchCapacity; // 0x1C
	public ulong totalGPUSizeInBytes; // 0x20
	public ulong totalCPUSizeInBytes; // 0x28
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
internal struct VFXBatchInfo // TypeDefIndex: 15772
{
	// Fields
	public uint capacity; // 0x0
	public uint activeInstanceCount; // 0x4
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[StaticAccessor("GetVFXManager()", 0)]
[RequiredByNativeCode]
public static class VFXManager // TypeDefIndex: 15773
{
	// Fields
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x0

	// Properties
	internal static ScriptableObject runtimeResources { get; }

	// Methods

	// RVA: 0x31192A0 Offset: 0x31184A0 VA: 0x1831192A0
	internal static ScriptableObject get_runtimeResources() { }

	// RVA: 0x3119340 Offset: 0x3118540 VA: 0x183119340
	public static void PrepareCamera(Camera cam, VFXCameraXRSettings camXRSettings) { }

	// RVA: 0x3119440 Offset: 0x3118640 VA: 0x183119440
	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

	// RVA: 0x31195B0 Offset: 0x31187B0 VA: 0x1831195B0
	private static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults) { }

	// RVA: 0x31196E0 Offset: 0x31188E0 VA: 0x1831196E0
	public static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam) { }

	// RVA: 0x31197D0 Offset: 0x31189D0 VA: 0x1831197D0
	public static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height) { }

	// RVA: 0x3119930 Offset: 0x3118B30 VA: 0x183119930
	public static void SetRayTracingEnabled(bool enabled) { }

	// RVA: 0x3119980 Offset: 0x3118B80 VA: 0x183119980
	public static void RequestRtasAabbConstruction() { }

	// RVA: 0x31199D0 Offset: 0x3118BD0 VA: 0x1831199D0
	private static void .cctor() { }

	// RVA: 0x3119A30 Offset: 0x3118C30 VA: 0x183119A30
	private static IntPtr get_runtimeResources_Injected() { }

	// RVA: 0x3119A80 Offset: 0x3118C80 VA: 0x183119A80
	private static void PrepareCamera_Injected(IntPtr cam, in VFXCameraXRSettings camXRSettings) { }

	// RVA: 0x3119AE0 Offset: 0x3118CE0 VA: 0x183119AE0
	private static void Internal_ProcessCameraCommand_Injected(IntPtr cam, IntPtr cmd, in VFXCameraXRSettings camXRSettings, IntPtr cullResults) { }

	// RVA: 0x3119B60 Offset: 0x3118D60 VA: 0x183119B60
	private static VFXCameraBufferTypes IsCameraBufferNeeded_Injected(IntPtr cam) { }

	// RVA: 0x3119BB0 Offset: 0x3118DB0 VA: 0x183119BB0
	private static void SetCameraBuffer_Injected(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 15774
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x496280 Offset: 0x495480 VA: 0x180496280
	protected void .ctor() { }
}

// Namespace: UnityEngine.VFX
public enum VFXSpawnerLoopState // TypeDefIndex: 15775
{
	// Fields
	public int value__; // 0x0
	public const VFXSpawnerLoopState Finished = 0;
	public const VFXSpawnerLoopState DelayingBeforeLoop = 1;
	public const VFXSpawnerLoopState Looping = 2;
	public const VFXSpawnerLoopState DelayingAfterLoop = 3;
}

// Namespace: 
internal static class VFXSpawnerState.BindingsMarshaller // TypeDefIndex: 15776
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(VFXSpawnerState vfxSpawnerState) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 15777
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VFXEventAttribute m_WrapEventAttribute; // 0x20

	// Properties
	public bool playing { get; set; }
	public VFXSpawnerLoopState loopState { get; set; }
	public float spawnCount { get; set; }
	public float deltaTime { get; }
	public float totalTime { get; set; }
	public VFXEventAttribute vfxEventAttribute { get; }

	// Methods

	// RVA: 0x2EBF2A0 Offset: 0x2EBE4A0 VA: 0x182EBF2A0
	internal void .ctor(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	// RVA: 0x3119C30 Offset: 0x3118E30 VA: 0x183119C30
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	// RVA: 0x3119DC0 Offset: 0x3118FC0 VA: 0x183119DC0
	private void PrepareWrapper() { }

	[RequiredByNativeCode]
	// RVA: 0x3119F60 Offset: 0x3119160 VA: 0x183119F60
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

	// RVA: 0x311A080 Offset: 0x3119280 VA: 0x18311A080
	private void Release() { }

	// RVA: 0x311A140 Offset: 0x3119340 VA: 0x18311A140 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x311A180 Offset: 0x3119380 VA: 0x18311A180 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x311A1E0 Offset: 0x31193E0 VA: 0x18311A1E0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x311A230 Offset: 0x3119430 VA: 0x18311A230
	public bool get_playing() { }

	// RVA: 0x311A2B0 Offset: 0x31194B0 VA: 0x18311A2B0
	public void set_playing(bool value) { }

	// RVA: 0x311A330 Offset: 0x3119530 VA: 0x18311A330
	public VFXSpawnerLoopState get_loopState() { }

	// RVA: 0x311A3A0 Offset: 0x31195A0 VA: 0x18311A3A0
	public void set_loopState(VFXSpawnerLoopState value) { }

	// RVA: 0x311A420 Offset: 0x3119620 VA: 0x18311A420
	public float get_spawnCount() { }

	// RVA: 0x311A490 Offset: 0x3119690 VA: 0x18311A490
	public void set_spawnCount(float value) { }

	// RVA: 0x311A510 Offset: 0x3119710 VA: 0x18311A510
	public float get_deltaTime() { }

	// RVA: 0x311A580 Offset: 0x3119780 VA: 0x18311A580
	public float get_totalTime() { }

	// RVA: 0x311A5F0 Offset: 0x31197F0 VA: 0x18311A5F0
	public void set_totalTime(float value) { }

	// RVA: 0x311A670 Offset: 0x3119870 VA: 0x18311A670
	internal VFXEventAttribute Internal_GetVFXEventAttribute() { }

	// RVA: 0x311A730 Offset: 0x3119930 VA: 0x18311A730
	public VFXEventAttribute get_vfxEventAttribute() { }

	// RVA: 0x311A7F0 Offset: 0x31199F0 VA: 0x18311A7F0
	private static VFXSpawnerLoopState get_loopState_Injected(IntPtr _unity_self) { }

	// RVA: 0x311A840 Offset: 0x3119A40 VA: 0x18311A840
	private static void set_loopState_Injected(IntPtr _unity_self, VFXSpawnerLoopState value) { }

	// RVA: 0x311A8A0 Offset: 0x3119AA0 VA: 0x18311A8A0
	private static float get_spawnCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x311A8F0 Offset: 0x3119AF0 VA: 0x18311A8F0
	private static void set_spawnCount_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x311A950 Offset: 0x3119B50 VA: 0x18311A950
	private static float get_deltaTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x311A9A0 Offset: 0x3119BA0 VA: 0x18311A9A0
	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x311A9F0 Offset: 0x3119BF0 VA: 0x18311A9F0
	private static void set_totalTime_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x311AA50 Offset: 0x3119C50 VA: 0x18311AA50
	private static IntPtr Internal_GetVFXEventAttribute_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
public abstract class VisualEffectObject : Object // TypeDefIndex: 15778
{
	// Methods

	// RVA: 0x311AAA0 Offset: 0x3119CA0 VA: 0x18311AAA0
	protected void .ctor() { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[UsedByNativeCode]
public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 15779
{
	// Fields
	public const string PlayEventName = "OnPlay";
	public const string StopEventName = "OnStop";
	public static readonly int PlayEventID; // 0x0
	public static readonly int StopEventID; // 0x4

	// Methods

	[FreeFunction(Name = "VisualEffectAssetBindings::GetExposedSpace", HasExplicitThis = True)]
	// RVA: 0x311AAF0 Offset: 0x3119CF0 VA: 0x18311AAF0
	public VFXSpace GetExposedSpace(int nameID) { }

	// RVA: 0x311AAA0 Offset: 0x3119CA0 VA: 0x18311AAA0
	public void .ctor() { }

	// RVA: 0x311ABC0 Offset: 0x3119DC0 VA: 0x18311ABC0
	private static void .cctor() { }

	// RVA: 0x311AC50 Offset: 0x3119E50 VA: 0x18311AC50
	private static VFXSpace GetExposedSpace_Injected(IntPtr _unity_self, int nameID) { }
}

// Namespace: UnityEngine.VFX
public struct VFXOutputEventArgs // TypeDefIndex: 15780
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <nameId>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VFXEventAttribute <eventAttribute>k__BackingField; // 0x8

	// Properties
	public int nameId { get; }
	public VFXEventAttribute eventAttribute { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public int get_nameId() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5C0480 Offset: 0x5BF680 VA: 0x1805C0480
	public VFXEventAttribute get_eventAttribute() { }

	// RVA: 0x754CF0 Offset: 0x753EF0 VA: 0x180754CF0
	public void .ctor(int nameId, VFXEventAttribute eventAttribute) { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
public class VisualEffect : Behaviour // TypeDefIndex: 15781
{
	// Fields
	private VFXEventAttribute m_cachedEventAttribute; // 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; // 0x20

	// Properties
	public VisualEffectAsset visualEffectAsset { get; }
	public int aliveParticleCount { get; }

	// Methods

	// RVA: 0x311ACB0 Offset: 0x3119EB0 VA: 0x18311ACB0
	public VisualEffectAsset get_visualEffectAsset() { }

	// RVA: 0x311AD70 Offset: 0x3119F70 VA: 0x18311AD70
	public VFXEventAttribute CreateVFXEventAttribute() { }

	// RVA: 0x311AFE0 Offset: 0x311A1E0 VA: 0x18311AFE0
	private void CheckValidVFXEventAttribute(VFXEventAttribute eventAttribute) { }

	[FreeFunction(Name = "VisualEffectBindings::SendEventFromScript", HasExplicitThis = True)]
	// RVA: 0x311B160 Offset: 0x311A360 VA: 0x18311B160
	private void SendEventFromScript(int eventNameID, VFXEventAttribute eventAttribute) { }

	// RVA: 0x311B230 Offset: 0x311A430 VA: 0x18311B230
	public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute) { }

	// RVA: 0x311B450 Offset: 0x311A650 VA: 0x18311B450
	public void SendEvent(string eventName, VFXEventAttribute eventAttribute) { }

	// RVA: 0x311B490 Offset: 0x311A690 VA: 0x18311B490
	public void SendEvent(int eventNameID) { }

	// RVA: 0x311B540 Offset: 0x311A740 VA: 0x18311B540
	public void Play() { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<bool>", HasExplicitThis = True)]
	// RVA: 0x311B630 Offset: 0x311A830 VA: 0x18311B630
	public bool HasBool(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<int>", HasExplicitThis = True)]
	// RVA: 0x311B6E0 Offset: 0x311A8E0 VA: 0x18311B6E0
	public bool HasInt(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<UInt32>", HasExplicitThis = True)]
	// RVA: 0x311B790 Offset: 0x311A990 VA: 0x18311B790
	public bool HasUInt(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<float>", HasExplicitThis = True)]
	// RVA: 0x311B840 Offset: 0x311AA40 VA: 0x18311B840
	public bool HasFloat(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector2f>", HasExplicitThis = True)]
	// RVA: 0x311B8F0 Offset: 0x311AAF0 VA: 0x18311B8F0
	public bool HasVector2(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector3f>", HasExplicitThis = True)]
	// RVA: 0x311B9A0 Offset: 0x311ABA0 VA: 0x18311B9A0
	public bool HasVector3(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector4f>", HasExplicitThis = True)]
	// RVA: 0x311BA50 Offset: 0x311AC50 VA: 0x18311BA50
	public bool HasVector4(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Texture*>", HasExplicitThis = True)]
	// RVA: 0x311BB00 Offset: 0x311AD00 VA: 0x18311BB00
	public bool HasTexture(int nameID) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<bool>", HasExplicitThis = True)]
	// RVA: 0x311BBB0 Offset: 0x311ADB0 VA: 0x18311BBB0
	public void SetBool(int nameID, bool b) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<int>", HasExplicitThis = True)]
	// RVA: 0x311BC70 Offset: 0x311AE70 VA: 0x18311BC70
	public void SetInt(int nameID, int i) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<UInt32>", HasExplicitThis = True)]
	// RVA: 0x311BD30 Offset: 0x311AF30 VA: 0x18311BD30
	public void SetUInt(int nameID, uint i) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<float>", HasExplicitThis = True)]
	// RVA: 0x311BDF0 Offset: 0x311AFF0 VA: 0x18311BDF0
	public void SetFloat(int nameID, float f) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector2f>", HasExplicitThis = True)]
	// RVA: 0x311BEB0 Offset: 0x311B0B0 VA: 0x18311BEB0
	public void SetVector2(int nameID, Vector2 v) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector3f>", HasExplicitThis = True)]
	// RVA: 0x311BF60 Offset: 0x311B160 VA: 0x18311BF60
	public void SetVector3(int nameID, Vector3 v) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector4f>", HasExplicitThis = True)]
	// RVA: 0x311C020 Offset: 0x311B220 VA: 0x18311C020
	public void SetVector4(int nameID, Vector4 v) { }

	[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Texture*>", HasExplicitThis = True)]
	// RVA: 0x311C0E0 Offset: 0x311B2E0 VA: 0x18311C0E0
	public void SetTexture(int nameID, Texture t) { }

	[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<float>", HasExplicitThis = True)]
	// RVA: 0x311C200 Offset: 0x311B400 VA: 0x18311C200
	public float GetFloat(int nameID) { }

	// RVA: 0x311C2B0 Offset: 0x311B4B0 VA: 0x18311C2B0
	public bool HasUInt(string name) { }

	// RVA: 0x311C2E0 Offset: 0x311B4E0 VA: 0x18311C2E0
	public bool HasFloat(string name) { }

	// RVA: 0x311C310 Offset: 0x311B510 VA: 0x18311C310
	public bool HasVector4(string name) { }

	// RVA: 0x311C3D0 Offset: 0x311B5D0 VA: 0x18311C3D0
	public bool HasTexture(string name) { }

	// RVA: 0x311C400 Offset: 0x311B600 VA: 0x18311C400
	public void SetUInt(string name, uint i) { }

	// RVA: 0x311C440 Offset: 0x311B640 VA: 0x18311C440
	public void SetFloat(string name, float f) { }

	// RVA: 0x311C480 Offset: 0x311B680 VA: 0x18311C480
	public void SetVector4(string name, Vector4 v) { }

	// RVA: 0x311C550 Offset: 0x311B750 VA: 0x18311C550
	public void SetTexture(string name, Texture t) { }

	// RVA: 0x311C590 Offset: 0x311B790 VA: 0x18311C590
	public void SetBool(string name, bool b) { }

	// RVA: 0x311C5D0 Offset: 0x311B7D0 VA: 0x18311C5D0
	public int get_aliveParticleCount() { }

	[RequiredByNativeCode]
	// RVA: 0x311C670 Offset: 0x311B870 VA: 0x18311C670
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCode]
	// RVA: 0x311C700 Offset: 0x311B900 VA: 0x18311C700
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x311C7B0 Offset: 0x311B9B0 VA: 0x18311C7B0
	private static IntPtr get_visualEffectAsset_Injected(IntPtr _unity_self) { }

	// RVA: 0x311C800 Offset: 0x311BA00 VA: 0x18311C800
	private static void SendEventFromScript_Injected(IntPtr _unity_self, int eventNameID, IntPtr eventAttribute) { }

	// RVA: 0x311C870 Offset: 0x311BA70 VA: 0x18311C870
	private static bool HasBool_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311C8D0 Offset: 0x311BAD0 VA: 0x18311C8D0
	private static bool HasInt_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311C930 Offset: 0x311BB30 VA: 0x18311C930
	private static bool HasUInt_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311C990 Offset: 0x311BB90 VA: 0x18311C990
	private static bool HasFloat_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311C9F0 Offset: 0x311BBF0 VA: 0x18311C9F0
	private static bool HasVector2_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311CA50 Offset: 0x311BC50 VA: 0x18311CA50
	private static bool HasVector3_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311CAB0 Offset: 0x311BCB0 VA: 0x18311CAB0
	private static bool HasVector4_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311CB10 Offset: 0x311BD10 VA: 0x18311CB10
	private static bool HasTexture_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311CB70 Offset: 0x311BD70 VA: 0x18311CB70
	private static void SetBool_Injected(IntPtr _unity_self, int nameID, bool b) { }

	// RVA: 0x311CBE0 Offset: 0x311BDE0 VA: 0x18311CBE0
	private static void SetInt_Injected(IntPtr _unity_self, int nameID, int i) { }

	// RVA: 0x311CC50 Offset: 0x311BE50 VA: 0x18311CC50
	private static void SetUInt_Injected(IntPtr _unity_self, int nameID, uint i) { }

	// RVA: 0x311CCC0 Offset: 0x311BEC0 VA: 0x18311CCC0
	private static void SetFloat_Injected(IntPtr _unity_self, int nameID, float f) { }

	// RVA: 0x311CD30 Offset: 0x311BF30 VA: 0x18311CD30
	private static void SetVector2_Injected(IntPtr _unity_self, int nameID, in Vector2 v) { }

	// RVA: 0x311CDA0 Offset: 0x311BFA0 VA: 0x18311CDA0
	private static void SetVector3_Injected(IntPtr _unity_self, int nameID, in Vector3 v) { }

	// RVA: 0x311CE10 Offset: 0x311C010 VA: 0x18311CE10
	private static void SetVector4_Injected(IntPtr _unity_self, int nameID, in Vector4 v) { }

	// RVA: 0x311CE80 Offset: 0x311C080 VA: 0x18311CE80
	private static void SetTexture_Injected(IntPtr _unity_self, int nameID, IntPtr t) { }

	// RVA: 0x311CEF0 Offset: 0x311C0F0 VA: 0x18311CEF0
	private static float GetFloat_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x311CF50 Offset: 0x311C150 VA: 0x18311CF50
	private static int get_aliveParticleCount_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.VFX
[UsedByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXRenderer.h")]
[RejectDragAndDropMaterial]
public sealed class VFXRenderer : Renderer // TypeDefIndex: 15782
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 15783
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 15784
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasGroup.h")]
[NativeClass("UI::CanvasGroup")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 15785
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; set; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x30BC2B0 Offset: 0x30BB4B0 VA: 0x1830BC2B0
	public float get_alpha() { }

	// RVA: 0x30BC350 Offset: 0x30BB550 VA: 0x1830BC350
	public void set_alpha(float value) { }

	// RVA: 0x30BC400 Offset: 0x30BB600 VA: 0x1830BC400
	public bool get_interactable() { }

	// RVA: 0x30BC4A0 Offset: 0x30BB6A0 VA: 0x1830BC4A0
	public bool get_blocksRaycasts() { }

	// RVA: 0x30BC540 Offset: 0x30BB740 VA: 0x1830BC540
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x30BC5F0 Offset: 0x30BB7F0 VA: 0x1830BC5F0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x30BC690 Offset: 0x30BB890 VA: 0x1830BC690
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x30BC4A0 Offset: 0x30BB6A0 VA: 0x1830BC4A0 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x30BC740 Offset: 0x30BB940 VA: 0x1830BC740
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BC790 Offset: 0x30BB990 VA: 0x1830BC790
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x30BC7F0 Offset: 0x30BB9F0 VA: 0x1830BC7F0
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BC840 Offset: 0x30BBA40 VA: 0x1830BC840
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BC890 Offset: 0x30BBA90 VA: 0x1830BC890
	private static void set_blocksRaycasts_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x30BC8F0 Offset: 0x30BBAF0 VA: 0x1830BC8F0
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BC940 Offset: 0x30BBB40 VA: 0x1830BC940
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasRenderer.h")]
[NativeClass("UI::CanvasRenderer")]
public sealed class CanvasRenderer : Component // TypeDefIndex: 15786
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x30BC9A0 Offset: 0x30BBBA0 VA: 0x1830BC9A0
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x30BCA50 Offset: 0x30BBC50 VA: 0x1830BCA50
	public int get_materialCount() { }

	// RVA: 0x30BCAF0 Offset: 0x30BBCF0 VA: 0x1830BCAF0
	public void set_materialCount(int value) { }

	// RVA: 0x30BCBA0 Offset: 0x30BBDA0 VA: 0x1830BCBA0
	public void set_popMaterialCount(int value) { }

	// RVA: 0x30BCC50 Offset: 0x30BBE50 VA: 0x1830BCC50
	public int get_absoluteDepth() { }

	// RVA: 0x30BCCF0 Offset: 0x30BBEF0 VA: 0x1830BCCF0
	public bool get_hasMoved() { }

	// RVA: 0x30BCD90 Offset: 0x30BBF90 VA: 0x1830BCD90
	public bool get_cullTransparentMesh() { }

	// RVA: 0x30BCE30 Offset: 0x30BC030 VA: 0x1830BCE30
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x30BCEE0 Offset: 0x30BC0E0 VA: 0x1830BCEE0
	public bool get_cull() { }

	// RVA: 0x30BCF80 Offset: 0x30BC180 VA: 0x1830BCF80
	public void set_cull(bool value) { }

	// RVA: 0x30BD030 Offset: 0x30BC230 VA: 0x1830BD030
	public void SetColor(Color color) { }

	// RVA: 0x30BD0E0 Offset: 0x30BC2E0 VA: 0x1830BD0E0
	public Color GetColor() { }

	// RVA: 0x30BD1A0 Offset: 0x30BC3A0 VA: 0x1830BD1A0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x30BD250 Offset: 0x30BC450 VA: 0x1830BD250
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x30BD300 Offset: 0x30BC500 VA: 0x1830BD300
	public void DisableRectClipping() { }

	// RVA: 0x30BD3A0 Offset: 0x30BC5A0 VA: 0x1830BD3A0
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x30BD490 Offset: 0x30BC690 VA: 0x1830BD490
	public Material GetMaterial(int index) { }

	// RVA: 0x30BD560 Offset: 0x30BC760 VA: 0x1830BD560
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x30BD650 Offset: 0x30BC850 VA: 0x1830BD650
	public void SetTexture(Texture texture) { }

	// RVA: 0x30BD730 Offset: 0x30BC930 VA: 0x1830BD730
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x30BD810 Offset: 0x30BCA10 VA: 0x1830BD810
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x30BD8F0 Offset: 0x30BCAF0 VA: 0x1830BD8F0
	public void Clear() { }

	// RVA: 0x30BD990 Offset: 0x30BCB90 VA: 0x1830BD990
	public float GetAlpha() { }

	// RVA: 0x30BDA40 Offset: 0x30BCC40 VA: 0x1830BDA40
	public void SetAlpha(float alpha) { }

	// RVA: 0x30BDBB0 Offset: 0x30BCDB0 VA: 0x1830BDBB0
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x30BDCE0 Offset: 0x30BCEE0 VA: 0x1830BDCE0
	public Material GetMaterial() { }

	// RVA: 0x30BDDA0 Offset: 0x30BCFA0 VA: 0x1830BDDA0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x30BDEB0 Offset: 0x30BD0B0 VA: 0x1830BDEB0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x30BDF40 Offset: 0x30BD140 VA: 0x1830BDF40
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x30BDFD0 Offset: 0x30BD1D0 VA: 0x1830BDFD0
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x30BDF40 Offset: 0x30BD140 VA: 0x1830BDF40
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x30BDEB0 Offset: 0x30BD0B0 VA: 0x1830BDEB0
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x30BE030 Offset: 0x30BD230 VA: 0x1830BE030
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x30BE090 Offset: 0x30BD290 VA: 0x1830BE090
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE0E0 Offset: 0x30BD2E0 VA: 0x1830BE0E0
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x30BE140 Offset: 0x30BD340 VA: 0x1830BE140
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x30BE1A0 Offset: 0x30BD3A0 VA: 0x1830BE1A0
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE1F0 Offset: 0x30BD3F0 VA: 0x1830BE1F0
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE240 Offset: 0x30BD440 VA: 0x1830BE240
	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE290 Offset: 0x30BD490 VA: 0x1830BE290
	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x30BE2F0 Offset: 0x30BD4F0 VA: 0x1830BE2F0
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE340 Offset: 0x30BD540 VA: 0x1830BE340
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x30BE3A0 Offset: 0x30BD5A0 VA: 0x1830BE3A0
	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	// RVA: 0x30BE400 Offset: 0x30BD600 VA: 0x1830BE400
	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x30BE460 Offset: 0x30BD660 VA: 0x1830BE460
	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	// RVA: 0x30BE4C0 Offset: 0x30BD6C0 VA: 0x1830BE4C0
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x30BE520 Offset: 0x30BD720 VA: 0x1830BE520
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x30BE570 Offset: 0x30BD770 VA: 0x1830BE570
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x30BE5E0 Offset: 0x30BD7E0 VA: 0x1830BE5E0
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x30BE640 Offset: 0x30BD840 VA: 0x1830BE640
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x30BE6B0 Offset: 0x30BD8B0 VA: 0x1830BE6B0
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x30BE710 Offset: 0x30BD910 VA: 0x1830BE710
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x30BE770 Offset: 0x30BD970 VA: 0x1830BE770
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	// RVA: 0x30BE7D0 Offset: 0x30BD9D0 VA: 0x1830BE7D0
	private static void Clear_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI", 2)]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
public sealed class RectTransformUtility // TypeDefIndex: 15787
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x30BE820 Offset: 0x30BDA20 VA: 0x1830BE820
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x30BE940 Offset: 0x30BDB40 VA: 0x1830BE940
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x30BEA60 Offset: 0x30BDC60 VA: 0x1830BEA60
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x30BEB80 Offset: 0x30BDD80 VA: 0x1830BEB80
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x30BEC40 Offset: 0x30BDE40 VA: 0x1830BEC40
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x30BEDA0 Offset: 0x30BDFA0 VA: 0x1830BEDA0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x30BF540 Offset: 0x30BE740 VA: 0x1830BF540
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x30BF6E0 Offset: 0x30BE8E0 VA: 0x1830BF6E0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x30BF9C0 Offset: 0x30BEBC0 VA: 0x1830BF9C0
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x30BFB70 Offset: 0x30BED70 VA: 0x1830BFB70
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x30C0490 Offset: 0x30BF690 VA: 0x1830C0490
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x30C0CE0 Offset: 0x30BFEE0 VA: 0x1830C0CE0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x30C0D00 Offset: 0x30BFF00 VA: 0x1830C0D00
	private static void .cctor() { }

	// RVA: 0x30C0DC0 Offset: 0x30BFFC0 VA: 0x1830C0DC0
	private static void PixelAdjustPoint_Injected(in Vector2 point, IntPtr elementTransform, IntPtr canvas, out Vector2 ret) { }

	// RVA: 0x30C0E40 Offset: 0x30C0040 VA: 0x1830C0E40
	private static void PixelAdjustRect_Injected(IntPtr rectTransform, IntPtr canvas, out Rect ret) { }

	// RVA: 0x30C0EB0 Offset: 0x30C00B0 VA: 0x1830C0EB0
	private static bool PointInRectangle_Injected(in Vector2 screenPoint, IntPtr rect, IntPtr cam, in Vector4 offset) { }
}

// Namespace: UnityEngine
public enum RenderMode // TypeDefIndex: 15788
{
	// Fields
	public int value__; // 0x0
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
[Flags]
public enum AdditionalCanvasShaderChannels // TypeDefIndex: 15789
{
	// Fields
	public int value__; // 0x0
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: 
public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 15790
{
	// Methods

	// RVA: 0x477570 Offset: 0x476770 VA: 0x180477570
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464320 Offset: 0x463520 VA: 0x180464320 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[RequireComponent(typeof(RectTransform))]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeClass("UI::Canvas")]
public sealed class Canvas : Behaviour // TypeDefIndex: 15791
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; }
	public bool isRootCanvas { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action<int> externBeginRenderOverlays { get; }
	internal static Action<int, int> externRenderOverlaysBefore { get; }
	internal static Action<int> externEndRenderOverlays { get; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30C0F30 Offset: 0x30C0130 VA: 0x1830C0F30
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x30C1040 Offset: 0x30C0240 VA: 0x1830C1040
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x30C1150 Offset: 0x30C0350 VA: 0x1830C1150
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x30C1260 Offset: 0x30C0460 VA: 0x1830C1260
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x30C1370 Offset: 0x30C0570 VA: 0x1830C1370
	public RenderMode get_renderMode() { }

	// RVA: 0x30C1410 Offset: 0x30C0610 VA: 0x1830C1410
	public bool get_isRootCanvas() { }

	// RVA: 0x30C14B0 Offset: 0x30C06B0 VA: 0x1830C14B0
	public float get_scaleFactor() { }

	// RVA: 0x30C1550 Offset: 0x30C0750 VA: 0x1830C1550
	public void set_scaleFactor(float value) { }

	// RVA: 0x30C1600 Offset: 0x30C0800 VA: 0x1830C1600
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x30C16A0 Offset: 0x30C08A0 VA: 0x1830C16A0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x30C1750 Offset: 0x30C0950 VA: 0x1830C1750
	public bool get_pixelPerfect() { }

	// RVA: 0x30C17F0 Offset: 0x30C09F0 VA: 0x1830C17F0
	public int get_renderOrder() { }

	// RVA: 0x30C1890 Offset: 0x30C0A90 VA: 0x1830C1890
	public bool get_overrideSorting() { }

	// RVA: 0x30C1930 Offset: 0x30C0B30 VA: 0x1830C1930
	public void set_overrideSorting(bool value) { }

	// RVA: 0x30C19E0 Offset: 0x30C0BE0 VA: 0x1830C19E0
	public int get_sortingOrder() { }

	// RVA: 0x30C1A80 Offset: 0x30C0C80 VA: 0x1830C1A80
	public void set_sortingOrder(int value) { }

	// RVA: 0x30C1B30 Offset: 0x30C0D30 VA: 0x1830C1B30
	public int get_targetDisplay() { }

	// RVA: 0x30C1BD0 Offset: 0x30C0DD0 VA: 0x1830C1BD0
	public int get_sortingLayerID() { }

	// RVA: 0x30C1C70 Offset: 0x30C0E70 VA: 0x1830C1C70
	public void set_sortingLayerID(int value) { }

	// RVA: 0x30C1D20 Offset: 0x30C0F20 VA: 0x1830C1D20
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x30C1DC0 Offset: 0x30C0FC0 VA: 0x1830C1DC0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x30C1E70 Offset: 0x30C1070 VA: 0x1830C1E70
	public Canvas get_rootCanvas() { }

	// RVA: 0x30C1F30 Offset: 0x30C1130 VA: 0x1830C1F30
	public Vector2 get_renderingDisplaySize() { }

	[CompilerGenerated]
	// RVA: 0x30C1FE0 Offset: 0x30C11E0 VA: 0x1830C1FE0
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x30C2020 Offset: 0x30C1220 VA: 0x1830C2020
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	// RVA: 0x30C2060 Offset: 0x30C1260 VA: 0x1830C2060
	internal static Action<int> get_externEndRenderOverlays() { }

	// RVA: 0x30C20A0 Offset: 0x30C12A0 VA: 0x1830C20A0
	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x30C2160 Offset: 0x30C1360 VA: 0x1830C2160
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x30C21E0 Offset: 0x30C13E0 VA: 0x1830C21E0
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x30C2260 Offset: 0x30C1460 VA: 0x1830C2260
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x30C2300 Offset: 0x30C1500 VA: 0x1830C2300
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x30C2360 Offset: 0x30C1560 VA: 0x1830C2360
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x30C23C0 Offset: 0x30C15C0 VA: 0x1830C23C0
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x30C2420 Offset: 0x30C1620 VA: 0x1830C2420
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x30C2490 Offset: 0x30C1690 VA: 0x1830C2490
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x30C24F0 Offset: 0x30C16F0 VA: 0x1830C24F0
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2540 Offset: 0x30C1740 VA: 0x1830C2540
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2590 Offset: 0x30C1790 VA: 0x1830C2590
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C25E0 Offset: 0x30C17E0 VA: 0x1830C25E0
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x30C2640 Offset: 0x30C1840 VA: 0x1830C2640
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2690 Offset: 0x30C1890 VA: 0x1830C2690
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x30C26F0 Offset: 0x30C18F0 VA: 0x1830C26F0
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2740 Offset: 0x30C1940 VA: 0x1830C2740
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2790 Offset: 0x30C1990 VA: 0x1830C2790
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C27E0 Offset: 0x30C19E0 VA: 0x1830C27E0
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x30C2840 Offset: 0x30C1A40 VA: 0x1830C2840
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2890 Offset: 0x30C1A90 VA: 0x1830C2890
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x30C28F0 Offset: 0x30C1AF0 VA: 0x1830C28F0
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2940 Offset: 0x30C1B40 VA: 0x1830C2940
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2990 Offset: 0x30C1B90 VA: 0x1830C2990
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x30C29F0 Offset: 0x30C1BF0 VA: 0x1830C29F0
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2A40 Offset: 0x30C1C40 VA: 0x1830C2A40
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	// RVA: 0x30C2AA0 Offset: 0x30C1CA0 VA: 0x1830C2AA0
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2AF0 Offset: 0x30C1CF0 VA: 0x1830C2AF0
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x30C2B50 Offset: 0x30C1D50 VA: 0x1830C2B50
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	// RVA: 0x30C2BA0 Offset: 0x30C1DA0 VA: 0x1830C2BA0
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	// RVA: 0x30C2BF0 Offset: 0x30C1DF0 VA: 0x1830C2BF0
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }
}

// Namespace: 
public enum UISystemProfilerApi.SampleType // TypeDefIndex: 15792
{
	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;
}

// Namespace: UnityEngine
[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI::SystemProfilerApi", 2)]
public static class UISystemProfilerApi // TypeDefIndex: 15793
{
	// Methods

	// RVA: 0x30C2C40 Offset: 0x30C1E40 VA: 0x1830C2C40
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x30C2C90 Offset: 0x30C1E90 VA: 0x1830C2C90
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x30C2CE0 Offset: 0x30C1EE0 VA: 0x1830C2CE0
	public static void AddMarker(string name, Object obj) { }

	// RVA: 0x30C2E60 Offset: 0x30C2060 VA: 0x1830C2E60
	private static void AddMarker_Injected(ref ManagedSpanWrapper name, IntPtr obj) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15794
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 15795
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3113B90 Offset: 0x3112D90 VA: 0x183113B90
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x3113FF0 Offset: 0x31131F0 VA: 0x183113FF0
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x3114460 Offset: 0x3113660 VA: 0x183114460
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x3114880 Offset: 0x3113A80 VA: 0x183114880
	private static string URLDecode(string encoded) { }

	// RVA: 0x3114990 Offset: 0x3113B90 VA: 0x183114990
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 15796
{
	// Fields
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0x3114A70 Offset: 0x3113C70 VA: 0x183114A70
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x3114A80 Offset: 0x3113C80 VA: 0x183114A80
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 15797
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x3115050 Offset: 0x3114250 VA: 0x183115050
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x31150E0 Offset: 0x31142E0 VA: 0x1831150E0
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x3115150 Offset: 0x3114350 VA: 0x183115150
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x31151E0 Offset: 0x31143E0 VA: 0x1831151E0
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x3115540 Offset: 0x3114740 VA: 0x183115540
	private static void .cctor() { }
}

// Namespace: 
internal static class CertificateHandler.BindingsMarshaller // TypeDefIndex: 15798
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(CertificateHandler handler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler // TypeDefIndex: 15799
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3115A70 Offset: 0x3114C70 VA: 0x183115A70
	private void ReleaseFromScripting() { }

	// RVA: 0x11B51F0 Offset: 0x11B43F0 VA: 0x1811B51F0 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x22B6920 Offset: 0x22B5B20 VA: 0x1822B6920
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x3115AE0 Offset: 0x3114CE0 VA: 0x183115AE0 Slot: 5
	public void Dispose() { }

	// RVA: 0x3115B50 Offset: 0x3114D50 VA: 0x183115B50
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal static class DownloadHandler.BindingsMarshaller // TypeDefIndex: 15800
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(DownloadHandler handler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 15801
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3115BA0 Offset: 0x3114DA0 VA: 0x183115BA0
	private void ReleaseFromScripting() { }

	[VisibleToOtherModules]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	internal void .ctor() { }

	// RVA: 0x3115C10 Offset: 0x3114E10 VA: 0x183115C10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3115C60 Offset: 0x3114E60 VA: 0x183115C60 Slot: 5
	public virtual void Dispose() { }

	[RequiredByNativeCode]
	// RVA: 0xFC06C0 Offset: 0xFBF8C0 VA: 0x180FC06C0 Slot: 6
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x52BF80 Offset: 0x52B180 VA: 0x18052BF80 Slot: 7
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 8
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 9
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x3115CD0 Offset: 0x3114ED0 VA: 0x183115CD0 Slot: 10
	protected virtual float GetProgress() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DA280 Offset: 0x10D9480 VA: 0x1810DA280
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
	// RVA: 0x3115CE0 Offset: 0x3114EE0 VA: 0x183115CE0
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x3115D20 Offset: 0x3114F20 VA: 0x183115D20
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal static class UnityWebRequestAsyncOperation.BindingsMarshaller // TypeDefIndex: 15802
{
	// Methods

	// RVA: 0x3115D70 Offset: 0x3114F70 VA: 0x183115D70
	public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }
}

// Namespace: UnityEngine.Networking
[UsedByNativeCode]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 15803
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	internal UnityWebRequest webRequest { set; }

	// Methods

	// RVA: 0x2F18520 Offset: 0x2F17720 VA: 0x182F18520
	private void .ctor(IntPtr ptr) { }

	[CompilerGenerated]
	// RVA: 0x49BDD0 Offset: 0x49AFD0 VA: 0x18049BDD0
	internal void set_webRequest(UnityWebRequest value) { }
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 15804
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 15805
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError OKCached = 1;
	public const UnityWebRequest.UnityWebRequestError Unknown = 2;
	public const UnityWebRequest.UnityWebRequestError SDKError = 3;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 4;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 6;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 7;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 8;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 9;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 10;
	public const UnityWebRequest.UnityWebRequestError WriteError = 11;
	public const UnityWebRequest.UnityWebRequestError ReadError = 12;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 13;
	public const UnityWebRequest.UnityWebRequestError Timeout = 14;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 15;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 16;
	public const UnityWebRequest.UnityWebRequestError Aborted = 17;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 18;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 19;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 21;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 24;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 25;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 26;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 27;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 28;
	public const UnityWebRequest.UnityWebRequestError RedirectLimitInvalid = 29;
	public const UnityWebRequest.UnityWebRequestError InvalidRedirect = 30;
	public const UnityWebRequest.UnityWebRequestError CannotModifyRequest = 31;
	public const UnityWebRequest.UnityWebRequestError HeaderNameContainsInvalidCharacters = 32;
	public const UnityWebRequest.UnityWebRequestError HeaderValueContainsInvalidCharacters = 33;
	public const UnityWebRequest.UnityWebRequestError CannotOverrideSystemHeaders = 34;
	public const UnityWebRequest.UnityWebRequestError AlreadySent = 35;
	public const UnityWebRequest.UnityWebRequestError InvalidMethod = 36;
	public const UnityWebRequest.UnityWebRequestError NotImplemented = 37;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 38;
	public const UnityWebRequest.UnityWebRequestError DataProcessingError = 39;
	public const UnityWebRequest.UnityWebRequestError InsecureConnectionNotAllowed = 40;
}

// Namespace: 
public enum UnityWebRequest.Result // TypeDefIndex: 15806
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.Result InProgress = 0;
	public const UnityWebRequest.Result Success = 1;
	public const UnityWebRequest.Result ConnectionError = 2;
	public const UnityWebRequest.Result ProtocolError = 3;
	public const UnityWebRequest.Result DataProcessingError = 4;
}

// Namespace: 
internal static class UnityWebRequest.BindingsMarshaller // TypeDefIndex: 15807
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 15808
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public UnityWebRequest.Result result { get; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	// RVA: 0x3115E10 Offset: 0x3115010 VA: 0x183115E10
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x3115EE0 Offset: 0x31150E0 VA: 0x183115EE0
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x56C560 Offset: 0x56B760 VA: 0x18056C560
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x56C570 Offset: 0x56B770 VA: 0x18056C570
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x56C580 Offset: 0x56B780 VA: 0x18056C580
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x56C590 Offset: 0x56B790 VA: 0x18056C590
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x56D1E0 Offset: 0x56C3E0 VA: 0x18056D1E0
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x56D1F0 Offset: 0x56C3F0 VA: 0x18056D1F0
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x3115FB0 Offset: 0x31151B0 VA: 0x183115FB0
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3116000 Offset: 0x3115200 VA: 0x183116000
	private void Release() { }

	// RVA: 0x3116070 Offset: 0x3115270 VA: 0x183116070
	internal void InternalDestroy() { }

	// RVA: 0x3116130 Offset: 0x3115330 VA: 0x183116130
	private void InternalSetDefaults() { }

	// RVA: 0x3116140 Offset: 0x3115340 VA: 0x183116140
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x3116370 Offset: 0x3115570 VA: 0x183116370 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31163C0 Offset: 0x31155C0 VA: 0x1831163C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3116430 Offset: 0x3115630 VA: 0x183116430
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x31164F0 Offset: 0x31156F0 VA: 0x1831164F0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x3116610 Offset: 0x3115810 VA: 0x183116610
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3116780 Offset: 0x3115980 VA: 0x183116780
	public void Abort() { }

	// RVA: 0x31167F0 Offset: 0x31159F0 VA: 0x1831167F0
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x3116870 Offset: 0x3115A70 VA: 0x183116870
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x31169F0 Offset: 0x3115BF0 VA: 0x1831169F0
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x3116B70 Offset: 0x3115D70 VA: 0x183116B70
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x3116CB0 Offset: 0x3115EB0 VA: 0x183116CB0
	public void set_method(string value) { }

	// RVA: 0x3116FF0 Offset: 0x31161F0 VA: 0x183116FF0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x3117060 Offset: 0x3116260 VA: 0x183117060
	public string get_error() { }

	// RVA: 0x31172B0 Offset: 0x31164B0 VA: 0x1831172B0
	public void set_url(string value) { }

	// RVA: 0x3117450 Offset: 0x3116650 VA: 0x183117450
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x31175D0 Offset: 0x31167D0 VA: 0x1831175D0
	private void InternalSetUrl(string url) { }

	// RVA: 0x3117710 Offset: 0x3116910 VA: 0x183117710
	public long get_responseCode() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x3117780 Offset: 0x3116980 VA: 0x183117780
	public bool get_isModifiable() { }

	// RVA: 0x31177F0 Offset: 0x31169F0 VA: 0x1831177F0
	public bool get_isDone() { }

	[NativeMethod("GetResult")]
	// RVA: 0x3117870 Offset: 0x3116A70 VA: 0x183117870
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x31178E0 Offset: 0x3116AE0 VA: 0x1831178E0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x2F3A7B0 Offset: 0x2F399B0 VA: 0x182F3A7B0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x3117970 Offset: 0x3116B70 VA: 0x183117970
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x3117B60 Offset: 0x3116D60 VA: 0x183117B60
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1D98F20 Offset: 0x1D98120 VA: 0x181D98F20
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x3117BF0 Offset: 0x3116DF0 VA: 0x183117BF0
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x2F39F00 Offset: 0x2F39100 VA: 0x182F39F00
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x3117DE0 Offset: 0x3116FE0 VA: 0x183117DE0
	private static void GetWebErrorString_Injected(UnityWebRequest.UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	// RVA: 0x3117E40 Offset: 0x3117040 VA: 0x183117E40
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	// RVA: 0x3117EA0 Offset: 0x31170A0 VA: 0x183117EA0
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x3117EF0 Offset: 0x31170F0 VA: 0x183117EF0
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	// RVA: 0x3117F40 Offset: 0x3117140 VA: 0x183117F40
	private static void Abort_Injected(IntPtr _unity_self) { }

	// RVA: 0x3117F90 Offset: 0x3117190 VA: 0x183117F90
	private static UnityWebRequest.UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x3117FF0 Offset: 0x31171F0 VA: 0x183117FF0
	private static UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	// RVA: 0x3118050 Offset: 0x3117250 VA: 0x183118050
	private static UnityWebRequest.UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	// RVA: 0x31180A0 Offset: 0x31172A0 VA: 0x1831180A0
	private static UnityWebRequest.UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

	// RVA: 0x3118100 Offset: 0x3117300 VA: 0x183118100
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x3118150 Offset: 0x3117350 VA: 0x183118150
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	// RVA: 0x31181A0 Offset: 0x31173A0 VA: 0x1831181A0
	private static UnityWebRequest.Result get_result_Injected(IntPtr _unity_self) { }

	// RVA: 0x31181F0 Offset: 0x31173F0 VA: 0x1831181F0
	private static UnityWebRequest.UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	// RVA: 0x3118250 Offset: 0x3117450 VA: 0x183118250
	private static UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }
}

// Namespace: 
internal static class UploadHandler.BindingsMarshaller // TypeDefIndex: 15809
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler // TypeDefIndex: 15810
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x31182B0 Offset: 0x31174B0 VA: 0x1831182B0
	private void ReleaseFromScripting() { }

	// RVA: 0x3118320 Offset: 0x3117520 VA: 0x183118320 Slot: 4
	public virtual void Dispose() { }

	// RVA: 0x3118390 Offset: 0x3117590 VA: 0x183118390
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15811
{}

// Namespace: 
public struct ParticleSystem.MainModule // TypeDefIndex: 15812
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public float duration { get; set; }
	public bool loop { set; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	[NativeName("StartLifetime")]
	private ParticleSystem.MinMaxCurveBlittable startLifetimeBlittable { get; set; }
	public float startLifetimeMultiplier { set; }
	public ParticleSystem.MinMaxCurve startSpeed { set; }
	[NativeName("StartSpeed")]
	private ParticleSystem.MinMaxCurveBlittable startSpeedBlittable { set; }
	public float startSpeedMultiplier { set; }
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeName("StartSizeX")]
	private ParticleSystem.MinMaxCurveBlittable startSizeBlittable { get; set; }
	[NativeName("StartSizeXMultiplier")]
	public float startSizeMultiplier { set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	[NativeName("StartColor")]
	private ParticleSystem.MinMaxGradientBlittable startColorBlittable { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { set; }
	public Transform customSimulationSpace { set; }
	public ParticleSystemScalingMode scalingMode { get; }
	public bool playOnAwake { set; }

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x2FB5F10 Offset: 0x2FB5110 VA: 0x182FB5F10
	public float get_duration() { }

	[NativeThrows]
	// RVA: 0x2FB5F60 Offset: 0x2FB5160 VA: 0x182FB5F60
	public void set_duration(float value) { }

	[NativeThrows]
	// RVA: 0x2FB5FC0 Offset: 0x2FB51C0 VA: 0x182FB5FC0
	public void set_loop(bool value) { }

	// RVA: 0x2FB6020 Offset: 0x2FB5220 VA: 0x182FB6020
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	// RVA: 0x2FB60D0 Offset: 0x2FB52D0 VA: 0x182FB60D0
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x2FB6210 Offset: 0x2FB5410 VA: 0x182FB6210
	private ParticleSystem.MinMaxCurveBlittable get_startLifetimeBlittable() { }

	[NativeThrows]
	// RVA: 0x2FB6280 Offset: 0x2FB5480 VA: 0x182FB6280
	private void set_startLifetimeBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	[NativeThrows]
	// RVA: 0x2FB62E0 Offset: 0x2FB54E0 VA: 0x182FB62E0
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x2FB6340 Offset: 0x2FB5540 VA: 0x182FB6340
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	[NativeThrows]
	// RVA: 0x2FB6480 Offset: 0x2FB5680 VA: 0x182FB6480
	private void set_startSpeedBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	[NativeThrows]
	// RVA: 0x2FB64E0 Offset: 0x2FB56E0 VA: 0x182FB64E0
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x2FB6540 Offset: 0x2FB5740 VA: 0x182FB6540
	public ParticleSystem.MinMaxCurve get_startSize() { }

	// RVA: 0x2FB65F0 Offset: 0x2FB57F0 VA: 0x182FB65F0
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x2FB6730 Offset: 0x2FB5930 VA: 0x182FB6730
	private ParticleSystem.MinMaxCurveBlittable get_startSizeBlittable() { }

	[NativeThrows]
	// RVA: 0x2FB67A0 Offset: 0x2FB59A0 VA: 0x182FB67A0
	private void set_startSizeBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	[NativeThrows]
	// RVA: 0x2FB6800 Offset: 0x2FB5A00 VA: 0x182FB6800
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x2FB6860 Offset: 0x2FB5A60 VA: 0x182FB6860
	public ParticleSystem.MinMaxGradient get_startColor() { }

	// RVA: 0x2FB6A50 Offset: 0x2FB5C50 VA: 0x182FB6A50
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x2FB6B70 Offset: 0x2FB5D70 VA: 0x182FB6B70
	private ParticleSystem.MinMaxGradientBlittable get_startColorBlittable() { }

	[NativeThrows]
	// RVA: 0x2FB6BF0 Offset: 0x2FB5DF0 VA: 0x182FB6BF0
	private void set_startColorBlittable(ParticleSystem.MinMaxGradientBlittable value) { }

	[NativeThrows]
	// RVA: 0x2FB6C50 Offset: 0x2FB5E50 VA: 0x182FB6C50
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	[NativeThrows]
	// RVA: 0x2FB6CB0 Offset: 0x2FB5EB0 VA: 0x182FB6CB0
	public void set_customSimulationSpace(Transform value) { }

	// RVA: 0x2FB6D50 Offset: 0x2FB5F50 VA: 0x182FB6D50
	public ParticleSystemScalingMode get_scalingMode() { }

	[NativeThrows]
	// RVA: 0x2FB6DA0 Offset: 0x2FB5FA0 VA: 0x182FB6DA0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x2FB6E00 Offset: 0x2FB6000 VA: 0x182FB6E00
	private static void get_startLifetimeBlittable_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurveBlittable ret) { }

	// RVA: 0x2FB6E60 Offset: 0x2FB6060 VA: 0x182FB6E60
	private static void set_startLifetimeBlittable_Injected(ref ParticleSystem.MainModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB6EC0 Offset: 0x2FB60C0 VA: 0x182FB6EC0
	private static void set_startSpeedBlittable_Injected(ref ParticleSystem.MainModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB6F20 Offset: 0x2FB6120 VA: 0x182FB6F20
	private static void get_startSizeBlittable_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurveBlittable ret) { }

	// RVA: 0x2FB6F80 Offset: 0x2FB6180 VA: 0x182FB6F80
	private static void set_startSizeBlittable_Injected(ref ParticleSystem.MainModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB6FE0 Offset: 0x2FB61E0 VA: 0x182FB6FE0
	private static void get_startColorBlittable_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradientBlittable ret) { }

	// RVA: 0x2FB7040 Offset: 0x2FB6240 VA: 0x182FB7040
	private static void set_startColorBlittable_Injected(ref ParticleSystem.MainModule _unity_self, in ParticleSystem.MinMaxGradientBlittable value) { }

	// RVA: 0x2FB70A0 Offset: 0x2FB62A0 VA: 0x182FB70A0
	private static void set_customSimulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, IntPtr value) { }
}

// Namespace: 
public struct ParticleSystem.EmissionModule // TypeDefIndex: 15813
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	[NativeName("RateOverTime")]
	private ParticleSystem.MinMaxCurveBlittable rateOverTimeBlittable { get; set; }
	public float rateOverTimeMultiplier { set; }
	public ParticleSystem.MinMaxCurve rateOverDistance { get; set; }
	[NativeName("RateOverDistance")]
	private ParticleSystem.MinMaxCurveBlittable rateOverDistanceBlittable { get; set; }

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x2FB7100 Offset: 0x2FB6300 VA: 0x182FB7100
	public bool get_enabled() { }

	[NativeThrows]
	// RVA: 0x2FB7150 Offset: 0x2FB6350 VA: 0x182FB7150
	public void set_enabled(bool value) { }

	// RVA: 0x2FB71B0 Offset: 0x2FB63B0 VA: 0x182FB71B0
	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	// RVA: 0x2FB7260 Offset: 0x2FB6460 VA: 0x182FB7260
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x2FB73A0 Offset: 0x2FB65A0 VA: 0x182FB73A0
	private ParticleSystem.MinMaxCurveBlittable get_rateOverTimeBlittable() { }

	[NativeThrows]
	// RVA: 0x2FB7410 Offset: 0x2FB6610 VA: 0x182FB7410
	private void set_rateOverTimeBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	[NativeThrows]
	// RVA: 0x2FB7470 Offset: 0x2FB6670 VA: 0x182FB7470
	public void set_rateOverTimeMultiplier(float value) { }

	// RVA: 0x2FB74D0 Offset: 0x2FB66D0 VA: 0x182FB74D0
	public ParticleSystem.MinMaxCurve get_rateOverDistance() { }

	// RVA: 0x2FB7580 Offset: 0x2FB6780 VA: 0x182FB7580
	public void set_rateOverDistance(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x2FB76C0 Offset: 0x2FB68C0 VA: 0x182FB76C0
	private ParticleSystem.MinMaxCurveBlittable get_rateOverDistanceBlittable() { }

	[NativeThrows]
	// RVA: 0x2FB7730 Offset: 0x2FB6930 VA: 0x182FB7730
	private void set_rateOverDistanceBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB7790 Offset: 0x2FB6990 VA: 0x182FB7790
	private static void get_rateOverTimeBlittable_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurveBlittable ret) { }

	// RVA: 0x2FB77F0 Offset: 0x2FB69F0 VA: 0x182FB77F0
	private static void set_rateOverTimeBlittable_Injected(ref ParticleSystem.EmissionModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB7850 Offset: 0x2FB6A50 VA: 0x182FB7850
	private static void get_rateOverDistanceBlittable_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurveBlittable ret) { }

	// RVA: 0x2FB78B0 Offset: 0x2FB6AB0 VA: 0x182FB78B0
	private static void set_rateOverDistanceBlittable_Injected(ref ParticleSystem.EmissionModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }
}

// Namespace: 
public struct ParticleSystem.ShapeModule // TypeDefIndex: 15814
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public Mesh mesh { set; }
	public MeshRenderer meshRenderer { get; set; }

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(ParticleSystem particleSystem) { }

	[NativeThrows]
	// RVA: 0x2FB7910 Offset: 0x2FB6B10 VA: 0x182FB7910
	public void set_mesh(Mesh value) { }

	// RVA: 0x2FB79B0 Offset: 0x2FB6BB0 VA: 0x182FB79B0
	public MeshRenderer get_meshRenderer() { }

	[NativeThrows]
	// RVA: 0x2FB7A30 Offset: 0x2FB6C30 VA: 0x182FB7A30
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x2FB7AD0 Offset: 0x2FB6CD0 VA: 0x182FB7AD0
	private static void set_mesh_Injected(ref ParticleSystem.ShapeModule _unity_self, IntPtr value) { }

	// RVA: 0x2FB7B30 Offset: 0x2FB6D30 VA: 0x182FB7B30
	private static IntPtr get_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x2FB7B80 Offset: 0x2FB6D80 VA: 0x182FB7B80
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, IntPtr value) { }
}

// Namespace: 
[RequiredByNativeCode("particleSystemParticle", Optional = True)]
public struct ParticleSystem.Particle // TypeDefIndex: 15815
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x2A7FE20 Offset: 0x2A7F020 VA: 0x182A7FE20
	public void set_lifetime(float value) { }

	// RVA: 0x70A370 Offset: 0x709570 VA: 0x18070A370
	public void set_position(Vector3 value) { }

	// RVA: 0x16CF510 Offset: 0x16CE710 VA: 0x1816CF510
	public void set_velocity(Vector3 value) { }

	// RVA: 0x2A7FE20 Offset: 0x2A7F020 VA: 0x182A7FE20
	public void set_remainingLifetime(float value) { }

	// RVA: 0x62AE40 Offset: 0x62A040 VA: 0x18062AE40
	public void set_startLifetime(float value) { }

	// RVA: 0x43F710 Offset: 0x43E910 VA: 0x18043F710
	public void set_startColor(Color32 value) { }

	// RVA: 0x52BAA0 Offset: 0x52ACA0 VA: 0x18052BAA0
	public void set_randomSeed(uint value) { }

	// RVA: 0x2FB7BE0 Offset: 0x2FB6DE0 VA: 0x182FB7BE0
	public void set_startSize(float value) { }

	// RVA: 0x2FB7C00 Offset: 0x2FB6E00 VA: 0x182FB7C00
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x2FB7C40 Offset: 0x2FB6E40 VA: 0x182FB7C40
	public void set_angularVelocity3D(Vector3 value) { }
}

// Namespace: 
[Serializable]
public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 15816
{
	// Fields
	[SerializeField]
	internal ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField]
	internal float m_CurveMultiplier; // 0x4
	[SerializeField]
	internal AnimationCurve m_CurveMin; // 0x8
	[SerializeField]
	internal AnimationCurve m_CurveMax; // 0x10
	[SerializeField]
	internal float m_ConstantMin; // 0x18
	[SerializeField]
	internal float m_ConstantMax; // 0x1C

	// Properties
	public float constantMax { get; }
	public float constantMin { get; }
	public float constant { get; }

	// Methods

	// RVA: 0x2FB7C80 Offset: 0x2FB6E80 VA: 0x182FB7C80
	public void .ctor(float constant) { }

	// RVA: 0x2FB7D40 Offset: 0x2FB6F40 VA: 0x182FB7D40
	public void .ctor(float min, float max) { }

	// RVA: 0x2FB7E10 Offset: 0x2FB7010 VA: 0x182FB7E10
	public float get_constantMax() { }

	// RVA: 0x2EA9230 Offset: 0x2EA8430 VA: 0x182EA9230
	public float get_constantMin() { }

	// RVA: 0x2FB7E10 Offset: 0x2FB7010 VA: 0x182FB7E10
	public float get_constant() { }

	// RVA: 0x2FB7E20 Offset: 0x2FB7020 VA: 0x182FB7E20
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }
}

// Namespace: 
[RequiredByNativeCode]
[NativeType(1, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
internal struct ParticleSystem.MinMaxCurveBlittable // TypeDefIndex: 15817
{
	// Fields
	private ParticleSystemCurveMode m_Mode; // 0x0
	private float m_CurveMultiplier; // 0x4
	private IntPtr m_CurveMin; // 0x8
	private IntPtr m_CurveMax; // 0x10
	internal float m_ConstantMin; // 0x18
	internal float m_ConstantMax; // 0x1C

	// Methods

	// RVA: 0x2FB7E70 Offset: 0x2FB7070 VA: 0x182FB7E70
	public static ParticleSystem.MinMaxCurve op_Implicit(ParticleSystem.MinMaxCurveBlittable minMaxCurveBlittable) { }

	// RVA: 0x2FB7FF0 Offset: 0x2FB71F0 VA: 0x182FB7FF0
	public static ParticleSystem.MinMaxCurveBlittable op_Implicit(ParticleSystem.MinMaxCurve minMaxCurve) { }

	// RVA: 0x2FB8090 Offset: 0x2FB7290 VA: 0x182FB8090
	internal static ParticleSystem.MinMaxCurveBlittable FromMixMaxCurve(in ParticleSystem.MinMaxCurve minMaxCurve) { }

	// RVA: 0x2FB8140 Offset: 0x2FB7340 VA: 0x182FB8140
	internal static ParticleSystem.MinMaxCurve ToMinMaxCurve(in ParticleSystem.MinMaxCurveBlittable minMaxCurveBlittable) { }
}

// Namespace: 
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 15818
{
	// Fields
	[SerializeField]
	internal ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField]
	internal Gradient m_GradientMin; // 0x8
	[SerializeField]
	internal Gradient m_GradientMax; // 0x10
	[SerializeField]
	internal Color m_ColorMin; // 0x18
	[SerializeField]
	internal Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x2FB82E0 Offset: 0x2FB74E0 VA: 0x182FB82E0
	public void .ctor(Color color) { }

	// RVA: 0x2FB83C0 Offset: 0x2FB75C0 VA: 0x182FB83C0
	public Color get_color() { }

	// RVA: 0x2FB83D0 Offset: 0x2FB75D0 VA: 0x182FB83D0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }
}

// Namespace: 
[RequiredByNativeCode]
[NativeType(1, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
internal struct ParticleSystem.MinMaxGradientBlittable // TypeDefIndex: 15819
{
	// Fields
	private ParticleSystemGradientMode m_Mode; // 0x0
	private IntPtr m_GradientMin; // 0x8
	private IntPtr m_GradientMax; // 0x10
	private Color m_ColorMin; // 0x18
	private Color m_ColorMax; // 0x28

	// Methods

	// RVA: 0x2FB8500 Offset: 0x2FB7700 VA: 0x182FB8500
	public static ParticleSystem.MinMaxGradient op_Implicit(ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable) { }

	// RVA: 0x2FB8690 Offset: 0x2FB7890 VA: 0x182FB8690
	public static ParticleSystem.MinMaxGradientBlittable op_Implicit(ParticleSystem.MinMaxGradient minMaxGradient) { }

	// RVA: 0x2FB8730 Offset: 0x2FB7930 VA: 0x182FB8730
	internal static ParticleSystem.MinMaxGradientBlittable FromMixMaxGradient(in ParticleSystem.MinMaxGradient minMaxGradient) { }

	// RVA: 0x2FB87E0 Offset: 0x2FB79E0 VA: 0x182FB87E0
	internal static ParticleSystem.MinMaxGradient ToMinMaxGradient(in ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable) { }
}

// Namespace: 
public struct ParticleSystem.EmitParams // TypeDefIndex: 15820
{
	// Fields
	[NativeName("particle")]
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeName("positionSet")]
	private bool m_PositionSet; // 0x84
	[NativeName("velocitySet")]
	private bool m_VelocitySet; // 0x85
	[NativeName("axisOfRotationSet")]
	private bool m_AxisOfRotationSet; // 0x86
	[NativeName("rotationSet")]
	private bool m_RotationSet; // 0x87
	[NativeName("rotationalSpeedSet")]
	private bool m_AngularVelocitySet; // 0x88
	[NativeName("startSizeSet")]
	private bool m_StartSizeSet; // 0x89
	[NativeName("startColorSet")]
	private bool m_StartColorSet; // 0x8A
	[NativeName("randomSeedSet")]
	private bool m_RandomSeedSet; // 0x8B
	[NativeName("startLifetimeSet")]
	private bool m_StartLifetimeSet; // 0x8C
	[NativeName("meshIndexSet")]
	private bool m_MeshIndexSet; // 0x8D
	[NativeName("applyShapeToPosition")]
	private bool m_ApplyShapeToPosition; // 0x8E
}

// Namespace: 
public struct ParticleSystem.LightsModule // TypeDefIndex: 15821
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; }
	public Light light { get; }

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x2FB89A0 Offset: 0x2FB7BA0 VA: 0x182FB89A0
	public bool get_enabled() { }

	// RVA: 0x2FB89F0 Offset: 0x2FB7BF0 VA: 0x182FB89F0
	public Light get_light() { }

	// RVA: 0x2FB8A70 Offset: 0x2FB7C70 VA: 0x182FB8A70
	private static IntPtr get_light_Injected(ref ParticleSystem.LightsModule _unity_self) { }
}

// Namespace: 
public struct ParticleSystem.TrailModule // TypeDefIndex: 15822
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystem.MinMaxCurve widthOverTrail { set; }
	[NativeName("WidthOverTrail")]
	private ParticleSystem.MinMaxCurveBlittable widthOverTrailBlittable { set; }

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x2FB8AC0 Offset: 0x2FB7CC0 VA: 0x182FB8AC0
	public void set_widthOverTrail(ParticleSystem.MinMaxCurve value) { }

	[NativeThrows]
	// RVA: 0x2FB8C00 Offset: 0x2FB7E00 VA: 0x182FB8C00
	private void set_widthOverTrailBlittable(ParticleSystem.MinMaxCurveBlittable value) { }

	// RVA: 0x2FB8C60 Offset: 0x2FB7E60 VA: 0x182FB8C60
	private static void set_widthOverTrailBlittable_Injected(ref ParticleSystem.TrailModule _unity_self, in ParticleSystem.MinMaxCurveBlittable value) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
public sealed class ParticleSystem : Component // TypeDefIndex: 15823
{
	// Properties
	public bool isPlaying { get; }
	public bool isPaused { get; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.LightsModule lights { get; }
	public ParticleSystem.TrailModule trails { get; }

	// Methods

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x2FB4EE0 Offset: 0x2FB40E0 VA: 0x182FB4EE0
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x2FB5100 Offset: 0x2FB4300 VA: 0x182FB5100
	public void Emit(ParticleSystem.Particle particle) { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	// RVA: 0x2FB5120 Offset: 0x2FB4320 VA: 0x182FB5120
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->IsPaused")]
	// RVA: 0x2FB51C0 Offset: 0x2FB43C0 VA: 0x182FB51C0
	public bool get_isPaused() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	// RVA: 0x2FB5260 Offset: 0x2FB4460 VA: 0x182FB5260
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x2FB5340 Offset: 0x2FB4540 VA: 0x182FB5340
	public void Simulate(float t, bool withChildren, bool restart) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	// RVA: 0x2FB5420 Offset: 0x2FB4620 VA: 0x182FB5420
	public void Play(bool withChildren) { }

	// RVA: 0x2FB54D0 Offset: 0x2FB46D0 VA: 0x182FB54D0
	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	// RVA: 0x2FB54E0 Offset: 0x2FB46E0 VA: 0x182FB54E0
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x2FB55A0 Offset: 0x2FB47A0 VA: 0x182FB55A0
	public void Stop(bool withChildren) { }

	// RVA: 0x2FB5650 Offset: 0x2FB4850 VA: 0x182FB5650
	public void Stop() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	// RVA: 0x2FB5660 Offset: 0x2FB4860 VA: 0x182FB5660
	public void Clear(bool withChildren) { }

	// RVA: 0x2FB5710 Offset: 0x2FB4910 VA: 0x182FB5710
	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	// RVA: 0x2FB57B0 Offset: 0x2FB49B0 VA: 0x182FB57B0
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x2FB5860 Offset: 0x2FB4A60 VA: 0x182FB5860
	public bool IsAlive() { }

	[RequiredByNativeCode]
	// RVA: 0x2FB5900 Offset: 0x2FB4B00 VA: 0x182FB5900
	public void Emit(int count) { }

	[NativeName("SyncJobs()->Emit")]
	// RVA: 0x2FB5900 Offset: 0x2FB4B00 VA: 0x182FB5900
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	// RVA: 0x2FB59B0 Offset: 0x2FB4BB0 VA: 0x182FB59B0
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	// RVA: 0x2FB5A70 Offset: 0x2FB4C70 VA: 0x182FB5A70
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public ParticleSystem.LightsModule get_lights() { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x2FB5B20 Offset: 0x2FB4D20 VA: 0x182FB5B20
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FB5B70 Offset: 0x2FB4D70 VA: 0x182FB5B70
	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FB5BC0 Offset: 0x2FB4DC0 VA: 0x182FB5BC0
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x2FB5C50 Offset: 0x2FB4E50 VA: 0x182FB5C50
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x2FB5CB0 Offset: 0x2FB4EB0 VA: 0x182FB5CB0
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x2FB5D20 Offset: 0x2FB4F20 VA: 0x182FB5D20
	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x2FB5D80 Offset: 0x2FB4F80 VA: 0x182FB5D80
	private static bool IsAlive_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x2FB5DE0 Offset: 0x2FB4FE0 VA: 0x182FB5DE0
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x2FB5E40 Offset: 0x2FB5040 VA: 0x182FB5E40
	private static void Emit_Injected(IntPtr _unity_self, in ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x2FB5EB0 Offset: 0x2FB50B0 VA: 0x182FB5EB0
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref ParticleSystem.Particle particle) { }
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode // TypeDefIndex: 15824
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode // TypeDefIndex: 15825
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace // TypeDefIndex: 15826
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior // TypeDefIndex: 15827
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode // TypeDefIndex: 15828
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 15829
{
	// Methods

	[RequiredByNativeCode]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	// RVA: 0x2FB8CC0 Offset: 0x2FB7EC0 VA: 0x182FB8CC0
	public int GetMeshes([Out] Mesh[] meshes) { }

	// RVA: 0x2FB8D90 Offset: 0x2FB7F90 VA: 0x182FB8D90
	private static int GetMeshes_Injected(IntPtr _unity_self, [Out] Mesh[] meshes) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15830
{}

// Namespace: Unity.Burst
public enum OptimizeFor // TypeDefIndex: 15831
{
	// Fields
	public int value__; // 0x0
	public const OptimizeFor Default = 0;
	public const OptimizeFor Performance = 1;
	public const OptimizeFor Size = 2;
	public const OptimizeFor FastCompilation = 3;
	public const OptimizeFor Balanced = 4;
}

// Namespace: Unity.Burst
[Usage(77)]
public class BurstCompileAttribute : Attribute // TypeDefIndex: 15832
{
	// Fields
	internal Nullable<bool> _disableSafetyChecks; // 0x10
	[CompilerGenerated]
	private OptimizeFor <OptimizeFor>k__BackingField; // 0x14

	// Properties
	public bool DisableSafetyChecks { set; }
	public OptimizeFor OptimizeFor { set; }

	// Methods

	// RVA: 0x27DEF50 Offset: 0x27DE150 VA: 0x1827DEF50
	public void set_DisableSafetyChecks(bool value) { }

	[CompilerGenerated]
	// RVA: 0x73C880 Offset: 0x73BA80 VA: 0x18073C880
	public void set_OptimizeFor(OptimizeFor value) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
private class BurstCompiler.FakeDelegate // TypeDefIndex: 15833
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	[Preserve]
	public MethodInfo Method { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public MethodInfo get_Method() { }
}

// Namespace: Unity.Burst
public static class BurstCompiler // TypeDefIndex: 15834
{
	// Fields
	internal static bool _IsEnabled; // 0x0
	public static readonly BurstCompilerOptions Options; // 0x8
	private static readonly MethodInfo DummyMethodInfo; // 0x10

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	private static void DummyMethod() { }

	// RVA: 0x27DEFA0 Offset: 0x27DE1A0 VA: 0x1827DEFA0
	private static void .cctor() { }
}

// Namespace: Unity.Burst
public sealed class BurstCompilerOptions // TypeDefIndex: 15835
{
	// Fields
	internal static readonly bool ForceDisableBurstCompilation; // 0x0
	private static readonly bool ForceBurstCompilationSynchronously; // 0x1
	internal static readonly bool IsSecondaryUnityProcess; // 0x2
	private bool _enableBurstCompilation; // 0x10
	private bool _enableBurstSafetyChecks; // 0x11
	[CompilerGenerated]
	private readonly bool <IsGlobal>k__BackingField; // 0x12
	[CompilerGenerated]
	private Action <OptionsChanged>k__BackingField; // 0x18

	// Properties
	private bool IsGlobal { get; }
	public bool EnableBurstCompilation { set; }
	public bool EnableBurstSafetyChecks { set; }
	internal Action OptionsChanged { get; }

	// Methods

	// RVA: 0x27DF330 Offset: 0x27DE530 VA: 0x1827DF330
	internal void .ctor(bool isGlobal) { }

	[CompilerGenerated]
	// RVA: 0xEFE490 Offset: 0xEFD690 VA: 0x180EFE490
	private bool get_IsGlobal() { }

	// RVA: 0x27DF490 Offset: 0x27DE690 VA: 0x1827DF490
	public void set_EnableBurstCompilation(bool value) { }

	// RVA: 0x27DF5C0 Offset: 0x27DE7C0 VA: 0x1827DF5C0
	public void set_EnableBurstSafetyChecks(bool value) { }

	[CompilerGenerated]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	internal Action get_OptionsChanged() { }

	// RVA: 0x27DF5F0 Offset: 0x27DE7F0 VA: 0x1827DF5F0
	private void OnOptionsChanged() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	private void MaybeTriggerRecompilation() { }

	// RVA: 0x27DF610 Offset: 0x27DE810 VA: 0x1827DF610
	private static void .cctor() { }

	// RVA: 0x442670 Offset: 0x441870 VA: 0x180442670
	private static bool CheckIsSecondaryUnityProcess() { }
}

// Namespace: 
private struct BurstRuntime.HashCode64<T> // TypeDefIndex: 15836
{
	// Fields
	public static readonly long Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21343B0 Offset: 0x21335B0 VA: 0x1821343B0
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMaterialID>>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMeshID>>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<CompactVisibilityMasksJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindDrawInstancesJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindMaterialDrawInstancesJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<GPUResidentDrawer.FindRenderersFromMaterialJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.GetVisibleNonProcessedTreeInstancesJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.ProbesUpdateJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesCountJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesMultiJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QuerySortedMeshInstancesJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.TransformUpdateJob>>..cctor
	|-BurstRuntime.HashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.UpdateCompactedInstanceVisibilityJob>>..cctor
	|-BurstRuntime.HashCode64<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
internal class BurstRuntime.PreserveAttribute : Attribute // TypeDefIndex: 15837
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: Unity.Burst
public static class BurstRuntime // TypeDefIndex: 15838
{
	// Methods

	// RVA: -1 Offset: -1
	public static long GetHashCode64<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B0820 Offset: 0x10AFA20 VA: 0x1810B0820
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMaterialID>>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMeshID>>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<CompactVisibilityMasksJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindDrawInstancesJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindMaterialDrawInstancesJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<GPUResidentDrawer.FindRenderersFromMaterialJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.GetVisibleNonProcessedTreeInstancesJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.ProbesUpdateJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesCountJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesMultiJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QuerySortedMeshInstancesJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.TransformUpdateJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.UpdateCompactedInstanceVisibilityJob>>
	|-BurstRuntime.GetHashCode64<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27DF7F0 Offset: 0x27DE9F0 VA: 0x1827DF7F0
	internal static long HashStringWithFNV1A64(string text) { }

	[Preserve]
	// RVA: 0x27DF880 Offset: 0x27DEA80 VA: 0x1827DF880
	internal static void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber) { }

	[Preserve]
	// RVA: 0x27DF900 Offset: 0x27DEB00 VA: 0x1827DF900
	internal static void PreventRequiredAttributeStrip() { }

	[Preserve]
	// RVA: 0x27DFAB0 Offset: 0x27DECB0 VA: 0x1827DFAB0
	internal static void Log(byte* message, int logType, byte* fileName, int lineNumber) { }
}

// Namespace: 
internal class BurstString.PreserveAttribute : Attribute // TypeDefIndex: 15839
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
private enum BurstString.NumberBufferKind // TypeDefIndex: 15840
{
	// Fields
	public int value__; // 0x0
	public const BurstString.NumberBufferKind Integer = 0;
	public const BurstString.NumberBufferKind Float = 1;
}

// Namespace: 
private struct BurstString.NumberBuffer // TypeDefIndex: 15841
{
	// Fields
	private readonly byte* _buffer; // 0x0
	public BurstString.NumberBufferKind Kind; // 0x8
	public int DigitsCount; // 0xC
	public int Scale; // 0x10
	public readonly bool IsNegative; // 0x14

	// Methods

	// RVA: 0x27E43A0 Offset: 0x27E35A0 VA: 0x1827E43A0
	public void .ctor(BurstString.NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative) { }

	// RVA: 0x516B20 Offset: 0x515D20 VA: 0x180516B20
	public byte* GetDigitsPointer() { }
}

// Namespace: 
public enum BurstString.NumberFormatKind // TypeDefIndex: 15842
{
	// Fields
	public byte value__; // 0x0
	public const BurstString.NumberFormatKind General = 0;
	public const BurstString.NumberFormatKind Decimal = 1;
	public const BurstString.NumberFormatKind DecimalForceSigned = 2;
	public const BurstString.NumberFormatKind Hexadecimal = 3;
}

// Namespace: 
public struct BurstString.FormatOptions // TypeDefIndex: 15843
{
	// Fields
	public BurstString.NumberFormatKind Kind; // 0x0
	public sbyte AlignAndSize; // 0x1
	public byte Specifier; // 0x2
	public bool Lowercase; // 0x3

	// Properties
	public bool Uppercase { get; }

	// Methods

	// RVA: 0x4E2650 Offset: 0x4E1850 VA: 0x1804E2650
	public void .ctor(BurstString.NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) { }

	// RVA: 0x27E43C0 Offset: 0x27E35C0 VA: 0x1827E43C0
	public bool get_Uppercase() { }

	// RVA: 0x27E43D0 Offset: 0x27E35D0 VA: 0x1827E43D0
	public int GetBase() { }

	// RVA: 0x27E43F0 Offset: 0x27E35F0 VA: 0x1827E43F0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct BurstString.tBigInt.<m_blocks>e__FixedBuffer // TypeDefIndex: 15844
{
	// Fields
	public uint FixedElementField; // 0x0
}

// Namespace: 
public struct BurstString.tBigInt // TypeDefIndex: 15845
{
	// Fields
	public int m_length; // 0x0
	[FixedBuffer(typeof(uint), 35)]
	public BurstString.tBigInt.<m_blocks>e__FixedBuffer m_blocks; // 0x4

	// Methods

	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public int GetLength() { }

	// RVA: 0x27E47A0 Offset: 0x27E39A0 VA: 0x1827E47A0
	public uint GetBlock(int idx) { }

	// RVA: 0x27E47B0 Offset: 0x27E39B0 VA: 0x1827E47B0
	public bool IsZero() { }

	// RVA: 0x27E47C0 Offset: 0x27E39C0 VA: 0x1827E47C0
	public void SetU64(ulong val) { }

	// RVA: 0x27E47F0 Offset: 0x27E39F0 VA: 0x1827E47F0
	public void SetU32(uint val) { }
}

// Namespace: 
public enum BurstString.CutoffMode // TypeDefIndex: 15846
{
	// Fields
	public int value__; // 0x0
	public const BurstString.CutoffMode Unique = 0;
	public const BurstString.CutoffMode TotalLength = 1;
	public const BurstString.CutoffMode FractionLength = 2;
}

// Namespace: 
public struct BurstString.tFloatUnion32 // TypeDefIndex: 15847
{
	// Fields
	public float m_floatingPoint; // 0x0
	public uint m_integer; // 0x0

	// Methods

	// RVA: 0x2465170 Offset: 0x2464370 VA: 0x182465170
	public bool IsNegative() { }

	// RVA: 0x27E4810 Offset: 0x27E3A10 VA: 0x1827E4810
	public uint GetExponent() { }

	// RVA: 0x27E4820 Offset: 0x27E3A20 VA: 0x1827E4820
	public uint GetMantissa() { }
}

// Namespace: 
public struct BurstString.tFloatUnion64 // TypeDefIndex: 15848
{
	// Fields
	public double m_floatingPoint; // 0x0
	public ulong m_integer; // 0x0

	// Methods

	// RVA: 0x27E4830 Offset: 0x27E3A30 VA: 0x1827E4830
	public bool IsNegative() { }

	// RVA: 0x27E4850 Offset: 0x27E3A50 VA: 0x1827E4850
	public uint GetExponent() { }

	// RVA: 0x27E4860 Offset: 0x27E3A60 VA: 0x1827E4860
	public ulong GetMantissa() { }
}

// Namespace: Unity.Burst
internal static class BurstString // TypeDefIndex: 15849
{
	// Fields
	private static readonly char[] SplitByColon; // 0x0
	private static readonly byte[] logTable; // 0x8
	private static readonly uint[] g_PowerOf10_U32; // 0x10
	private static readonly byte[] InfinityString; // 0x18
	private static readonly byte[] NanString; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x27DFB30 Offset: 0x27DED30 VA: 0x1827DFB30
	public static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength) { }

	[Preserve]
	// RVA: 0x27DFB60 Offset: 0x27DED60 VA: 0x1827DFB60
	public static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27DFC70 Offset: 0x27DEE70 VA: 0x1827DFC70
	public static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27DFD00 Offset: 0x27DEF00 VA: 0x1827DFD00
	public static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27DFD90 Offset: 0x27DEF90 VA: 0x1827DFD90
	public static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27DFF10 Offset: 0x27DF110 VA: 0x1827DFF10
	public static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E00F0 Offset: 0x27DF2F0 VA: 0x1827E00F0
	public static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E0180 Offset: 0x27DF380 VA: 0x1827E0180
	public static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E0210 Offset: 0x27DF410 VA: 0x1827E0210
	public static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E02A0 Offset: 0x27DF4A0 VA: 0x1827E02A0
	public static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E0330 Offset: 0x27DF530 VA: 0x1827E0330
	public static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E0400 Offset: 0x27DF600 VA: 0x1827E0400
	public static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E04D0 Offset: 0x27DF6D0 VA: 0x1827E04D0
	public static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x27E05A0 Offset: 0x27DF7A0 VA: 0x1827E05A0
	public static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	// RVA: 0x27E0670 Offset: 0x27DF870 VA: 0x1827E0670
	private static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, BurstString.FormatOptions options) { }

	// RVA: 0x27E0830 Offset: 0x27DFA30 VA: 0x1827E0830
	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	// RVA: 0x27E0860 Offset: 0x27DFA60 VA: 0x1827E0860
	private static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, BurstString.FormatOptions options) { }

	// RVA: 0x27E0A20 Offset: 0x27DFC20 VA: 0x1827E0A20
	private static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, BurstString.FormatOptions options) { }

	// RVA: 0x27E0DE0 Offset: 0x27DFFE0 VA: 0x1827E0DE0
	private static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	// RVA: 0x27E0E90 Offset: 0x27E0090 VA: 0x1827E0E90
	private static byte ValueToIntegerChar(int value, bool uppercase) { }

	// RVA: 0x27E0EC0 Offset: 0x27E00C0 VA: 0x1827E0EC0
	private static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	// RVA: 0x27E0F60 Offset: 0x27E0160 VA: 0x1827E0F60
	private static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	// RVA: 0x27E0FA0 Offset: 0x27E01A0 VA: 0x1827E0FA0
	private static int GetLengthForFormatGeneral(ref BurstString.NumberBuffer number, int nMaxDigits) { }

	// RVA: 0x27E10E0 Offset: 0x27E02E0 VA: 0x1827E10E0
	private static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, byte expChar) { }

	// RVA: 0x27E1280 Offset: 0x27E0480 VA: 0x1827E1280
	private static void RoundNumber(ref BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	// RVA: 0x27E13A0 Offset: 0x27E05A0 VA: 0x1827E13A0
	private static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded) { }

	// RVA: 0x27E13D0 Offset: 0x27E05D0 VA: 0x1827E13D0
	private static uint LogBase2(uint val) { }

	// RVA: 0x27E1540 Offset: 0x27E0740 VA: 0x1827E1540
	private static int BigInt_Compare(in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x27E15A0 Offset: 0x27E07A0 VA: 0x1827E15A0
	private static void BigInt_Add(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x27E1630 Offset: 0x27E0830 VA: 0x1827E1630
	private static void BigInt_Add_internal(out BurstString.tBigInt pResult, in BurstString.tBigInt pLarge, in BurstString.tBigInt pSmall) { }

	// RVA: 0x27E1700 Offset: 0x27E0900 VA: 0x1827E1700
	private static void BigInt_Multiply(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x27E1790 Offset: 0x27E0990 VA: 0x1827E1790
	private static void BigInt_Multiply_internal(out BurstString.tBigInt pResult, in BurstString.tBigInt pLarge, in BurstString.tBigInt pSmall) { }

	// RVA: 0x27E1890 Offset: 0x27E0A90 VA: 0x1827E1890
	private static void BigInt_Multiply(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, uint rhs) { }

	// RVA: 0x27E1910 Offset: 0x27E0B10 VA: 0x1827E1910
	private static void BigInt_Multiply2(out BurstString.tBigInt pResult, in BurstString.tBigInt input) { }

	// RVA: 0x27E1980 Offset: 0x27E0B80 VA: 0x1827E1980
	private static void BigInt_Multiply2(ref BurstString.tBigInt pResult) { }

	// RVA: 0x27E19D0 Offset: 0x27E0BD0 VA: 0x1827E19D0
	private static void BigInt_Multiply10(ref BurstString.tBigInt pResult) { }

	// RVA: 0x27E1A10 Offset: 0x27E0C10 VA: 0x1827E1A10
	private static BurstString.tBigInt g_PowerOf10_Big(int i) { }

	// RVA: 0x27E1BE0 Offset: 0x27E0DE0 VA: 0x1827E1BE0
	private static void BigInt_Pow10(out BurstString.tBigInt pResult, uint exponent) { }

	// RVA: 0x27E1E50 Offset: 0x27E1050 VA: 0x1827E1E50
	private static void BigInt_MultiplyPow10(out BurstString.tBigInt pResult, in BurstString.tBigInt input, uint exponent) { }

	// RVA: 0x27E2170 Offset: 0x27E1370 VA: 0x1827E2170
	private static void BigInt_Pow2(out BurstString.tBigInt pResult, uint exponent) { }

	// RVA: 0x27E21D0 Offset: 0x27E13D0 VA: 0x1827E21D0
	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref BurstString.tBigInt pDividend, in BurstString.tBigInt divisor) { }

	// RVA: 0x27E23B0 Offset: 0x27E15B0 VA: 0x1827E23B0
	private static void BigInt_ShiftLeft(ref BurstString.tBigInt pResult, uint shift) { }

	// RVA: 0x27E2550 Offset: 0x27E1750 VA: 0x1827E2550
	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	// RVA: 0x27E38A0 Offset: 0x27E2AA0 VA: 0x1827E38A0
	private static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x27E3A90 Offset: 0x27E2C90 VA: 0x1827E3A90
	private static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x27E3D30 Offset: 0x27E2F30 VA: 0x1827E3D30
	private static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x27E3FF0 Offset: 0x27E31F0 VA: 0x1827E3FF0
	private static void .cctor() { }
}

// Namespace: Unity.Burst
[IsReadOnly]
public struct FunctionPointer<T> // TypeDefIndex: 15850
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	private readonly IntPtr _ptr; // 0x0

	// Properties
	public T Invoke { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70A5F0 Offset: 0x7097F0 VA: 0x18070A5F0
	|-FunctionPointer<object>..ctor
	|-FunctionPointer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x211EB10 Offset: 0x211DD10 VA: 0x18211EB10
	|-FunctionPointer<object>.get_Invoke
	|
	|-RVA: 0x211EC80 Offset: 0x211DE80 VA: 0x18211EC80
	|-FunctionPointer<__Il2CppFullySharedGenericType>.get_Invoke
	*/
}

// Namespace: Unity.Burst
[Usage(10504)]
public class NoAliasAttribute : Attribute // TypeDefIndex: 15851
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: Unity.Burst
[IsReadOnly]
public struct SharedStatic<T> // TypeDefIndex: 15852
{
	// Fields
	private readonly void* _buffer; // 0x0

	// Properties
	public T Data { get; }
	public void* UnsafeDataPointer { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(void* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70A5F0 Offset: 0x7097F0 VA: 0x18070A5F0
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>..ctor
	|-SharedStatic<IntPtr>..ctor
	|-SharedStatic<Long1024>..ctor
	|-SharedStatic<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15518F0 Offset: 0x1550AF0 VA: 0x1815518F0
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.get_Data
	|-SharedStatic<IntPtr>.get_Data
	|-SharedStatic<Long1024>.get_Data
	|
	|-RVA: 0x16CD7C0 Offset: 0x16CC9C0 VA: 0x1816CD7C0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public void* get_UnsafeDataPointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x516B20 Offset: 0x515D20 VA: 0x180516B20
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.get_UnsafeDataPointer
	|-SharedStatic<IntPtr>.get_UnsafeDataPointer
	|-SharedStatic<Long1024>.get_UnsafeDataPointer
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.get_UnsafeDataPointer
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFEA470 Offset: 0xFE9670 VA: 0x180FEA470
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMaterialID>>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindNonRegisteredInstancesJob<BatchMeshID>>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<CompactVisibilityMasksJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindDrawInstancesJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<FindMaterialDrawInstancesJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<GPUResidentDrawer.FindRenderersFromMaterialJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.GetVisibleNonProcessedTreeInstancesJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.ProbesUpdateJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesCountJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QueryRendererGroupInstancesMultiJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.QuerySortedMeshInstancesJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.TransformUpdateJob>>
	|-SharedStatic<IntPtr>.GetOrCreate<IJobParallelForBatchExtensions.JobParallelForBatchProducer<InstanceDataSystem.UpdateCompactedInstanceVisibilityJob>>
	|
	|-RVA: 0xFEA530 Offset: 0xFE9730 VA: 0x180FEA530
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16CD830 Offset: 0x16CCA30 VA: 0x1816CD830
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.GetOrCreateUnsafe
	|
	|-RVA: 0x16CD900 Offset: 0x16CCB00 VA: 0x1816CD900
	|-SharedStatic<IntPtr>.GetOrCreateUnsafe
	|
	|-RVA: 0x16CD9D0 Offset: 0x16CCBD0 VA: 0x1816CD9D0
	|-SharedStatic<Long1024>.GetOrCreateUnsafe
	|
	|-RVA: 0x16CDAA0 Offset: 0x16CCCA0 VA: 0x1816CDAA0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreateUnsafe
	*/
}

// Namespace: 
internal class SharedStatic.PreserveAttribute : Attribute // TypeDefIndex: 15853
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: Unity.Burst
internal static class SharedStatic // TypeDefIndex: 15854
{
	// Methods

	[Preserve]
	// RVA: 0x27E4880 Offset: 0x27E3A80 VA: 0x1827E4880
	public static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }
}

// Namespace: Unity.Burst.Intrinsics
[Usage(64, Inherited = False)]
[Preserve]
internal sealed class BurstTargetCpuAttribute : Attribute // TypeDefIndex: 15855
{}

// Namespace: Unity.Burst.CompilerServices
[Usage(10240)]
public class AssumeRangeAttribute : Attribute // TypeDefIndex: 15856
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor(long min, long max) { }
}

// Namespace: Unity.Burst.CompilerServices
[Usage(64, AllowMultiple = True)]
public class IgnoreWarningAttribute : Attribute // TypeDefIndex: 15857
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor(int warning) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 15858
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 15859
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 15860
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 15861
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA /*Metadata offset 0x7EF698*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C /*Metadata offset 0x7EF7A0*/; // 0x100
	internal static readonly long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010 = 8751735898823355977; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E /*Metadata offset 0x7EF7D8*/; // 0x128
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15862
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 15863
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 15864
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xF8EC50 Offset: 0xF8DE50 VA: 0x180F8EC50
	public void .ctor(byte ) { }

	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 15865
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x490E20 Offset: 0x490020 VA: 0x180490E20
	public void .ctor(byte ) { }
}

// Namespace: 
[CompilerGenerated]
private struct DnsClient.<Query>d__10 : IAsyncStateMachine // TypeDefIndex: 15866
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<DnsResponse> <>t__builder; // 0x8
	[Nullable(0)]
	public DnsClient <>4__this; // 0x20
	[Nullable(0)]
	public string domain; // 0x28
	public QType qType; // 0x30
	public bool acceptTruncated; // 0x32
	[Nullable(new[] { 0, 1 })]
	private TaskAwaiter<DnsResponse> <>u__1; // 0x38

	// Methods

	// RVA: 0xF8FD00 Offset: 0xF8EF00 VA: 0x180F8FD00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0xF90060 Offset: 0xF8F260 VA: 0x180F90060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct DnsClient.<Query>d__11 : IAsyncStateMachine // TypeDefIndex: 15867
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<DnsResponse> <>t__builder; // 0x8
	[Nullable(0)]
	public DnsQuery query; // 0x20
	[Nullable(0)]
	public DnsClient <>4__this; // 0x28
	[Nullable(0)]
	private byte[] <buffer>5__2; // 0x30
	private ushort <transactionId>5__3; // 0x38
	private bool <transactionAdded>5__4; // 0x3A
	[Nullable(0)]
	private DnsQueryStatus <status>5__5; // 0x40
	private ushort <i>5__6; // 0x48
	[Nullable(0)]
	private TaskAwaiter<int> <>u__1; // 0x50
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__2; // 0x58

	// Methods

	// RVA: 0xF900D0 Offset: 0xF8F2D0 VA: 0x180F900D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0xF90F10 Offset: 0xF90110 VA: 0x180F90F10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct DnsClient.<ReceiveLoop>d__14 : IAsyncStateMachine // TypeDefIndex: 15868
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public DnsClient <>4__this; // 0x28
	private CancellationToken <ct>5__2; // 0x30
	[Nullable(0)]
	private TaskAwaiter<UdpReceiveResult> <>u__1; // 0x38

	// Methods

	// RVA: 0xF90F80 Offset: 0xF90180 VA: 0x180F90F80 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x69FC00 Offset: 0x69EE00 VA: 0x18069FC00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: DnsClient
[NullableContext(1)]
[Nullable(0)]
public class DnsClient : IDisposable // TypeDefIndex: 15869
{
	// Fields
	public DnsClientOptions Options; // 0x10
	private readonly UdpClient _socket; // 0x38
	internal static readonly Encoding Encoding; // 0x0
	private readonly ConcurrentDictionary<ushort, DnsQueryStatus> _transactions; // 0x40
	private readonly CancellationTokenSource _ctSource; // 0x48
	private ushort _transactionId; // 0x50
	private readonly object _transactionIdLock; // 0x58

	// Methods

	// RVA: 0xF8ED10 Offset: 0xF8DF10 VA: 0x180F8ED10
	public void .ctor(EndPoint endPoint, Nullable<DnsClientOptions> options) { }

	[AsyncStateMachine(typeof(DnsClient.<Query>d__10))]
	// RVA: 0xF8F340 Offset: 0xF8E540 VA: 0x180F8F340
	public Task<DnsResponse> Query(string domain, QType qType, bool acceptTruncated = False) { }

	[AsyncStateMachine(typeof(DnsClient.<Query>d__11))]
	// RVA: 0xF8F550 Offset: 0xF8E750 VA: 0x180F8F550
	public Task<DnsResponse> Query(DnsQuery query) { }

	[AsyncStateMachine(typeof(DnsClient.<ReceiveLoop>d__14))]
	// RVA: 0xF8F750 Offset: 0xF8E950 VA: 0x180F8F750
	private void ReceiveLoop() { }

	// RVA: 0xF8F920 Offset: 0xF8EB20 VA: 0x180F8F920
	private ushort AssignTransactionId() { }

	// RVA: 0xF8FA70 Offset: 0xF8EC70 VA: 0x180F8FA70
	private ushort AbortTransactionIfExists(ushort transactionId) { }

	// RVA: 0xF8FB70 Offset: 0xF8ED70 VA: 0x180F8FB70 Slot: 4
	public void Dispose() { }

	// RVA: 0xF8FC20 Offset: 0xF8EE20 VA: 0x180F8FC20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xF8FC60 Offset: 0xF8EE60 VA: 0x180F8FC60
	private static void .cctor() { }
}

// Namespace: DnsClient
[NullableContext(2)]
[Nullable(0)]
public struct DnsClientOptions // TypeDefIndex: 15870
{
	// Fields
	public uint Timeout; // 0x0
	public IErrorLogging ErrorLogging; // 0x8
	public bool UseTCPForTruncated; // 0x10
	public EndPoint TCPEndpointOverride; // 0x18
	private int _timeoutInnerDelay; // 0x20
	private ushort _maxAttempts; // 0x24

	// Properties
	public ushort MaxAttempts { get; set; }
	public int TimeoutInnerDelay { get; set; }

	// Methods

	// RVA: 0xF91890 Offset: 0xF90A90 VA: 0x180F91890
	public ushort get_MaxAttempts() { }

	// RVA: 0xF918A0 Offset: 0xF90AA0 VA: 0x180F918A0
	public void set_MaxAttempts(ushort value) { }

	// RVA: 0x4EDA70 Offset: 0x4ECC70 VA: 0x1804EDA70
	public int get_TimeoutInnerDelay() { }

	// RVA: 0xF91920 Offset: 0xF90B20 VA: 0x180F91920
	public void set_TimeoutInnerDelay(int value) { }

	// RVA: 0xF919A0 Offset: 0xF90BA0 VA: 0x180F919A0
	public void .ctor() { }
}

// Namespace: DnsClient.Misc
[NullableContext(1)]
[Nullable(0)]
public static class Misc // TypeDefIndex: 15871
{
	// Methods

	// RVA: 0xF91A70 Offset: 0xF90C70 VA: 0x180F91A70
	internal static string ParseDomain(ArraySegment<byte> data, int startIndex, out int read, byte[] rawResponse) { }

	// RVA: 0xF91DB0 Offset: 0xF90FB0 VA: 0x180F91DB0
	internal static string ParseDomain(byte[] data, int startIndex, out int read, byte[] rawResponse) { }
}

// Namespace: DnsClient.Logging
[NullableContext(1)]
public interface IErrorLogging // TypeDefIndex: 15872
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogError(string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(string message, Exception e);
}

// Namespace: DnsClient.Enums
public enum DnsErrorCode // TypeDefIndex: 15873
{
	// Fields
	public byte value__; // 0x0
	public const DnsErrorCode NoError = 0;
	public const DnsErrorCode FormatError = 1;
	public const DnsErrorCode ServerFailure = 2;
	public const DnsErrorCode NameError = 3;
	public const DnsErrorCode NotImplemented = 4;
	public const DnsErrorCode Refused = 5;
	public const DnsErrorCode NoResponseFromServer = 6;
	public const DnsErrorCode CantParseResponse = 7;
}

// Namespace: DnsClient.Enums
public enum QType // TypeDefIndex: 15874
{
	// Fields
	public ushort value__; // 0x0
	public const QType Unknown = 0;
	public const QType A = 1;
	public const QType NS = 2;
	public const QType CNAME = 5;
	public const QType SOA = 6;
	public const QType PTR = 12;
	public const QType MX = 15;
	public const QType TXT = 16;
	public const QType AAAA = 28;
	public const QType SRV = 33;
	public const QType DS = 43;
	public const QType DNSKEY = 48;
	public const QType URI = 256;
	public const QType CAA = 257;
}

// Namespace: DnsClient.Data
[NullableContext(1)]
[Nullable(0)]
public class DnsQuery // TypeDefIndex: 15875
{
	// Fields
	internal readonly int QueryLength; // 0x10
	private readonly string[] _domain; // 0x18
	private readonly QType[] _type; // 0x20
	internal readonly bool AcceptTruncated; // 0x28

	// Methods

	// RVA: 0xF91FA0 Offset: 0xF911A0 VA: 0x180F91FA0
	public void .ctor(string name, QType type, bool acceptTruncated) { }

	// RVA: 0xF92040 Offset: 0xF91240 VA: 0x180F92040
	public void .ctor(string name, QType[] type, bool acceptTruncated = False) { }

	// RVA: 0xF92340 Offset: 0xF91540 VA: 0x180F92340
	internal void BuildQuery(byte[] buffer, ushort transactionId) { }
}

// Namespace: 
[CompilerGenerated]
private struct DnsQueryStatus.<Wait>d__8 : IAsyncStateMachine // TypeDefIndex: 15876
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public DnsQueryStatus <>4__this; // 0x20
	private CancellationToken <ct>5__2; // 0x28
	private int <timeWaited>5__3; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0xF932E0 Offset: 0xF924E0 VA: 0x180F932E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0xF936F0 Offset: 0xF928F0 VA: 0x180F936F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: DnsClient.Data
[NullableContext(1)]
[Nullable(0)]
internal class DnsQueryStatus // TypeDefIndex: 15877
{
	// Fields
	internal bool IsComplete; // 0x10
	[Nullable(2)]
	internal DnsResponse Response; // 0x18
	private readonly DnsClient _client; // 0x20
	private readonly CancellationTokenSource _ctSource; // 0x28

	// Methods

	// RVA: 0xF92700 Offset: 0xF91900 VA: 0x180F92700
	internal void .ctor(DnsClient client) { }

	// RVA: 0xF92810 Offset: 0xF91A10 VA: 0x180F92810
	internal void Parse(byte[] buffer, int recv, bool tcpUsed = False) { }

	// RVA: 0xF92F60 Offset: 0xF92160 VA: 0x180F92F60
	private void Abort() { }

	// RVA: 0xF92FE0 Offset: 0xF921E0 VA: 0x180F92FE0
	internal void Abort(DnsErrorCode errorCode) { }

	[AsyncStateMachine(typeof(DnsQueryStatus.<Wait>d__8))]
	// RVA: 0xF93150 Offset: 0xF92350 VA: 0x180F93150
	internal Task<bool> Wait() { }
}

// Namespace: DnsClient.Data
public class DnsResponse // TypeDefIndex: 15878
{
	// Fields
	public readonly DnsErrorCode ErrorCode; // 0x10
	public readonly bool Truncated; // 0x11
	public readonly bool TCPUsed; // 0x12
	[Nullable(new[] { 2, 1 })]
	public readonly List<DnsRecord.DNSRecord> Records; // 0x18

	// Methods

	// RVA: 0xF93760 Offset: 0xF92960 VA: 0x180F93760
	internal void .ctor(DnsErrorCode errorCode, bool truncated = False, bool tcpUsed = False, List<DnsRecord.DNSRecord> records) { }
}

// Namespace: 
[NullableContext(0)]
public abstract class DnsRecord.DNSRecord // TypeDefIndex: 15879
{
	// Fields
	public readonly uint TTL; // 0x10

	// Properties
	public abstract QType Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract QType get_Type();

	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	internal void .ctor(uint ttl) { }
}

// Namespace: 
[NullableContext(0)]
public class DnsRecord.UnknownRecord : DnsRecord.DNSRecord // TypeDefIndex: 15880
{
	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x462F00 Offset: 0x462100 VA: 0x180462F00 Slot: 4
	public override QType get_Type() { }

	// RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	internal void .ctor(uint ttl) { }

	[NullableContext(1)]
	// RVA: 0xF93FD0 Offset: 0xF931D0 VA: 0x180F93FD0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public abstract class DnsRecord.IPAddressRecord : DnsRecord.DNSRecord // TypeDefIndex: 15881
{
	// Fields
	public readonly IPAddress Address; // 0x18

	// Methods

	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	protected void .ctor(uint ttl, IPAddress address) { }
}

// Namespace: 
[NullableContext(0)]
public class DnsRecord.ARecord : DnsRecord.IPAddressRecord // TypeDefIndex: 15882
{
	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x4EB0C0 Offset: 0x4EA2C0 VA: 0x1804EB0C0 Slot: 4
	public override QType get_Type() { }

	[NullableContext(1)]
	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, IPAddress address) { }

	// RVA: 0xF94010 Offset: 0xF93210 VA: 0x180F94010
	internal static DnsRecord.ARecord Parse(ArraySegment<byte> data, uint ttl) { }

	[NullableContext(1)]
	// RVA: 0xF94170 Offset: 0xF93370 VA: 0x180F94170 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[NullableContext(0)]
public class DnsRecord.AAAARecord : DnsRecord.IPAddressRecord // TypeDefIndex: 15883
{
	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xA12310 Offset: 0xA11510 VA: 0x180A12310 Slot: 4
	public override QType get_Type() { }

	[NullableContext(1)]
	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, IPAddress address) { }

	// RVA: 0xF94200 Offset: 0xF93400 VA: 0x180F94200
	internal static DnsRecord.AAAARecord Parse(ArraySegment<byte> data, uint ttl) { }

	[NullableContext(1)]
	// RVA: 0xF94360 Offset: 0xF93560 VA: 0x180F94360 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.CNAMERecord : DnsRecord.DNSRecord // TypeDefIndex: 15884
{
	// Fields
	public readonly string Alias; // 0x18

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x522360 Offset: 0x521560 VA: 0x180522360 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, string alias) { }

	// RVA: 0xF943F0 Offset: 0xF935F0 VA: 0x180F943F0
	internal static DnsRecord.CNAMERecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF944D0 Offset: 0xF936D0 VA: 0x180F944D0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.SOARecord : DnsRecord.DNSRecord // TypeDefIndex: 15885
{
	// Fields
	public readonly string PrimaryNameServer; // 0x18
	public readonly string ResponsibleAuthorityMailbox; // 0x20
	public readonly uint SerialNumber; // 0x28
	public readonly uint RefreshInterval; // 0x2C
	public readonly uint RetryInterval; // 0x30
	public readonly uint ExpireLimit; // 0x34
	public readonly uint MinimumTTL; // 0x38

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x51FA20 Offset: 0x51EC20 VA: 0x18051FA20 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF94520 Offset: 0xF93720 VA: 0x180F94520
	private void .ctor(uint ttl, string primaryNameServer, string responsibleAuthorityMailbox, uint serialNumber, uint refreshInterval, uint retryInterval, uint expireLimit, uint minimumTTL) { }

	// RVA: 0xF94600 Offset: 0xF93800 VA: 0x180F94600
	internal static DnsRecord.SOARecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF94BA0 Offset: 0xF93DA0 VA: 0x180F94BA0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.NSRecord : DnsRecord.DNSRecord // TypeDefIndex: 15886
{
	// Fields
	public readonly string NameServer; // 0x18

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x529680 Offset: 0x528880 VA: 0x180529680 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, string nameServer) { }

	// RVA: 0xF950B0 Offset: 0xF942B0 VA: 0x180F950B0
	internal static DnsRecord.NSRecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF95190 Offset: 0xF94390 VA: 0x180F95190 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.PTRRecord : DnsRecord.DNSRecord // TypeDefIndex: 15887
{
	// Fields
	public readonly string DomainName; // 0x18

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xD965E0 Offset: 0xD957E0 VA: 0x180D965E0 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, string domainName) { }

	// RVA: 0xF951E0 Offset: 0xF943E0 VA: 0x180F951E0
	internal static DnsRecord.PTRRecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF952C0 Offset: 0xF944C0 VA: 0x180F952C0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.MXRecord : DnsRecord.DNSRecord // TypeDefIndex: 15888
{
	// Fields
	public readonly string MailExchange; // 0x18
	public readonly ushort Preference; // 0x20

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xF95310 Offset: 0xF94510 VA: 0x180F95310 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF95320 Offset: 0xF94520 VA: 0x180F95320
	private void .ctor(uint ttl, string mailExchange, ushort preference) { }

	// RVA: 0xF95380 Offset: 0xF94580 VA: 0x180F95380
	internal static DnsRecord.MXRecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF95500 Offset: 0xF94700 VA: 0x180F95500 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.TXTRecord : DnsRecord.DNSRecord // TypeDefIndex: 15889
{
	// Fields
	public readonly string Text; // 0x18

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x5C2390 Offset: 0x5C1590 VA: 0x1805C2390 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xD7ED80 Offset: 0xD7DF80 VA: 0x180D7ED80
	private void .ctor(uint ttl, string text) { }

	[NullableContext(0)]
	// RVA: 0xF955B0 Offset: 0xF947B0 VA: 0x180F955B0
	internal static DnsRecord.TXTRecord Parse(ArraySegment<byte> data, uint ttl) { }

	// RVA: 0xF957F0 Offset: 0xF949F0 VA: 0x180F957F0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.SRVRecord : DnsRecord.DNSRecord // TypeDefIndex: 15890
{
	// Fields
	public readonly ushort Priority; // 0x18
	public readonly ushort Weight; // 0x1A
	public readonly ushort Port; // 0x1C
	public readonly string Target; // 0x20

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0x661620 Offset: 0x660820 VA: 0x180661620 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF95840 Offset: 0xF94A40 VA: 0x180F95840
	private void .ctor(uint ttl, ushort priority, ushort weight, ushort port, string target) { }

	// RVA: 0xF958B0 Offset: 0xF94AB0 VA: 0x180F958B0
	internal static DnsRecord.SRVRecord Parse(ArraySegment<byte> data, uint ttl, byte[] raw) { }

	// RVA: 0xF95B20 Offset: 0xF94D20 VA: 0x180F95B20 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.CAARecord : DnsRecord.DNSRecord // TypeDefIndex: 15891
{
	// Fields
	public readonly byte Flags; // 0x18
	public readonly string Tag; // 0x20
	public readonly string Value; // 0x28

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xF95D30 Offset: 0xF94F30 VA: 0x180F95D30 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF95D40 Offset: 0xF94F40 VA: 0x180F95D40
	private void .ctor(uint ttl, byte flags, string tag, string value) { }

	[NullableContext(0)]
	// RVA: 0xF95E00 Offset: 0xF95000 VA: 0x180F95E00
	internal static DnsRecord.CAARecord Parse(ArraySegment<byte> data, uint ttl) { }

	// RVA: 0xF96100 Offset: 0xF95300 VA: 0x180F96100 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.DSRecord : DnsRecord.DNSRecord // TypeDefIndex: 15892
{
	// Fields
	public readonly ushort KeyId; // 0x18
	public readonly byte Algorithm; // 0x1A
	public readonly byte DigestType; // 0x1B
	public readonly byte[] Digest; // 0x20

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xF961C0 Offset: 0xF953C0 VA: 0x180F961C0 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF961D0 Offset: 0xF953D0 VA: 0x180F961D0
	private void .ctor(uint ttl, ushort keyId, byte algorithm, byte digestType, byte[] digest) { }

	[NullableContext(0)]
	// RVA: 0xF96240 Offset: 0xF95440 VA: 0x180F96240
	internal static DnsRecord.DSRecord Parse(ArraySegment<byte> data, uint ttl) { }

	// RVA: 0xF964A0 Offset: 0xF956A0 VA: 0x180F964A0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.DNSKEYRecord : DnsRecord.DNSRecord // TypeDefIndex: 15893
{
	// Fields
	public readonly ushort Flags; // 0x18
	public readonly byte Protocol; // 0x1A
	public readonly byte Algorithm; // 0x1B
	public readonly byte[] PublicKey; // 0x20

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xDF7C30 Offset: 0xDF6E30 VA: 0x180DF7C30 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF961D0 Offset: 0xF953D0 VA: 0x180F961D0
	private void .ctor(uint ttl, ushort flags, byte protocol, byte algorithm, byte[] publicKey) { }

	[NullableContext(0)]
	// RVA: 0xF96880 Offset: 0xF95A80 VA: 0x180F96880
	internal static DnsRecord.DNSKEYRecord Parse(ArraySegment<byte> data, uint ttl) { }

	// RVA: 0xF96AE0 Offset: 0xF95CE0 VA: 0x180F96AE0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Nullable(0)]
public class DnsRecord.URIRecord : DnsRecord.DNSRecord // TypeDefIndex: 15894
{
	// Fields
	public readonly ushort Priority; // 0x18
	public readonly ushort Weight; // 0x1A
	public readonly string Target; // 0x20

	// Properties
	public override QType Type { get; }

	// Methods

	// RVA: 0xF96EC0 Offset: 0xF960C0 VA: 0x180F96EC0 Slot: 4
	public override QType get_Type() { }

	// RVA: 0xF96ED0 Offset: 0xF960D0 VA: 0x180F96ED0
	private void .ctor(uint ttl, ushort priority, ushort weight, string target) { }

	[NullableContext(0)]
	// RVA: 0xF96F40 Offset: 0xF96140 VA: 0x180F96F40
	internal static DnsRecord.URIRecord Parse(ArraySegment<byte> data, uint ttl) { }

	// RVA: 0xF971E0 Offset: 0xF963E0 VA: 0x180F971E0 Slot: 3
	public override string ToString() { }
}

// Namespace: DnsClient.Data.Records
[NullableContext(1)]
[Nullable(0)]
public static class DnsRecord // TypeDefIndex: 15895
{
	// Methods

	[NullableContext(0)]
	// RVA: 0xF937D0 Offset: 0xF929D0 VA: 0x180F937D0
	internal static DnsRecord.DNSRecord Parse(QType type, ArraySegment<byte> data, uint ttl, byte[] rawResponse) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15896
{}

// Namespace: UnityEngine.Accessibility
[RequiredByNativeCode]
[NativeHeader("Modules/Accessibility/Native/AccessibilityAction.h")]
internal sealed class AccessibilityAction : IDisposable // TypeDefIndex: 15897
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<bool> <activated>k__BackingField; // 0x18

	// Properties
	public Func<bool> activated { get; }

	// Methods

	// RVA: 0x2E91560 Offset: 0x2E90760 VA: 0x182E91560 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E91610 Offset: 0x2E90810 VA: 0x182E91610
	private void Dispose(bool disposing) { }

	// RVA: 0x2E91680 Offset: 0x2E90880 VA: 0x182E91680
	private static void Internal_Destroy(IntPtr ptr) { }

	[CompilerGenerated]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public Func<bool> get_activated() { }

	[RequiredByNativeCode]
	// RVA: 0x2E916D0 Offset: 0x2E908D0 VA: 0x182E916D0
	private bool Internal_InvokeActivated() { }
}

// Namespace: 
public struct AccessibilityManager.NotificationContext // TypeDefIndex: 15898
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AccessibilityNotification <notification>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isScreenReaderEnabled>k__BackingField; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <announcement>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wasAnnouncementSuccessful>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityNode <currentNode>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityNode <nextNode>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <fontScale>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isBoldTextEnabled>k__BackingField; // 0x2C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isClosedCaptioningEnabled>k__BackingField; // 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityNotificationContext <nativeContext>k__BackingField; // 0x30

	// Properties
	public AccessibilityNotification notification { get; set; }
	public bool isScreenReaderEnabled { get; set; }
	public string announcement { set; }
	public bool wasAnnouncementSuccessful { set; }
	public AccessibilityNode currentNode { get; set; }
	public AccessibilityNode nextNode { set; }
	public float fontScale { get; set; }
	public bool isBoldTextEnabled { get; set; }
	public bool isClosedCaptioningEnabled { get; set; }
	public AccessibilityNotificationContext nativeContext { set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public AccessibilityNotification get_notification() { }

	[CompilerGenerated]
	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	public void set_notification(AccessibilityNotification value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0xA449D0 Offset: 0xA43BD0 VA: 0x180A449D0
	public bool get_isScreenReaderEnabled() { }

	[CompilerGenerated]
	// RVA: 0xA449E0 Offset: 0xA43BE0 VA: 0x180A449E0
	public void set_isScreenReaderEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x68D880 Offset: 0x68CA80 VA: 0x18068D880
	public void set_announcement(string value) { }

	[CompilerGenerated]
	// RVA: 0x490E20 Offset: 0x490020 VA: 0x180490E20
	public void set_wasAnnouncementSuccessful(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public AccessibilityNode get_currentNode() { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	public void set_currentNode(AccessibilityNode value) { }

	[CompilerGenerated]
	// RVA: 0x49BDD0 Offset: 0x49AFD0 VA: 0x18049BDD0
	public void set_nextNode(AccessibilityNode value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x54FDE0 Offset: 0x54EFE0 VA: 0x18054FDE0
	public float get_fontScale() { }

	[CompilerGenerated]
	// RVA: 0x5556B0 Offset: 0x5548B0 VA: 0x1805556B0
	public void set_fontScale(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x14FD0D0 Offset: 0x14FC2D0 VA: 0x1814FD0D0
	public bool get_isBoldTextEnabled() { }

	[CompilerGenerated]
	// RVA: 0x14FD0E0 Offset: 0x14FC2E0 VA: 0x1814FD0E0
	public void set_isBoldTextEnabled(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x14FD0F0 Offset: 0x14FC2F0 VA: 0x1814FD0F0
	public bool get_isClosedCaptioningEnabled() { }

	[CompilerGenerated]
	// RVA: 0x14FD100 Offset: 0x14FC300 VA: 0x1814FD100
	public void set_isClosedCaptioningEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E92FA0 Offset: 0x2E921A0 VA: 0x182E92FA0
	public void set_nativeContext(AccessibilityNotificationContext value) { }

	// RVA: 0x2E93000 Offset: 0x2E92200 VA: 0x182E93000
	public void .ctor(ref AccessibilityNotificationContext nativeNotification) { }
}

// Namespace: 
private sealed class AccessibilityManager.ExclusiveLock : IDisposable // TypeDefIndex: 15899
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x2E93240 Offset: 0x2E92440 VA: 0x182E93240
	public void .ctor() { }

	// RVA: 0x2E932C0 Offset: 0x2E924C0 VA: 0x182E932C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E93300 Offset: 0x2E92500 VA: 0x182E93300
	private void InternalDispose() { }

	// RVA: 0x2E93390 Offset: 0x2E92590 VA: 0x182E93390 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.Accessibility
[VisibleToOtherModules(new[] { "UnityEditor.AccessibilityModule" })]
[NativeHeader("Modules/Accessibility/Native/AccessibilityManager.h")]
internal static class AccessibilityManager // TypeDefIndex: 15900
{
	// Fields
	internal static Queue<AccessibilityManager.NotificationContext> asyncNotificationContexts; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> screenReaderStatusChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<AccessibilityNode> nodeFocusChanged; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E91710 Offset: 0x2E90910 VA: 0x182E91710
	public static void add_screenReaderStatusChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x2E91880 Offset: 0x2E90A80 VA: 0x182E91880
	public static void remove_screenReaderStatusChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x2E919F0 Offset: 0x2E90BF0 VA: 0x182E919F0
	public static void add_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[CompilerGenerated]
	// RVA: 0x2E91B60 Offset: 0x2E90D60 VA: 0x182E91B60
	public static void remove_nodeFocusChanged(Action<AccessibilityNode> value) { }

	// RVA: 0x2E91CD0 Offset: 0x2E90ED0 VA: 0x182E91CD0
	internal static bool IsScreenReaderEnabled() { }

	// RVA: 0x2E91D20 Offset: 0x2E90F20 VA: 0x182E91D20
	internal static void SendAccessibilityNotification(in AccessibilityNotificationContext context) { }

	[RequiredByNativeCode]
	[VisibleToOtherModules(new[] { "UnityEditor.AccessibilityModule" })]
	// RVA: 0x2E91D70 Offset: 0x2E90F70 VA: 0x182E91D70
	internal static void Internal_Initialize() { }

	[RequiredByNativeCode]
	// RVA: 0x2E91DC0 Offset: 0x2E90FC0 VA: 0x182E91DC0
	private static void Internal_Update() { }

	[RequiredByNativeCode]
	// RVA: 0x2E924C0 Offset: 0x2E916C0 VA: 0x182E924C0
	internal static int[] Internal_GetRootNodeIds() { }

	[RequiredByNativeCode]
	// RVA: 0x2E92790 Offset: 0x2E91990 VA: 0x182E92790
	internal static bool Internal_GetNode(int id, ref AccessibilityNodeData nodeData) { }

	[RequiredByNativeCode]
	// RVA: 0x2E928B0 Offset: 0x2E91AB0 VA: 0x182E928B0
	internal static int Internal_GetNodeIdAt(float x, float y) { }

	[RequiredByNativeCode]
	// RVA: 0x2E92A30 Offset: 0x2E91C30 VA: 0x182E92A30
	internal static void Internal_OnAccessibilityNotificationReceived(ref AccessibilityNotificationContext context) { }

	// RVA: 0x2E92B00 Offset: 0x2E91D00 VA: 0x182E92B00
	internal static void QueueNotification(AccessibilityManager.NotificationContext notification) { }

	// RVA: 0x2E92D00 Offset: 0x2E91F00 VA: 0x182E92D00
	internal static IDisposable GetExclusiveLock() { }

	[ThreadSafe]
	// RVA: 0x2E92DC0 Offset: 0x2E91FC0 VA: 0x182E92DC0
	private static void Lock() { }

	[ThreadSafe]
	// RVA: 0x2E92E10 Offset: 0x2E92010 VA: 0x182E92E10
	private static void Unlock() { }

	// RVA: 0x2E92E60 Offset: 0x2E92060 VA: 0x182E92E60
	private static void .cctor() { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Flags]
public enum AccessibilityRole // TypeDefIndex: 15901
{
	// Fields
	public ushort value__; // 0x0
	public const AccessibilityRole None = 0;
	public const AccessibilityRole Button = 1;
	public const AccessibilityRole Image = 2;
	public const AccessibilityRole StaticText = 4;
	public const AccessibilityRole SearchField = 8;
	public const AccessibilityRole KeyboardKey = 16;
	public const AccessibilityRole Header = 32;
	public const AccessibilityRole TabBar = 64;
	public const AccessibilityRole Slider = 128;
	public const AccessibilityRole Toggle = 256;
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Flags]
public enum AccessibilityState // TypeDefIndex: 15902
{
	// Fields
	public ushort value__; // 0x0
	public const AccessibilityState None = 0;
	public const AccessibilityState Disabled = 1;
	public const AccessibilityState Selected = 2;
}

// Namespace: UnityEngine.Accessibility
[RequiredByNativeCode]
[NativeType(1, "MonoAccessibilityNodeData")]
[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
internal struct AccessibilityNodeData // TypeDefIndex: 15903
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isActive>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <label>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <value>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <hint>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AccessibilityRole <role>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <allowsDirectInteraction>k__BackingField; // 0x22
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityState <state>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Rect <frame>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <parentId>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int[] <childIds>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <isFocused>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SystemLanguage <language>k__BackingField; // 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <implementsSelected>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <implementsDismissed>k__BackingField; // 0x51

	// Properties
	public int id { set; }
	public bool isActive { set; }
	public string label { set; }
	public string value { set; }
	public string hint { set; }
	public AccessibilityRole role { set; }
	public bool allowsDirectInteraction { set; }
	public AccessibilityState state { set; }
	public Rect frame { set; }
	public int parentId { set; }
	public int[] childIds { set; }
	internal SystemLanguage language { set; }
	public bool implementsSelected { set; }
	public bool implementsDismissed { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	public void set_id(int value) { }

	[CompilerGenerated]
	// RVA: 0xA449E0 Offset: 0xA43BE0 VA: 0x180A449E0
	public void set_isActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x68D880 Offset: 0x68CA80 VA: 0x18068D880
	public void set_label(string value) { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_value(string value) { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	public void set_hint(string value) { }

	[CompilerGenerated]
	// RVA: 0x666480 Offset: 0x665680 VA: 0x180666480
	public void set_role(AccessibilityRole value) { }

	[CompilerGenerated]
	// RVA: 0x52F480 Offset: 0x52E680 VA: 0x18052F480
	public void set_allowsDirectInteraction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E933F0 Offset: 0x2E925F0 VA: 0x182E933F0
	public void set_state(AccessibilityState value) { }

	[CompilerGenerated]
	// RVA: 0x2443E40 Offset: 0x2443040 VA: 0x182443E40
	public void set_frame(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x7FFD30 Offset: 0x7FEF30 VA: 0x1807FFD30
	public void set_parentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x5189F0 Offset: 0x517BF0 VA: 0x1805189F0
	public void set_childIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x6AB370 Offset: 0x6AA570 VA: 0x1806AB370
	internal void set_language(SystemLanguage value) { }

	[CompilerGenerated]
	// RVA: 0x6518A0 Offset: 0x650AA0 VA: 0x1806518A0
	public void set_implementsSelected(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E93400 Offset: 0x2E92600 VA: 0x182E93400
	public void set_implementsDismissed(bool value) { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
internal static class AccessibilityNodeManager // TypeDefIndex: 15904
{
	// Methods

	// RVA: 0x2E93410 Offset: 0x2E92610 VA: 0x182E93410
	internal static void DestroyNativeNode(int id, int parentId) { }

	// RVA: 0x2E93470 Offset: 0x2E92670 VA: 0x182E93470
	internal static void SetFrame(int id, Rect frame) { }

	// RVA: 0x2E934D0 Offset: 0x2E926D0 VA: 0x182E934D0
	internal static void SetChildren(int id, int[] childIds) { }

	// RVA: 0x2E935B0 Offset: 0x2E927B0 VA: 0x182E935B0
	internal static void SetActions(int id, AccessibilityAction[] actions) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93610 Offset: 0x2E92810 VA: 0x182E93610
	internal static void Internal_InvokeFocusChanged(int id, bool isNodeFocused) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93890 Offset: 0x2E92A90 VA: 0x182E93890
	internal static bool Internal_InvokeSelected(int id) { }

	[RequiredByNativeCode]
	// RVA: 0x2E939B0 Offset: 0x2E92BB0 VA: 0x182E939B0
	internal static void Internal_InvokeIncremented(int id) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93AC0 Offset: 0x2E92CC0 VA: 0x182E93AC0
	internal static void Internal_InvokeDecremented(int id) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93BD0 Offset: 0x2E92DD0 VA: 0x182E93BD0
	internal static bool Internal_InvokeDismissed(int id) { }

	// RVA: 0x2E93CF0 Offset: 0x2E92EF0 VA: 0x182E93CF0
	private static void SetFrame_Injected(int id, in Rect frame) { }

	// RVA: 0x2E93D50 Offset: 0x2E92F50 VA: 0x182E93D50
	private static void SetChildren_Injected(int id, ref ManagedSpanWrapper childIds) { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNotificationContext.h")]
internal enum AccessibilityNotification // TypeDefIndex: 15905
{
	// Fields
	public int value__; // 0x0
	public const AccessibilityNotification None = 0;
	public const AccessibilityNotification Announcement = 1;
	public const AccessibilityNotification AnnouncementFinished = 2;
	public const AccessibilityNotification ScreenReaderStatusChanged = 3;
	public const AccessibilityNotification ScreenChanged = 4;
	public const AccessibilityNotification LayoutChanged = 5;
	public const AccessibilityNotification PageScrolled = 6;
	public const AccessibilityNotification ElementFocused = 7;
	public const AccessibilityNotification ElementUnfocused = 8;
	public const AccessibilityNotification FontScaleChanged = 9;
	public const AccessibilityNotification BoldTextStatusChanged = 10;
	public const AccessibilityNotification ClosedCaptioningStatusChanged = 11;
}

// Namespace: UnityEngine.Accessibility
[RequiredByNativeCode]
[NativeType(1, "MonoAccessibilityNotificationContext")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNotificationContext.h")]
[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNotificationContext.bindings.h")]
internal struct AccessibilityNotificationContext // TypeDefIndex: 15906
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityNotification <notification>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <isScreenReaderEnabled>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <announcement>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <wasAnnouncementSuccessful>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <currentNodeId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <nextNodeId>k__BackingField; // 0x18

	// Properties
	public AccessibilityNotification notification { get; set; }
	public bool isScreenReaderEnabled { get; }
	public string announcement { get; }
	public bool wasAnnouncementSuccessful { get; }
	public int currentNodeId { get; }
	public int nextNodeId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public AccessibilityNotification get_notification() { }

	[CompilerGenerated]
	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	public void set_notification(AccessibilityNotification value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0xA449D0 Offset: 0xA43BD0 VA: 0x180A449D0
	public bool get_isScreenReaderEnabled() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5C0480 Offset: 0x5BF680 VA: 0x1805C0480
	public string get_announcement() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4F30C0 Offset: 0x4F22C0 VA: 0x1804F30C0
	public bool get_wasAnnouncementSuccessful() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x73C870 Offset: 0x73BA70 VA: 0x18073C870
	public int get_currentNodeId() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510
	public int get_nextNodeId() { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_nextNodeId(int value) { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilitySettings.h")]
public static class AccessibilitySettings // TypeDefIndex: 15907
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<float> fontScaleChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> boldTextStatusChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> closedCaptioningStatusChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2E93DB0 Offset: 0x2E92FB0 VA: 0x182E93DB0
	private static void Internal_OnFontScaleChanged(float newFontScale) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93E70 Offset: 0x2E93070 VA: 0x182E93E70
	private static void Internal_OnBoldTextStatusChanged(bool enabled) { }

	[RequiredByNativeCode]
	// RVA: 0x2E93F20 Offset: 0x2E93120 VA: 0x182E93F20
	private static void Internal_OnClosedCaptioningStatusChanged(bool enabled) { }

	// RVA: 0x2E93FD0 Offset: 0x2E931D0 VA: 0x182E93FD0
	internal static void InvokeFontScaleChanged(float newFontScale) { }

	// RVA: 0x2E94030 Offset: 0x2E93230 VA: 0x182E94030
	internal static void InvokeBoldTextStatusChanged(bool enabled) { }

	// RVA: 0x2E94090 Offset: 0x2E93290 VA: 0x182E94090
	internal static void InvokeClosedCaptionStatusChanged(bool enabled) { }
}

// Namespace: 
internal class AssistiveSupport.NotificationDispatcher : IAccessibilityNotificationDispatcher // TypeDefIndex: 15908
{
	// Methods

	// RVA: 0x2E94990 Offset: 0x2E93B90 VA: 0x182E94990
	private static void Send(in AccessibilityNotificationContext context) { }

	// RVA: 0x2E94A20 Offset: 0x2E93C20 VA: 0x182E94A20 Slot: 4
	public void SendScreenChanged(AccessibilityNode nodeToFocus) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Accessibility
public static class AssistiveSupport // TypeDefIndex: 15909
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<AccessibilityNode> nodeFocusChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> screenReaderStatusChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <isScreenReaderEnabled>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField; // 0x18
	private static ServiceManager s_ServiceManager; // 0x20

	// Properties
	public static bool isScreenReaderEnabled { get; set; }
	public static IAccessibilityNotificationDispatcher notificationDispatcher { get; }
	public static AccessibilityHierarchy activeHierarchy { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E940F0 Offset: 0x2E932F0 VA: 0x182E940F0
	public static bool get_isScreenReaderEnabled() { }

	[CompilerGenerated]
	// RVA: 0x2E94150 Offset: 0x2E93350 VA: 0x182E94150
	private static void set_isScreenReaderEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E941B0 Offset: 0x2E933B0 VA: 0x182E941B0
	public static IAccessibilityNotificationDispatcher get_notificationDispatcher() { }

	// RVA: 0x2E94210 Offset: 0x2E93410 VA: 0x182E94210
	internal static void Initialize() { }

	// RVA: -1 Offset: -1
	internal static T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A75C0 Offset: 0x10A67C0 VA: 0x1810A75C0
	|-AssistiveSupport.GetService<object>
	|
	|-RVA: 0x10A7660 Offset: 0x10A6860 VA: 0x1810A7660
	|-AssistiveSupport.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E946F0 Offset: 0x2E938F0 VA: 0x182E946F0
	private static void ScreenReaderStatusChanged(bool screenReaderEnabled) { }

	// RVA: 0x2E947E0 Offset: 0x2E939E0 VA: 0x182E947E0
	private static void NodeFocusChanged(AccessibilityNode currentNode) { }

	// RVA: 0x2E94860 Offset: 0x2E93A60 VA: 0x182E94860
	public static AccessibilityHierarchy get_activeHierarchy() { }

	// RVA: 0x2E948D0 Offset: 0x2E93AD0 VA: 0x182E948D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Accessibility
public class AccessibilityHierarchy // TypeDefIndex: 15910
{
	// Fields
	internal List<AccessibilityNode> m_RootNodes; // 0x10
	private readonly IDictionary<int, AccessibilityNode> m_Nodes; // 0x18

	// Methods

	// RVA: 0x2E94AE0 Offset: 0x2E93CE0 VA: 0x182E94AE0
	public bool TryGetNode(int id, out AccessibilityNode node) { }

	// RVA: 0x2E94BC0 Offset: 0x2E93DC0 VA: 0x182E94BC0
	internal void FreeNative() { }

	// RVA: 0x2E94D20 Offset: 0x2E93F20 VA: 0x182E94D20
	public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node) { }

	[CompilerGenerated]
	// RVA: 0x2E94D90 Offset: 0x2E93F90 VA: 0x182E94D90
	internal static AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|27_0(IList<AccessibilityNode> nodes, Vector2 pos) { }
}

// Namespace: 
[DefaultMember("Item")]
private class AccessibilityNode.ObservableList<T> // TypeDefIndex: 15911
{
	// Fields
	private readonly List<T> m_Items; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action listChanged; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC0FEA0 Offset: 0xC0F0A0 VA: 0x180C0FEA0
	|-AccessibilityNode.ObservableList<object>.get_Count
	|
	|-RVA: 0x15CC450 Offset: 0x15CB650 VA: 0x1815CC450
	|-AccessibilityNode.ObservableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15CC150 Offset: 0x15CB350 VA: 0x1815CC150
	|-AccessibilityNode.ObservableList<object>.get_Item
	|
	|-RVA: 0x15CC480 Offset: 0x15CB680 VA: 0x1815CC480
	|-AccessibilityNode.ObservableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15CC1A0 Offset: 0x15CB3A0 VA: 0x1815CC1A0
	|-AccessibilityNode.ObservableList<object>.GetEnumerator
	|
	|-RVA: 0x15CC550 Offset: 0x15CB750 VA: 0x1815CC550
	|-AccessibilityNode.ObservableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_listChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15CC270 Offset: 0x15CB470 VA: 0x1815CC270
	|-AccessibilityNode.ObservableList<object>.add_listChanged
	|
	|-RVA: 0x15CC600 Offset: 0x15CB800 VA: 0x1815CC600
	|-AccessibilityNode.ObservableList<__Il2CppFullySharedGenericType>.add_listChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_listChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15CC360 Offset: 0x15CB560 VA: 0x1815CC360
	|-AccessibilityNode.ObservableList<object>.remove_listChanged
	|
	|-RVA: 0x15CC6F0 Offset: 0x15CB8F0 VA: 0x1815CC6F0
	|-AccessibilityNode.ObservableList<__Il2CppFullySharedGenericType>.remove_listChanged
	*/
}

// Namespace: UnityEngine.Accessibility
public class AccessibilityNode // TypeDefIndex: 15912
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <id>k__BackingField; // 0x10
	private Func<Rect> m_FrameGetter; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<AccessibilityNode, bool> focusChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<bool> selected; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action incremented; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action decremented; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<bool> dismissed; // 0x40
	private string m_Label; // 0x48
	private string m_Value; // 0x50
	private string m_Hint; // 0x58
	private bool m_IsActive; // 0x60
	private AccessibilityRole m_Role; // 0x62
	private bool m_AllowsDirectInteraction; // 0x64
	private AccessibilityState m_State; // 0x66
	private AccessibilityNode m_Parent; // 0x68
	private AccessibilityNode.ObservableList<AccessibilityNode> m_Children; // 0x70
	private AccessibilityNode.ObservableList<AccessibilityAction> m_Actions; // 0x78
	private Rect m_Frame; // 0x80
	private SystemLanguage m_Language; // 0x90
	private AccessibilityHierarchy m_Hierarchy; // 0x98

	// Properties
	public int id { get; }
	public string label { get; }
	public string value { get; }
	public string hint { get; }
	public bool isActive { get; }
	public AccessibilityRole role { get; }
	public bool allowsDirectInteraction { get; }
	public AccessibilityState state { get; }
	public AccessibilityNode parent { get; }
	internal IList<AccessibilityNode> childList { get; }
	public Rect frame { get; }
	public Func<Rect> frameGetter { get; }
	internal SystemLanguage language { get; }

	// Methods

	// RVA: 0x2E94F70 Offset: 0x2E94170 VA: 0x182E94F70
	internal void FreeNative(bool freeChildren) { }

	[CompilerGenerated]
	// RVA: 0x4B8C80 Offset: 0x4B7E80 VA: 0x1804B8C80
	public int get_id() { }

	// RVA: 0x49AC10 Offset: 0x499E10 VA: 0x18049AC10
	public string get_label() { }

	// RVA: 0x51A280 Offset: 0x519480 VA: 0x18051A280
	public string get_value() { }

	// RVA: 0x51A2F0 Offset: 0x5194F0 VA: 0x18051A2F0
	public string get_hint() { }

	// RVA: 0x596FE0 Offset: 0x5961E0 VA: 0x180596FE0
	public bool get_isActive() { }

	// RVA: 0x2E954C0 Offset: 0x2E946C0 VA: 0x182E954C0
	public AccessibilityRole get_role() { }

	// RVA: 0x55CB40 Offset: 0x55BD40 VA: 0x18055CB40
	public bool get_allowsDirectInteraction() { }

	// RVA: 0x2E954D0 Offset: 0x2E946D0 VA: 0x182E954D0
	public AccessibilityState get_state() { }

	// RVA: 0x51A3D0 Offset: 0x5195D0 VA: 0x18051A3D0
	public AccessibilityNode get_parent() { }

	// RVA: 0x4BFFE0 Offset: 0x4BF1E0 VA: 0x1804BFFE0
	internal IList<AccessibilityNode> get_childList() { }

	// RVA: 0x2E954E0 Offset: 0x2E946E0 VA: 0x182E954E0
	public Rect get_frame() { }

	// RVA: 0x2E95650 Offset: 0x2E94850 VA: 0x182E95650
	private void SetFrame(Rect frame) { }

	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public Func<Rect> get_frameGetter() { }

	// RVA: 0x2E95720 Offset: 0x2E94920 VA: 0x182E95720
	internal void CalculateFrame() { }

	// RVA: 0x5A7B00 Offset: 0x5A6D00 VA: 0x1805A7B00
	internal SystemLanguage get_language() { }

	// RVA: 0x2E95810 Offset: 0x2E94A10 VA: 0x182E95810
	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	// RVA: 0x2E95B70 Offset: 0x2E94D70 VA: 0x182E95B70
	private void ChildrenChanged() { }

	// RVA: 0x2E95DB0 Offset: 0x2E94FB0 VA: 0x182E95DB0
	private void ActionsChanged() { }

	// RVA: 0x2E95F90 Offset: 0x2E95190 VA: 0x182E95F90
	private bool IsInActiveHierarchy() { }

	// RVA: 0x2E96000 Offset: 0x2E95200 VA: 0x182E96000
	internal void NotifyFocusChanged(bool isNodeFocused) { }

	// RVA: 0x2E96170 Offset: 0x2E95370 VA: 0x182E96170
	internal void InvokeFocusChanged(bool isNodeFocused) { }

	// RVA: 0x2E96190 Offset: 0x2E95390 VA: 0x182E96190
	internal bool InvokeSelected() { }

	// RVA: 0x21E9DF0 Offset: 0x21E8FF0 VA: 0x1821E9DF0
	internal void InvokeIncremented() { }

	// RVA: 0x21E9E10 Offset: 0x21E9010 VA: 0x1821E9E10
	internal void InvokeDecremented() { }

	// RVA: 0x2E961D0 Offset: 0x2E953D0 VA: 0x182E961D0
	internal bool Dismissed() { }
}

// Namespace: UnityEngine.Accessibility
public interface IAccessibilityNotificationDispatcher // TypeDefIndex: 15913
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendScreenChanged(AccessibilityNode nodeToFocus);
}

// Namespace: UnityEngine.Accessibility
internal class AccessibilityHierarchyService : IService // TypeDefIndex: 15914
{
	// Fields
	private AccessibilityHierarchy m_Hierarchy; // 0x10

	// Properties
	internal AccessibilityHierarchy hierarchy { get; }

	// Methods

	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	internal AccessibilityHierarchy get_hierarchy() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 5
	public void Start() { }

	// RVA: 0x2E96210 Offset: 0x2E95410 VA: 0x182E96210 Slot: 4
	public void Stop() { }

	// RVA: 0x2E96230 Offset: 0x2E95430 VA: 0x182E96230
	private void RemoveActiveHierarchy(bool notifyScreenChanged) { }

	// RVA: 0x2E963D0 Offset: 0x2E955D0 VA: 0x182E963D0
	internal bool TryGetNode(int id, out AccessibilityNode node) { }

	// RVA: 0x2E96450 Offset: 0x2E95650 VA: 0x182E96450
	internal List<AccessibilityNode> GetRootNodes() { }

	// RVA: 0x2E96470 Offset: 0x2E95670 VA: 0x182E96470
	internal bool TryGetNodeAt(float x, float y, out AccessibilityNode node) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Accessibility
internal interface IService // TypeDefIndex: 15915
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Stop();
}

// Namespace: UnityEngine.Accessibility
internal class ServiceManager // TypeDefIndex: 15916
{
	// Fields
	private readonly IDictionary<Type, IService> m_Services; // 0x10

	// Methods

	// RVA: 0x2E96580 Offset: 0x2E95780 VA: 0x182E96580
	public void .ctor() { }

	// RVA: -1 Offset: -1
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD3F0 Offset: 0x11BC5F0 VA: 0x1811BD3F0
	|-ServiceManager.GetService<object>
	|
	|-RVA: 0x11BD5D0 Offset: 0x11BC7D0 VA: 0x1811BD5D0
	|-ServiceManager.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void StopService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD910 Offset: 0x11BCB10 VA: 0x1811BD910
	|-ServiceManager.StopService<object>
	|
	|-RVA: 0x11BDA00 Offset: 0x11BCC00 VA: 0x1811BDA00
	|-ServiceManager.StopService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E96730 Offset: 0x2E95930 VA: 0x182E96730
	private void UpdateServices(bool isScreenReaderEnabled) { }

	// RVA: 0x2E969F0 Offset: 0x2E95BF0 VA: 0x182E969F0
	protected void ScreenReaderStatusChanged(bool isScreenReaderEnabled) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15917
{}

// Namespace: 
private enum InputTracking.TrackingStateEventType // TypeDefIndex: 15918
{
	// Fields
	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[NativeConditional("ENABLE_VR")]
[StaticAccessor("XRInputTrackingFacade::Get()", 0)]
public static class InputTracking // TypeDefIndex: 15919
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> trackingLost; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x311D7F0 Offset: 0x311C9F0 VA: 0x18311D7F0
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }
}

// Namespace: UnityEngine.XR
public enum XRNode // TypeDefIndex: 15920
{
	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;
}

// Namespace: UnityEngine.XR
[Flags]
internal enum AvailableTrackingData // TypeDefIndex: 15921
{
	// Fields
	public int value__; // 0x0
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
public struct XRNodeState // TypeDefIndex: 15922
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x311D9B0 Offset: 0x311CBB0 VA: 0x18311D9B0
	public void set_uniqueID(ulong value) { }

	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	public void set_nodeType(XRNode value) { }

	// RVA: 0x311D9C0 Offset: 0x311CBC0 VA: 0x18311D9C0
	public void set_tracked(bool value) { }
}

// Namespace: UnityEngine.XR
internal enum InputFeatureType // TypeDefIndex: 15923
{
	// Fields
	public uint value__; // 0x0
	public const InputFeatureType Custom = 0;
	public const InputFeatureType Binary = 1;
	public const InputFeatureType DiscreteStates = 2;
	public const InputFeatureType Axis1D = 3;
	public const InputFeatureType Axis2D = 4;
	public const InputFeatureType Axis3D = 5;
	public const InputFeatureType Rotation = 6;
	public const InputFeatureType Hand = 7;
	public const InputFeatureType Bone = 8;
	public const InputFeatureType Eyes = 9;
	public const InputFeatureType kUnityXRInputFeatureTypeInvalid = 4294967295;
}

// Namespace: UnityEngine.XR
internal enum ConnectionChangeType // TypeDefIndex: 15924
{
	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 15925
{
	// Fields
	internal string m_Name; // 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x114A090 Offset: 0x1149290 VA: 0x18114A090
	public string get_name() { }

	// RVA: 0x14FE8A0 Offset: 0x14FDAA0 VA: 0x1814FE8A0
	internal InputFeatureType get_internalType() { }

	// RVA: 0x311D9D0 Offset: 0x311CBD0 VA: 0x18311D9D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311DAD0 Offset: 0x311CCD0 VA: 0x18311DAD0 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x311DB40 Offset: 0x311CD40 VA: 0x18311DB40 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 15926
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x311DB80 Offset: 0x311CD80 VA: 0x18311DB80
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x311DB90 Offset: 0x311CD90 VA: 0x18311DB90
	private ulong get_deviceId() { }

	// RVA: 0x311DBB0 Offset: 0x311CDB0 VA: 0x18311DBB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311DC60 Offset: 0x311CE60 VA: 0x18311DC60 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x311DC90 Offset: 0x311CE90 VA: 0x18311DC90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
public struct Hand : IEquatable<Hand> // TypeDefIndex: 15927
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x114A090 Offset: 0x1149290 VA: 0x18114A090
	internal ulong get_deviceId() { }

	// RVA: 0x14FE8A0 Offset: 0x14FDAA0 VA: 0x1814FE8A0
	internal uint get_featureIndex() { }

	// RVA: 0x311DCC0 Offset: 0x311CEC0 VA: 0x18311DCC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311DD70 Offset: 0x311CF70 VA: 0x18311DD70 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x311DD90 Offset: 0x311CF90 VA: 0x18311DD90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 15928
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x114A090 Offset: 0x1149290 VA: 0x18114A090
	internal ulong get_deviceId() { }

	// RVA: 0x14FE8A0 Offset: 0x14FDAA0 VA: 0x1814FE8A0
	internal uint get_featureIndex() { }

	// RVA: 0x311DDB0 Offset: 0x311CFB0 VA: 0x18311DDB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311DD70 Offset: 0x311CF70 VA: 0x18311DD70 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x311DD90 Offset: 0x311CF90 VA: 0x18311DD90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeConditional("ENABLE_VR")]
[RequiredByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
public struct Bone : IEquatable<Bone> // TypeDefIndex: 15929
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x114A090 Offset: 0x1149290 VA: 0x18114A090
	internal ulong get_deviceId() { }

	// RVA: 0x14FE8A0 Offset: 0x14FDAA0 VA: 0x1814FE8A0
	internal uint get_featureIndex() { }

	// RVA: 0x311DE60 Offset: 0x311D060 VA: 0x18311DE60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311DD70 Offset: 0x311CF70 VA: 0x18311DD70 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x311DD90 Offset: 0x311CF90 VA: 0x18311DD90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UsedByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeConditional("ENABLE_VR")]
public class InputDevices // TypeDefIndex: 15930
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x311DF10 Offset: 0x311D110 VA: 0x18311DF10
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 15931
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool hasMotionVectorPass; // 0x6C
	public RenderTargetIdentifier motionVectorRenderTarget; // 0x70
	public RenderTextureDescriptor motionVectorRenderTargetDesc; // 0x98
	public bool shouldFillOutDepth; // 0xCC
	public int cullingPassIndex; // 0xD0
	public IntPtr foveatedRenderingInfo; // 0xD8
}

// Namespace: 
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRBlitParams // TypeDefIndex: 15932
{
	// Fields
	public RenderTexture srcTex; // 0x0
	public int srcTexArraySlice; // 0x8
	public Rect srcRect; // 0xC
	public Rect destRect; // 0x1C
	public IntPtr foveatedRenderingInfo; // 0x30
	public bool srcHdrEncoded; // 0x38
	public ColorGamut srcHdrColorGamut; // 0x3C
	public int srcHdrMaxLuminance; // 0x40
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 15933
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 15934
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged; // 0x20

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2EB1EE0 Offset: 0x2EB10E0 VA: 0x182EB1EE0
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x311DFE0 Offset: 0x311D1E0 VA: 0x18311DFE0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 15935
{
	// Methods

	// RVA: 0x311E010 Offset: 0x311D210 VA: 0x18311E010
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 15936
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x311E040 Offset: 0x311D240 VA: 0x18311E040
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x311E100 Offset: 0x311D300 VA: 0x18311E100
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x311E1C0 Offset: 0x311D3C0 VA: 0x18311E1C0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 15937
{
	// Methods

	// RVA: 0x311E1F0 Offset: 0x311D3F0 VA: 0x18311E1F0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 15938
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private ulong m_SubId1; // 0x0
	private ulong m_SubId2; // 0x8

	// Methods

	// RVA: 0x311E220 Offset: 0x311D420 VA: 0x18311E220 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F05C50 Offset: 0x2F04E50 VA: 0x182F05C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x311E2E0 Offset: 0x311D4E0 VA: 0x18311E2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F05D50 Offset: 0x2F04F50 VA: 0x182F05D50 Slot: 4
	public bool Equals(MeshId other) { }

	// RVA: 0x311E390 Offset: 0x311D590 VA: 0x18311E390
	private static void .cctor() { }
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public enum MeshGenerationStatus // TypeDefIndex: 15939
{
	// Fields
	public int value__; // 0x0
	public const MeshGenerationStatus Success = 0;
	public const MeshGenerationStatus InvalidMeshId = 1;
	public const MeshGenerationStatus GenerationAlreadyInProgress = 2;
	public const MeshGenerationStatus Canceled = 3;
	public const MeshGenerationStatus UnknownError = 4;
}

// Namespace: UnityEngine.XR
internal static class HashCodeHelper // TypeDefIndex: 15940
{
	// Methods

	// RVA: 0x311E3D0 Offset: 0x311D5D0 VA: 0x18311E3D0
	public static int Combine(int hash1, int hash2) { }

	// RVA: 0x311E3E0 Offset: 0x311D5E0 VA: 0x18311E3E0
	public static int Combine(int hash1, int hash2, int hash3) { }

	// RVA: 0x311E400 Offset: 0x311D600 VA: 0x18311E400
	public static int Combine(int hash1, int hash2, int hash3, int hash4) { }

	// RVA: 0x311E420 Offset: 0x311D620 VA: 0x18311E420
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) { }

	// RVA: 0x311E450 Offset: 0x311D650 VA: 0x18311E450
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) { }

	// RVA: 0x311E490 Offset: 0x311D690 VA: 0x18311E490
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) { }

	// RVA: 0x311E4D0 Offset: 0x311D6D0 VA: 0x18311E4D0
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) { }
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 15941
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <Timestamp>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector3 <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Quaternion <Rotation>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Scale>k__BackingField; // 0x4C

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Scale { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x11420C0 Offset: 0x11412C0 VA: 0x1811420C0
	public MeshId get_MeshId() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public Mesh get_Mesh() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public MeshCollider get_MeshCollider() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EDA70 Offset: 0x4ECC70 VA: 0x1804EDA70
	public MeshGenerationStatus get_Status() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x670820 Offset: 0x66FA20 VA: 0x180670820
	public MeshVertexAttributes get_Attributes() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x28D6FF0 Offset: 0x28D61F0 VA: 0x1828D6FF0
	public Vector3 get_Position() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0xBBF390 Offset: 0xBBE590 VA: 0x180BBF390
	public Quaternion get_Rotation() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x311E520 Offset: 0x311D720 VA: 0x18311E520
	public Vector3 get_Scale() { }

	// RVA: 0x311E540 Offset: 0x311D740 VA: 0x18311E540 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x311E610 Offset: 0x311D810 VA: 0x18311E610 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x311E7D0 Offset: 0x311D9D0 VA: 0x18311E7D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[Flags]
public enum MeshVertexAttributes // TypeDefIndex: 15942
{
	// Fields
	public int value__; // 0x0
	public const MeshVertexAttributes None = 0;
	public const MeshVertexAttributes Normals = 1;
	public const MeshVertexAttributes Tangents = 2;
	public const MeshVertexAttributes UVs = 4;
	public const MeshVertexAttributes Colors = 8;
}

// Namespace: 
[IsReadOnly]
[NativeConditional("ENABLE_XR")]
private struct XRMeshSubsystem.MeshTransformList : IDisposable // TypeDefIndex: 15943
{
	// Fields
	private readonly IntPtr m_Self; // 0x0

	// Methods

	// RVA: 0x311EAE0 Offset: 0x311DCE0 VA: 0x18311EAE0 Slot: 4
	public void Dispose() { }

	[FreeFunction("UnityXRMeshTransformList_Dispose")]
	// RVA: 0x311EB30 Offset: 0x311DD30 VA: 0x18311EB30
	private static void Dispose(IntPtr self) { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_XR")]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 15944
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x311EA40 Offset: 0x311DC40 VA: 0x18311EA40
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x311EAB0 Offset: 0x311DCB0 VA: 0x18311EAB0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 15945
{
	// Methods

	// RVA: 0x311EB80 Offset: 0x311DD80 VA: 0x18311EB80
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15946
{}

// Namespace: UnityEngine
[StaticAccessor("GetITerrainManager()", 1)]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[UsedByNativeCode]
public sealed class Terrain : Behaviour // TypeDefIndex: 15947
{
	// Properties
	public TerrainData terrainData { get; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x2FEC1B0 Offset: 0x2FEB3B0 VA: 0x182FEC1B0
	public TerrainData get_terrainData() { }

	// RVA: 0x2FEC270 Offset: 0x2FEB470 VA: 0x182FEC270
	public void SetKeepUnusedCameraRenderingResources(int cameraInstanceID, bool keepUnused) { }

	// RVA: 0x2FEC330 Offset: 0x2FEB530 VA: 0x182FEC330
	public bool get_allowAutoConnect() { }

	// RVA: 0x2FEC3D0 Offset: 0x2FEB5D0 VA: 0x182FEC3D0
	public int get_groupingID() { }

	// RVA: 0x2FEC470 Offset: 0x2FEB670 VA: 0x182FEC470
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x2FEC5E0 Offset: 0x2FEB7E0 VA: 0x182FEC5E0
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x2FEC630 Offset: 0x2FEB830 VA: 0x182FEC630
	public static void GetActiveTerrains(List<Terrain> terrainList) { }

	// RVA: 0x2FEC630 Offset: 0x2FEB830 VA: 0x182FEC630
	private static void Internal_FillActiveTerrainList(object terrainList) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x2FEC6C0 Offset: 0x2FEB8C0 VA: 0x182FEC6C0
	private static IntPtr get_terrainData_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FEC710 Offset: 0x2FEB910 VA: 0x182FEC710
	private static void SetKeepUnusedCameraRenderingResources_Injected(IntPtr _unity_self, int cameraInstanceID, bool keepUnused) { }

	// RVA: 0x2FEC780 Offset: 0x2FEB980 VA: 0x182FEC780
	private static bool get_allowAutoConnect_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FEC7D0 Offset: 0x2FEB9D0 VA: 0x182FEC7D0
	private static int get_groupingID_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FEC820 Offset: 0x2FEBA20 VA: 0x182FEC820
	private static void SetNeighbors_Injected(IntPtr _unity_self, IntPtr left, IntPtr top, IntPtr right, IntPtr bottom) { }

	// RVA: 0x2FEC8B0 Offset: 0x2FEBAB0 VA: 0x182FEC8B0
	private static void Internal_FillActiveTerrainList_Injected(object terrainList) { }
}

// Namespace: 
public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 15948
{
	// Methods

	// RVA: 0x2FECB10 Offset: 0x2FEBD10 VA: 0x182FECB10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DB220 Offset: 0x12DA420 VA: 0x1812DB220 Slot: 12
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }
}

// Namespace: 
public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 15949
{
	// Methods

	// RVA: 0x2FECC00 Offset: 0x2FEBE00 VA: 0x182FECC00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FECCF0 Offset: 0x2FEBEF0 VA: 0x182FECCF0 Slot: 12
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: UnityEngine
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks // TypeDefIndex: 15950
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2FEC900 Offset: 0x2FEBB00 VA: 0x182FEC900
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	// RVA: 0x2FECA00 Offset: 0x2FEBC00 VA: 0x182FECA00
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: 
private enum TerrainData.BoundaryValueType // TypeDefIndex: 15951
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
	public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
	public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
	public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
	public const TerrainData.BoundaryValueType MaxCoveragePerRes = 4;
	public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
	public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
	public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
	public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;
}

// Namespace: UnityEngine
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[UsedByNativeCode]
public sealed class TerrainData : Object // TypeDefIndex: 15952
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MinimumAlphamapResolution; // 0x10
	internal static readonly int k_MaximumAlphamapResolution; // 0x14
	internal static readonly int k_MinimumBaseMapResolution; // 0x18
	internal static readonly int k_MaximumBaseMapResolution; // 0x1C

	// Properties
	public RenderTexture heightmapTexture { get; }
	public Vector3 heightmapScale { get; }
	public Vector3 size { get; }
	public Bounds bounds { get; }
	internal Terrain[] users { get; }

	// Methods

	[ThreadSafe]
	[StaticAccessor("TerrainDataScriptingInterface", 2)]
	// RVA: 0x2FECD30 Offset: 0x2FEBF30 VA: 0x182FECD30
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	[NativeName("GetHeightmap().GetHeightmapTexture")]
	// RVA: 0x2FECD80 Offset: 0x2FEBF80 VA: 0x182FECD80
	public RenderTexture get_heightmapTexture() { }

	[NativeName("GetHeightmap().GetScale")]
	// RVA: 0x2FECE60 Offset: 0x2FEC060 VA: 0x182FECE60
	public Vector3 get_heightmapScale() { }

	[NativeName("GetHeightmap().GetSize")]
	// RVA: 0x2FECF40 Offset: 0x2FEC140 VA: 0x182FECF40
	public Vector3 get_size() { }

	[NativeName("GetHeightmap().CalculateBounds")]
	// RVA: 0x2FED020 Offset: 0x2FEC220 VA: 0x182FED020
	public Bounds get_bounds() { }

	[RequiredByNativeCode]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	// RVA: 0x2FED100 Offset: 0x2FEC300 VA: 0x182FED100
	internal float GetAlphamapResolutionInternal() { }

	// RVA: 0x2FED1C0 Offset: 0x2FEC3C0 VA: 0x182FED1C0
	internal Terrain[] get_users() { }

	// RVA: 0x2FED280 Offset: 0x2FEC480 VA: 0x182FED280
	private static void .cctor() { }

	// RVA: 0x2FED560 Offset: 0x2FEC760 VA: 0x182FED560
	private static IntPtr get_heightmapTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FED5B0 Offset: 0x2FEC7B0 VA: 0x182FED5B0
	private static void get_heightmapScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x2FED610 Offset: 0x2FEC810 VA: 0x182FED610
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x2FED670 Offset: 0x2FEC870 VA: 0x182FED670
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x2FED6D0 Offset: 0x2FEC8D0 VA: 0x182FED6D0
	private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self) { }

	// RVA: 0x2FED720 Offset: 0x2FEC920 VA: 0x182FED720
	private static Terrain[] get_users_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Terrain/Public/TerrainLayerScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainLayer : Object // TypeDefIndex: 15953
{}

// Namespace: UnityEngine.TerrainUtils
internal enum TerrainMapStatusCode // TypeDefIndex: 15954
{
	// Fields
	public int value__; // 0x0
	public const TerrainMapStatusCode OK = 0;
	public const TerrainMapStatusCode Overlapping = 1;
	public const TerrainMapStatusCode SizeMismatch = 4;
	public const TerrainMapStatusCode EdgeAlignmentMismatch = 8;
}

// Namespace: UnityEngine.TerrainUtils
[IsReadOnly]
public struct TerrainTileCoord // TypeDefIndex: 15955
{
	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0x8A2690 Offset: 0x8A1890 VA: 0x1808A2690
	public void .ctor(int tileX, int tileZ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainMap.<>c__DisplayClass3_0 // TypeDefIndex: 15956
{
	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2FEFB40 Offset: 0x2FEED40 VA: 0x182FEFB40
	internal bool <CreateFromPlacement>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
public class TerrainMap // TypeDefIndex: 15957
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	private TerrainMapStatusCode m_errorCode; // 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20

	// Properties
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

	// Methods

	// RVA: 0x2FED770 Offset: 0x2FEC970 VA: 0x182FED770
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x2FED8A0 Offset: 0x2FECAA0 VA: 0x182FED8A0
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x2FEDD50 Offset: 0x2FECF50 VA: 0x182FEDD50
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x49BDC0 Offset: 0x49AFC0 VA: 0x18049BDC0
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	// RVA: 0x2FEE2E0 Offset: 0x2FED4E0 VA: 0x182FEE2E0
	public void .ctor() { }

	// RVA: 0x2FEE420 Offset: 0x2FED620 VA: 0x182FEE420
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x2FEE590 Offset: 0x2FED790 VA: 0x182FEE590
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x2FEE8F0 Offset: 0x2FEDAF0 VA: 0x182FEE8F0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x2FEF830 Offset: 0x2FEEA30 VA: 0x182FEF830
	private TerrainMapStatusCode Validate() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_0 // TypeDefIndex: 15958
{
	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_1 // TypeDefIndex: 15959
{
	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass2_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2FF0680 Offset: 0x2FEF880 VA: 0x182FF0680
	internal bool <CollectTerrains>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility // TypeDefIndex: 15960
{
	// Methods

	// RVA: 0x2FEFBF0 Offset: 0x2FEEDF0 VA: 0x182FEFBF0
	internal static bool ValidTerrainsExist() { }

	// RVA: 0x2FEFCA0 Offset: 0x2FEEEA0 VA: 0x182FEFCA0
	internal static void ClearConnectivity() { }

	// RVA: 0x2FEFEA0 Offset: 0x2FEF0A0 VA: 0x182FEFEA0
	internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCode]
	// RVA: 0x2FF0260 Offset: 0x2FEF460 VA: 0x182FF0260
	public static void AutoConnect() { }
}

// Namespace: UnityEngine.Rendering
[StaticAccessor("GetSpeedTreeWindManager()", 0)]
[NativeHeader("Modules/Terrain/Public/SpeedTreeWindManager.h")]
internal static class SpeedTreeWindManager // TypeDefIndex: 15961
{
	// Methods

	// RVA: 0x2FF0800 Offset: 0x2FEFA00 VA: 0x182FF0800
	public static void UpdateWindAndWriteBufferWindParams(ReadOnlySpan<int> renderersID, SpeedTreeWindParamsBufferIterator windParams, bool history) { }

	// RVA: 0x2FF08D0 Offset: 0x2FEFAD0 VA: 0x182FF08D0
	private static void UpdateWindAndWriteBufferWindParams_Injected(ref ManagedSpanWrapper renderersID, in SpeedTreeWindParamsBufferIterator windParams, bool history) { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct SpeedTreeWindParamsBufferIterator.<uintParamOffsets>e__FixedBuffer // TypeDefIndex: 15962
{
	// Fields
	public int FixedElementField; // 0x0
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Modules/Terrain/Public/SpeedTreeWind.h")]
[UsedByNativeCode]
internal struct SpeedTreeWindParamsBufferIterator // TypeDefIndex: 15963
{
	// Fields
	public IntPtr bufferPtr; // 0x0
	[FixedBuffer(typeof(int), 16)]
	public SpeedTreeWindParamsBufferIterator.<uintParamOffsets>e__FixedBuffer uintParamOffsets; // 0x8
	public int uintStride; // 0x48
	public int elementOffset; // 0x4C
	public int elementsCount; // 0x50
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15964
{}

// Namespace: 
internal static class HierarchyNodeTypeHandlerBase.BindingsMarshaller // TypeDefIndex: 15965
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(HierarchyNodeTypeHandlerBase handler) { }
}

// Namespace: 
private struct HierarchyNodeTypeHandlerBase.ConstructorScope : IDisposable // TypeDefIndex: 15966
{
	// Fields
	[ThreadStatic]
	private static IntPtr m_Ptr; // 0x80000000
	[ThreadStatic]
	private static Hierarchy m_Hierarchy; // 0x80000008
	[ThreadStatic]
	private static HierarchyCommandList m_CommandList; // 0x80000010

	// Properties
	private static IntPtr Ptr { set; }
	private static Hierarchy Hierarchy { set; }
	private static HierarchyCommandList CommandList { set; }

	// Methods

	// RVA: 0x2F88400 Offset: 0x2F87600 VA: 0x182F88400
	private static void set_Ptr(IntPtr value) { }

	// RVA: 0x2F88490 Offset: 0x2F87690 VA: 0x182F88490
	private static void set_Hierarchy(Hierarchy value) { }

	// RVA: 0x2F885A0 Offset: 0x2F877A0 VA: 0x182F885A0
	private static void set_CommandList(HierarchyCommandList value) { }

	// RVA: 0x2F886B0 Offset: 0x2F878B0 VA: 0x182F886B0
	public void .ctor(IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList) { }

	// RVA: 0x2F886F0 Offset: 0x2F878F0 VA: 0x182F886F0 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.Hierarchy
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyNodeTypeHandlerBaseBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public abstract class HierarchyNodeTypeHandlerBase // TypeDefIndex: 15967
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private readonly HierarchyCommandList m_CommandList; // 0x20
	private static readonly Dictionary<Type, int> s_NodeTypes; // 0x0

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 4
	protected virtual void Initialize() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F87100 Offset: 0x2F86300 VA: 0x182F87100 Slot: 6
	public virtual string GetNodeTypeName() { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2F87240 Offset: 0x2F86440 VA: 0x182F87240 Slot: 7
	public virtual HierarchyNodeFlags GetDefaultNodeFlags(in HierarchyNode node, HierarchyNodeFlags defaultFlags = 0) { }

	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchBegin", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2F87310 Offset: 0x2F86510 VA: 0x182F87310 Slot: 8
	protected virtual void SearchBegin(HierarchySearchQueryDescriptor query) { }

	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchMatch", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2F873D0 Offset: 0x2F865D0 VA: 0x182F873D0 Slot: 9
	protected virtual bool SearchMatch(in HierarchyNode node) { }

	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchEnd", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2F87490 Offset: 0x2F86690 VA: 0x182F87490 Slot: 10
	protected virtual void SearchEnd() { }

	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	// RVA: 0x2F87540 Offset: 0x2F86740 VA: 0x182F87540
	internal static HierarchyNodeTypeHandlerBase FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x52BF80 Offset: 0x52B180 VA: 0x18052BF80
	internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87630 Offset: 0x2F86830 VA: 0x182F87630
	private static IntPtr CreateNodeTypeHandlerFromType(IntPtr nativePtr, Type handlerType, IntPtr hierarchyPtr, IntPtr cmdListPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F878D0 Offset: 0x2F86AD0 VA: 0x182F878D0
	private static bool TryGetStaticNodeType(Type handlerType, out int nodeType) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87B00 Offset: 0x2F86D00 VA: 0x182F87B00
	private static void InvokeInitialize(IntPtr handlePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87B70 Offset: 0x2F86D70 VA: 0x182F87B70
	private static void InvokeDispose(IntPtr handlePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87C20 Offset: 0x2F86E20 VA: 0x182F87C20
	private static string InvokeGetNodeTypeName(IntPtr handlePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87C90 Offset: 0x2F86E90 VA: 0x182F87C90
	private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr handlePtr, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87D20 Offset: 0x2F86F20 VA: 0x182F87D20
	private static bool InvokeChangesPending(IntPtr handlePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87D90 Offset: 0x2F86F90 VA: 0x182F87D90
	private static bool InvokeIntegrateChanges(IntPtr handlePtr, IntPtr cmdListPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87E20 Offset: 0x2F87020 VA: 0x182F87E20
	private static bool InvokeSearchMatch(IntPtr handlePtr, in HierarchyNode node) { }

	[RequiredByNativeCode]
	// RVA: 0x2F87EA0 Offset: 0x2F870A0 VA: 0x182F87EA0
	private static void InvokeSearchEnd(IntPtr handlePtr) { }

	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::ChangesPending", HasExplicitThis = True, IsThreadSafe = True)]
	[Obsolete("ChangesPending is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	// RVA: 0x2F87F10 Offset: 0x2F87110 VA: 0x182F87F10 Slot: 11
	protected virtual bool ChangesPending() { }

	[Obsolete("IntegrateChanges is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::IntegrateChanges", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2F87FC0 Offset: 0x2F871C0 VA: 0x182F87FC0 Slot: 12
	protected virtual bool IntegrateChanges(HierarchyCommandList cmdList) { }

	// RVA: 0x2F88090 Offset: 0x2F87290 VA: 0x182F88090
	private static void .cctor() { }

	// RVA: 0x2F88170 Offset: 0x2F87370 VA: 0x182F88170
	private static void GetNodeTypeName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2F881D0 Offset: 0x2F873D0 VA: 0x182F881D0
	private static HierarchyNodeFlags GetDefaultNodeFlags_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	// RVA: 0x2F88240 Offset: 0x2F87440 VA: 0x182F88240
	private static void SearchBegin_Injected(IntPtr _unity_self, HierarchySearchQueryDescriptor query) { }

	// RVA: 0x2F882A0 Offset: 0x2F874A0 VA: 0x182F882A0
	private static bool SearchMatch_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	// RVA: 0x2F88300 Offset: 0x2F87500 VA: 0x182F88300
	private static void SearchEnd_Injected(IntPtr _unity_self) { }

	// RVA: 0x2F88350 Offset: 0x2F87550 VA: 0x182F88350
	private static bool ChangesPending_Injected(IntPtr _unity_self) { }

	// RVA: 0x2F883A0 Offset: 0x2F875A0 VA: 0x182F883A0
	private static bool IntegrateChanges_Injected(IntPtr _unity_self, IntPtr cmdList) { }
}

// Namespace: 
public struct HierarchyNodeTypeHandlerBaseEnumerable.Enumerator : IDisposable // TypeDefIndex: 15968
{
	// Fields
	private readonly IMemoryOwner<IntPtr> m_Handlers; // 0x0
	private readonly int m_Count; // 0x8
	private int m_Index; // 0xC

	// Properties
	public HierarchyNodeTypeHandlerBase Current { get; }

	// Methods

	// RVA: 0x2F88740 Offset: 0x2F87940 VA: 0x182F88740
	internal void .ctor(Hierarchy hierarchy) { }

	// RVA: 0x2F88A90 Offset: 0x2F87C90 VA: 0x182F88A90 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F88AE0 Offset: 0x2F87CE0 VA: 0x182F88AE0
	public HierarchyNodeTypeHandlerBase get_Current() { }

	// RVA: 0x2F88C20 Offset: 0x2F87E20 VA: 0x182F88C20
	public bool MoveNext() { }
}

// Namespace: Unity.Hierarchy
[IsReadOnly]
public struct HierarchyNodeTypeHandlerBaseEnumerable // TypeDefIndex: 15969
{
	// Fields
	private readonly Hierarchy m_Hierarchy; // 0x0

	// Methods

	// RVA: 0x4F1D00 Offset: 0x4F0F00 VA: 0x1804F1D00
	internal void .ctor(Hierarchy hierarchy) { }

	// RVA: 0x2F88710 Offset: 0x2F87910 VA: 0x182F88710
	public HierarchyNodeTypeHandlerBaseEnumerable.Enumerator GetEnumerator() { }
}

// Namespace: Unity.Hierarchy
[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
internal interface IHierarchySearchQueryParser // TypeDefIndex: 15970
{}

// Namespace: Unity.Hierarchy
internal class DefaultHierarchySearchQueryParser : IHierarchySearchQueryParser // TypeDefIndex: 15971
{
	// Fields
	private static readonly Regex s_Filter; // 0x0

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2F88C30 Offset: 0x2F87E30 VA: 0x182F88C30
	private static void .cctor() { }
}

// Namespace: 
internal static class Hierarchy.BindingsMarshaller // TypeDefIndex: 15972
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(Hierarchy hierarchy) { }
}

// Namespace: Unity.Hierarchy
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Modules/HierarchyCore/Public/Hierarchy.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
public sealed class Hierarchy : IDisposable // TypeDefIndex: 15973
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly IntPtr m_RootPtr; // 0x18
	private readonly IntPtr m_VersionPtr; // 0x20
	private readonly bool m_IsOwner; // 0x28

	// Methods

	// RVA: 0x2F88D10 Offset: 0x2F87F10 VA: 0x182F88D10
	private void .ctor(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	// RVA: 0x2F88D30 Offset: 0x2F87F30 VA: 0x182F88D30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F88D80 Offset: 0x2F87F80 VA: 0x182F88D80 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F88DE0 Offset: 0x2F87FE0 VA: 0x182F88DE0
	private void Dispose(bool disposing) { }

	// RVA: 0x24FF360 Offset: 0x24FE560 VA: 0x1824FF360
	public HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase() { }

	// RVA: 0x2F88E60 Offset: 0x2F88060 VA: 0x182F88E60
	internal static Hierarchy FromIntPtr(IntPtr handlePtr) { }

	[FreeFunction("HierarchyBindings::Destroy", IsThreadSafe = True)]
	// RVA: 0x2F88F30 Offset: 0x2F88130 VA: 0x182F88F30
	private static void Destroy(IntPtr nativePtr) { }

	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseCount", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2F88F80 Offset: 0x2F88180 VA: 0x182F88F80
	internal int GetNodeTypeHandlersBaseCount() { }

	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseSpan", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2F88FF0 Offset: 0x2F881F0 VA: 0x182F88FF0
	internal int GetNodeTypeHandlersBaseSpan(Span<IntPtr> outHandlers) { }

	[RequiredByNativeCode]
	// RVA: 0x2F890D0 Offset: 0x2F882D0 VA: 0x182F890D0
	private static IntPtr CreateHierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	// RVA: 0x2F89160 Offset: 0x2F88360 VA: 0x182F89160
	private static int GetNodeTypeHandlersBaseCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2F891B0 Offset: 0x2F883B0 VA: 0x182F891B0
	private static int GetNodeTypeHandlersBaseSpan_Injected(IntPtr _unity_self, ref ManagedSpanWrapper outHandlers) { }
}

// Namespace: 
internal static class HierarchyCommandList.BindingsMarshaller // TypeDefIndex: 15974
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(HierarchyCommandList cmdList) { }
}

// Namespace: Unity.Hierarchy
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyCommandList.h")]
public sealed class HierarchyCommandList : IDisposable // TypeDefIndex: 15975
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly bool m_IsOwner; // 0x18

	// Methods

	// RVA: 0x2F09CF0 Offset: 0x2F08EF0 VA: 0x182F09CF0
	private void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2F89210 Offset: 0x2F88410 VA: 0x182F89210 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F89260 Offset: 0x2F88460 VA: 0x182F89260 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F892C0 Offset: 0x2F884C0 VA: 0x182F892C0
	private void Dispose(bool disposing) { }

	// RVA: 0x2F89340 Offset: 0x2F88540 VA: 0x182F89340
	internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr) { }

	[FreeFunction("HierarchyCommandListBindings::Destroy", IsThreadSafe = True)]
	// RVA: 0x2F89410 Offset: 0x2F88610 VA: 0x182F89410
	private static void Destroy(IntPtr nativePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F89460 Offset: 0x2F88660 VA: 0x182F89460
	private static IntPtr CreateCommandList(IntPtr nativePtr) { }
}

// Namespace: Unity.Hierarchy
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattened.h")]
[DefaultMember("Item")]
public sealed class HierarchyFlattened : IDisposable // TypeDefIndex: 15976
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private IntPtr m_NodesPtr; // 0x20
	private int m_NodesCount; // 0x28
	private int m_Version; // 0x2C
	private readonly bool m_IsOwner; // 0x30

	// Properties
	public Hierarchy Hierarchy { get; }

	// Methods

	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public Hierarchy get_Hierarchy() { }

	// RVA: 0x2F894D0 Offset: 0x2F886D0 VA: 0x182F894D0
	private void .ctor(IntPtr nativePtr, Hierarchy hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x2F89540 Offset: 0x2F88740 VA: 0x182F89540 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F89590 Offset: 0x2F88790 VA: 0x182F89590 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F895F0 Offset: 0x2F887F0 VA: 0x182F895F0
	private void Dispose(bool disposing) { }

	// RVA: 0x2F89670 Offset: 0x2F88870 VA: 0x182F89670
	internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr) { }

	[FreeFunction("HierarchyFlattenedBindings::Destroy", IsThreadSafe = True)]
	// RVA: 0x2F89740 Offset: 0x2F88940 VA: 0x182F89740
	private static void Destroy(IntPtr nativePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F89790 Offset: 0x2F88990 VA: 0x182F89790
	private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[RequiredByNativeCode]
	// RVA: 0x2F89890 Offset: 0x2F88A90 VA: 0x182F89890
	private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }
}

// Namespace: Unity.Hierarchy
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNode.h")]
[IsReadOnly]
public struct HierarchyNode : IEquatable<HierarchyNode> // TypeDefIndex: 15977
{
	// Fields
	private static readonly HierarchyNode s_Null; // 0x0
	private readonly int m_Id; // 0x0
	private readonly int m_Version; // 0x4

	// Properties
	[IsReadOnly]
	public static HierarchyNode Null { get; }
	public int Id { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x2F898E0 Offset: 0x2F88AE0 VA: 0x182F898E0
	public static ref HierarchyNode get_Null() { }

	// RVA: 0x469D00 Offset: 0x468F00 VA: 0x180469D00
	public int get_Id() { }

	// RVA: 0x1324F70 Offset: 0x1324170 VA: 0x181324F70
	public int get_Version() { }

	// RVA: 0x2F89920 Offset: 0x2F88B20 VA: 0x182F89920
	public void .ctor() { }

	[ExcludeFromDocs]
	// RVA: 0x2F89930 Offset: 0x2F88B30 VA: 0x182F89930
	public static bool op_Equality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[ExcludeFromDocs]
	// RVA: 0x2F89950 Offset: 0x2F88B50 VA: 0x182F89950 Slot: 4
	public bool Equals(HierarchyNode other) { }

	[ExcludeFromDocs]
	// RVA: 0x2F89970 Offset: 0x2F88B70 VA: 0x182F89970 Slot: 3
	public override string ToString() { }

	[ExcludeFromDocs]
	// RVA: 0x2F89AE0 Offset: 0x2F88CE0 VA: 0x182F89AE0 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x2F89B70 Offset: 0x2F88D70 VA: 0x182F89B70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Unity.Hierarchy
[Flags]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeFlags.h")]
public enum HierarchyNodeFlags // TypeDefIndex: 15978
{
	// Fields
	public uint value__; // 0x0
	public const HierarchyNodeFlags None = 0;
	public const HierarchyNodeFlags Expanded = 1;
	public const HierarchyNodeFlags Selected = 2;
	public const HierarchyNodeFlags Cut = 4;
	public const HierarchyNodeFlags Hidden = 8;
}

// Namespace: Unity.Hierarchy
[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
public enum HierarchySearchFilterOperator // TypeDefIndex: 15979
{
	// Fields
	public int value__; // 0x0
	public const HierarchySearchFilterOperator Equal = 0;
	public const HierarchySearchFilterOperator Contains = 1;
	public const HierarchySearchFilterOperator Greater = 2;
	public const HierarchySearchFilterOperator GreaterOrEqual = 3;
	public const HierarchySearchFilterOperator Lesser = 4;
	public const HierarchySearchFilterOperator LesserOrEqual = 5;
	public const HierarchySearchFilterOperator NotEqual = 6;
	public const HierarchySearchFilterOperator Not = 7;
}

// Namespace: Unity.Hierarchy
[RequiredByNativeCode]
[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
[Serializable]
public struct HierarchySearchFilter // TypeDefIndex: 15980
{
	// Fields
	private static readonly char[] s_WhiteSpaces; // 0x0
	private static readonly HierarchySearchFilter s_Invalid; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <NumValue>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private HierarchySearchFilterOperator <Op>k__BackingField; // 0x14

	// Properties
	[IsReadOnly]
	public static HierarchySearchFilter Invalid { get; }
	public bool IsValid { get; }
	public string Name { get; }
	public string Value { get; }
	public float NumValue { get; }
	public HierarchySearchFilterOperator Op { get; }

	// Methods

	// RVA: 0x2F89BE0 Offset: 0x2F88DE0 VA: 0x182F89BE0
	public static ref HierarchySearchFilter get_Invalid() { }

	// RVA: 0x2F89C40 Offset: 0x2F88E40 VA: 0x182F89C40
	public bool get_IsValid() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x516B20 Offset: 0x515D20 VA: 0x180516B20
	public string get_Name() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5C0480 Offset: 0x5BF680 VA: 0x1805C0480
	public string get_Value() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C4A80 Offset: 0x4C3C80 VA: 0x1804C4A80
	public float get_NumValue() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x73C870 Offset: 0x73BA70 VA: 0x18073C870
	public HierarchySearchFilterOperator get_Op() { }

	// RVA: 0x2F89CA0 Offset: 0x2F88EA0 VA: 0x182F89CA0
	public static string ToString(HierarchySearchFilterOperator op) { }

	// RVA: 0x2F89E70 Offset: 0x2F89070 VA: 0x182F89E70 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F8A140 Offset: 0x2F89340 VA: 0x182F8A140
	internal static string QuoteStringIfNeeded(string s) { }

	// RVA: 0x2F8A210 Offset: 0x2F89410 VA: 0x182F8A210
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HierarchySearchQueryDescriptor.<>c // TypeDefIndex: 15981
{
	// Fields
	public static readonly HierarchySearchQueryDescriptor.<>c <>9; // 0x0
	public static Func<HierarchySearchFilter, bool> <>9__33_0; // 0x8
	public static Func<HierarchySearchFilter, bool> <>9__33_1; // 0x10

	// Methods

	// RVA: 0x2F8B080 Offset: 0x2F8A280 VA: 0x182F8B080
	private static void .cctor() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2F8B120 Offset: 0x2F8A320 VA: 0x182F8B120
	internal bool <.ctor>b__33_0(HierarchySearchFilter f) { }

	// RVA: 0x2F8B1E0 Offset: 0x2F8A3E0 VA: 0x182F8B1E0
	internal bool <.ctor>b__33_1(HierarchySearchFilter f) { }
}

// Namespace: Unity.Hierarchy
[RequiredByNativeCode]
[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
[NativeAsStruct]
[Serializable]
public sealed class HierarchySearchQueryDescriptor // TypeDefIndex: 15982
{
	// Fields
	private static readonly HashSet<string> s_SystemFilters; // 0x0
	private static readonly HierarchySearchQueryDescriptor s_Empty; // 0x8
	private static readonly HierarchySearchQueryDescriptor s_InvalidQuery; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private HierarchySearchFilter[] <SystemFilters>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private HierarchySearchFilter[] <Filters>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string[] <TextValues>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Strict>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Invalid>k__BackingField; // 0x29

	// Properties
	public HierarchySearchFilter[] SystemFilters { get; set; }
	public HierarchySearchFilter[] Filters { get; set; }
	public string[] TextValues { get; set; }
	public bool Strict { set; }
	public bool Invalid { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public HierarchySearchFilter[] get_SystemFilters() { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_SystemFilters(HierarchySearchFilter[] value) { }

	[CompilerGenerated]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	public HierarchySearchFilter[] get_Filters() { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	public void set_Filters(HierarchySearchFilter[] value) { }

	[CompilerGenerated]
	// RVA: 0x49BDC0 Offset: 0x49AFC0 VA: 0x18049BDC0
	public string[] get_TextValues() { }

	[CompilerGenerated]
	// RVA: 0x49BDD0 Offset: 0x49AFD0 VA: 0x18049BDD0
	public void set_TextValues(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x49BE40 Offset: 0x49B040 VA: 0x18049BE40
	public void set_Strict(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E6610 Offset: 0x4E5810 VA: 0x1804E6610
	public void set_Invalid(bool value) { }

	// RVA: 0x2F8A2F0 Offset: 0x2F894F0 VA: 0x182F8A2F0
	public void .ctor(HierarchySearchFilter[] filters, string[] textValues) { }

	// RVA: 0x2F8A920 Offset: 0x2F89B20 VA: 0x182F8A920 Slot: 3
	public override string ToString() { }

	[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
	// RVA: 0x2F8A930 Offset: 0x2F89B30 VA: 0x182F8A930
	internal string BuildFilterQuery() { }

	// RVA: 0x2F8A980 Offset: 0x2F89B80 VA: 0x182F8A980
	internal string BuildSystemFilterQuery() { }

	// RVA: 0x2F8A9D0 Offset: 0x2F89BD0 VA: 0x182F8A9D0
	internal string BuildTextQuery() { }

	// RVA: 0x2F8AC40 Offset: 0x2F89E40 VA: 0x182F8AC40
	internal string BuildQuery() { }

	// RVA: -1 Offset: -1
	private static T[] Where<T>(IEnumerable<T> src, Func<T, bool> pred) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120170 Offset: 0x111F370 VA: 0x181120170
	|-HierarchySearchQueryDescriptor.Where<HierarchySearchFilter>
	|
	|-RVA: 0x1120690 Offset: 0x111F890 VA: 0x181120690
	|-HierarchySearchQueryDescriptor.Where<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F8ADD0 Offset: 0x2F89FD0 VA: 0x182F8ADD0
	private static void .cctor() { }
}

// Namespace: 
internal static class HierarchyViewModel.BindingsMarshaller // TypeDefIndex: 15983
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(HierarchyViewModel viewModel) { }
}

// Namespace: Unity.Hierarchy
[NativeHeader("Modules/HierarchyCore/Public/HierarchyViewModel.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyViewModelBindings.h")]
[DefaultMember("Item")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class HierarchyViewModel : IDisposable // TypeDefIndex: 15984
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x20
	private IntPtr m_NodesPtr; // 0x28
	private int m_NodesCount; // 0x30
	private int m_Version; // 0x34
	private readonly bool m_IsOwner; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IHierarchySearchQueryParser <QueryParser>k__BackingField; // 0x40

	// Properties
	internal IHierarchySearchQueryParser QueryParser { set; }
	internal HierarchySearchQueryDescriptor Query { get; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
	[CompilerGenerated]
	// RVA: 0x5189F0 Offset: 0x517BF0 VA: 0x1805189F0
	internal void set_QueryParser(IHierarchySearchQueryParser value) { }

	[NativeMethod(IsThreadSafe = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	// RVA: 0x2F8B2A0 Offset: 0x2F8A4A0 VA: 0x182F8B2A0
	internal HierarchySearchQueryDescriptor get_Query() { }

	// RVA: 0x2F8B310 Offset: 0x2F8A510 VA: 0x182F8B310
	private void .ctor(IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x2F8B4A0 Offset: 0x2F8A6A0 VA: 0x182F8B4A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F8B4F0 Offset: 0x2F8A6F0 VA: 0x182F8B4F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F8B550 Offset: 0x2F8A750 VA: 0x182F8B550
	private void Dispose(bool disposing) { }

	// RVA: 0x2F8B5D0 Offset: 0x2F8A7D0 VA: 0x182F8B5D0
	internal static HierarchyViewModel FromIntPtr(IntPtr handlePtr) { }

	[FreeFunction("HierarchyViewModelBindings::Destroy", IsThreadSafe = True)]
	// RVA: 0x2F8B6A0 Offset: 0x2F8A8A0 VA: 0x182F8B6A0
	private static void Destroy(IntPtr nativePtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F8B6F0 Offset: 0x2F8A8F0 VA: 0x182F8B6F0
	private static IntPtr CreateHierarchyViewModel(IntPtr nativePtr, IntPtr flattenedPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[RequiredByNativeCode]
	// RVA: 0x2F8B8D0 Offset: 0x2F8AAD0 VA: 0x182F8B8D0
	private static void UpdateHierarchyViewModel(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[RequiredByNativeCode]
	// RVA: 0x2F8B920 Offset: 0x2F8AB20 VA: 0x182F8B920
	private static void SearchBegin(IntPtr handlePtr) { }

	// RVA: 0x2F8BC90 Offset: 0x2F8AE90 VA: 0x182F8BC90
	private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 15985
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 15986
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43 /*Metadata offset 0x7EF878*/; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 15987
{}

// Namespace: UnityEngine
public enum TouchPhase // TypeDefIndex: 15988
{
	// Fields
	public int value__; // 0x0
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode // TypeDefIndex: 15989
{
	// Fields
	public int value__; // 0x0
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType // TypeDefIndex: 15990
{
	// Fields
	public int value__; // 0x0
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 15991
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; }
	public Vector2 deltaPosition { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x17318B0 Offset: 0x1730AB0 VA: 0x1817318B0
	public int get_fingerId() { }

	// RVA: 0x2FB0B60 Offset: 0x2FAFD60 VA: 0x182FB0B60
	public Vector2 get_position() { }

	// RVA: 0x1DAEC30 Offset: 0x1DADE30 VA: 0x181DAEC30
	public Vector2 get_deltaPosition() { }

	// RVA: 0x1772440 Offset: 0x1771640 VA: 0x181772440
	public int get_tapCount() { }

	// RVA: 0x2FB0B80 Offset: 0x2FAFD80 VA: 0x182FB0B80
	public TouchPhase get_phase() { }

	// RVA: 0x2FB0B90 Offset: 0x2FAFD90 VA: 0x182FB0B90
	public float get_pressure() { }

	// RVA: 0x2FB0BA0 Offset: 0x2FAFDA0 VA: 0x182FB0BA0
	public float get_maximumPossiblePressure() { }

	// RVA: 0x1771E50 Offset: 0x1771050 VA: 0x181771E50
	public TouchType get_type() { }

	// RVA: 0x2DC4B20 Offset: 0x2DC3D20 VA: 0x182DC4B20
	public float get_altitudeAngle() { }

	// RVA: 0x2FB0BB0 Offset: 0x2FAFDB0 VA: 0x182FB0BB0
	public float get_azimuthAngle() { }

	// RVA: 0x2FB0BC0 Offset: 0x2FAFDC0 VA: 0x182FB0BC0
	public float get_radius() { }

	// RVA: 0x2DC4AC0 Offset: 0x2DC3CC0 VA: 0x182DC4AC0
	public float get_radiusVariance() { }
}

// Namespace: UnityEngine
[Flags]
public enum PenStatus // TypeDefIndex: 15992
{
	// Fields
	public int value__; // 0x0
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
public enum PenEventType // TypeDefIndex: 15993
{
	// Fields
	public int value__; // 0x0
	public const PenEventType NoContact = 0;
	public const PenEventType PenDown = 1;
	public const PenEventType PenUp = 2;
}

// Namespace: UnityEngine
public struct PenData // TypeDefIndex: 15994
{
	// Fields
	public Vector2 position; // 0x0
	public Vector2 tilt; // 0x8
	public PenStatus penStatus; // 0x10
	public float twist; // 0x14
	public float pressure; // 0x18
	public PenEventType contactType; // 0x1C
	public Vector2 deltaPos; // 0x20
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 15995
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x2FB0BD0 Offset: 0x2FAFDD0 VA: 0x182FB0BD0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x2FB0CB0 Offset: 0x2FAFEB0 VA: 0x182FB0CB0
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x2FB0D90 Offset: 0x2FAFF90 VA: 0x182FB0D90
	private static IntPtr RaycastTry_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

	// RVA: 0x2FB0E10 Offset: 0x2FB0010 VA: 0x182FB0E10
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 15996
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <simulateTouchEnabled>k__BackingField; // 0x0

	// Properties
	[NativeThrows]
	public static bool anyKey { get; }
	[NativeThrows]
	public static bool anyKeyDown { get; }
	[NativeThrows]
	public static string inputString { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	internal static bool simulateTouchEnabled { get; }
	public static bool mousePresent { get; }
	public static bool touchSupported { get; }
	public static int touchCount { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x2FB0E90 Offset: 0x2FB0090 VA: 0x182FB0E90
	public static float GetAxis(string axisName) { }

	// RVA: 0x2FB0EA0 Offset: 0x2FB00A0 VA: 0x182FB0EA0
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x2FB0EB0 Offset: 0x2FB00B0 VA: 0x182FB0EB0
	public static bool GetButton(string buttonName) { }

	// RVA: 0x2FB0EC0 Offset: 0x2FB00C0 VA: 0x182FB0EC0
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x2FB0ED0 Offset: 0x2FB00D0 VA: 0x182FB0ED0
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x733350 Offset: 0x732550 VA: 0x180733350
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x2FB0EE0 Offset: 0x2FB00E0 VA: 0x182FB0EE0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x7333A0 Offset: 0x7325A0 VA: 0x1807333A0
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x2FB0F30 Offset: 0x2FB0130 VA: 0x182FB0F30
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x2FB0F80 Offset: 0x2FB0180 VA: 0x182FB0F80
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x2FB0FD0 Offset: 0x2FB01D0 VA: 0x182FB0FD0
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x2FB1020 Offset: 0x2FB0220 VA: 0x182FB1020
	public static Touch GetTouch(int index) { }

	[NativeThrows]
	// RVA: 0x2FB10A0 Offset: 0x2FB02A0 VA: 0x182FB10A0
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x733350 Offset: 0x732550 VA: 0x180733350
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x2FB0EE0 Offset: 0x2FB00E0 VA: 0x182FB0EE0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x7333A0 Offset: 0x7325A0 VA: 0x1807333A0
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2FB1110 Offset: 0x2FB0310 VA: 0x182FB1110
	public static bool get_anyKey() { }

	// RVA: 0x2FB1160 Offset: 0x2FB0360 VA: 0x182FB1160
	public static bool get_anyKeyDown() { }

	// RVA: 0x2FB11B0 Offset: 0x2FB03B0 VA: 0x182FB11B0
	public static string get_inputString() { }

	// RVA: 0x2FB1280 Offset: 0x2FB0480 VA: 0x182FB1280
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2FB12E0 Offset: 0x2FB04E0 VA: 0x182FB12E0
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2FB1340 Offset: 0x2FB0540 VA: 0x182FB1340
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x2FB1390 Offset: 0x2FB0590 VA: 0x182FB1390
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2FB13E0 Offset: 0x2FB05E0 VA: 0x182FB13E0
	public static string get_compositionString() { }

	// RVA: 0x2FB14B0 Offset: 0x2FB06B0 VA: 0x182FB14B0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2FB1510 Offset: 0x2FB0710 VA: 0x182FB1510
	public static void set_compositionCursorPos(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2FB1560 Offset: 0x2FB0760 VA: 0x182FB1560
	internal static bool get_simulateTouchEnabled() { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x2FB15A0 Offset: 0x2FB07A0 VA: 0x182FB15A0
	private static bool GetMousePresentInternal() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x2FB15F0 Offset: 0x2FB07F0 VA: 0x182FB15F0
	private static bool GetTouchSupportedInternal() { }

	// RVA: 0x2FB1640 Offset: 0x2FB0840 VA: 0x182FB1640
	public static bool get_mousePresent() { }

	// RVA: 0x2FB16D0 Offset: 0x2FB08D0 VA: 0x182FB16D0
	public static bool get_touchSupported() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x2E87EC0 Offset: 0x2E870C0 VA: 0x182E87EC0
	public static int get_touchCount() { }

	// RVA: 0x2FB1770 Offset: 0x2FB0970 VA: 0x182FB1770
	public static Touch[] get_touches() { }

	// RVA: 0x2FB1910 Offset: 0x2FB0B10 VA: 0x182FB1910
	internal static bool CheckDisabled() { }

	// RVA: 0x2FB1960 Offset: 0x2FB0B60 VA: 0x182FB1960
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2FB19C0 Offset: 0x2FB0BC0 VA: 0x182FB19C0
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x2FB1A10 Offset: 0x2FB0C10 VA: 0x182FB1A10
	private static void get_inputString_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2FB1A60 Offset: 0x2FB0C60 VA: 0x182FB1A60
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2FB1AB0 Offset: 0x2FB0CB0 VA: 0x182FB1AB0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2FB1B00 Offset: 0x2FB0D00 VA: 0x182FB1B00
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2FB1B50 Offset: 0x2FB0D50 VA: 0x182FB1B50
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2FB1BA0 Offset: 0x2FB0DA0 VA: 0x182FB1BA0
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }
}

// Namespace: 
private struct SendMouseEvents.HitInfo // TypeDefIndex: 15997
{
	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x2FB3530 Offset: 0x2FB2730 VA: 0x182FB3530
	public void SendMessage(string name) { }

	// RVA: 0x2FB3560 Offset: 0x2FB2760 VA: 0x182FB3560
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x2FB36E0 Offset: 0x2FB28E0 VA: 0x182FB36E0
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }
}

// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 15998
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x2FB1BF0 Offset: 0x2FB0DF0 VA: 0x182FB1BF0
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x2FB1EF0 Offset: 0x2FB10F0 VA: 0x182FB1EF0
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x2FB1F50 Offset: 0x2FB1150 VA: 0x182FB1F50
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2FB2C70 Offset: 0x2FB1E70 VA: 0x182FB2C70
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2FB3360 Offset: 0x2FB2560 VA: 0x182FB3360
	private static void .cctor() { }
}

// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 15999
{
	// Methods

	[NativeThrows]
	// RVA: 0x2FB3900 Offset: 0x2FB2B00 VA: 0x182FB3900
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x2FB3960 Offset: 0x2FB2B60 VA: 0x182FB3960
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x2FB39C0 Offset: 0x2FB2BC0 VA: 0x182FB39C0
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x2FB3A20 Offset: 0x2FB2C20 VA: 0x182FB3A20
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x2FB3B60 Offset: 0x2FB2D60 VA: 0x182FB3B60
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x2FB3BC0 Offset: 0x2FB2DC0 VA: 0x182FB3BC0
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	// RVA: 0x2FB3D00 Offset: 0x2FB2F00 VA: 0x182FB3D00
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x2FB3D60 Offset: 0x2FB2F60 VA: 0x182FB3D60
	internal static bool GetButton(string buttonName) { }

	[NativeThrows]
	// RVA: 0x2FB3EA0 Offset: 0x2FB30A0 VA: 0x182FB3EA0
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x2FB3F00 Offset: 0x2FB3100 VA: 0x182FB3F00
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x2FB4040 Offset: 0x2FB3240 VA: 0x182FB4040
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x2FB40A0 Offset: 0x2FB32A0 VA: 0x182FB40A0
	internal static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x2FB41E0 Offset: 0x2FB33E0 VA: 0x182FB41E0
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }

	// RVA: 0x2FB4240 Offset: 0x2FB3440 VA: 0x182FB4240
	private static float GetAxis_Injected(ref ManagedSpanWrapper axisName) { }

	// RVA: 0x2FB4290 Offset: 0x2FB3490 VA: 0x182FB4290
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	// RVA: 0x2FB42E0 Offset: 0x2FB34E0 VA: 0x182FB42E0
	private static bool GetButton_Injected(ref ManagedSpanWrapper buttonName) { }

	// RVA: 0x2FB4330 Offset: 0x2FB3530 VA: 0x182FB4330
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }

	// RVA: 0x2FB4380 Offset: 0x2FB3580 VA: 0x182FB4380
	private static bool GetButtonUp_Injected(ref ManagedSpanWrapper buttonName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16000
{}

// Namespace: UnityEngine
public enum FontStyle // TypeDefIndex: 16001
{
	// Fields
	public int value__; // 0x0
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
[Flags]
internal enum TextGenerationError // TypeDefIndex: 16002
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 16003
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x305C1B0 Offset: 0x305B3B0 VA: 0x18305C1B0
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x305C220 Offset: 0x305B420 VA: 0x18305C220
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x305C260 Offset: 0x305B460 VA: 0x18305C260
	public bool Equals(TextGenerationSettings other) { }
}

// Namespace: 
internal static class TextGenerator.BindingsMarshaller // TypeDefIndex: 16004
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(TextGenerator textGenerator) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable // TypeDefIndex: 16005
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x305C590 Offset: 0x305B790 VA: 0x18305C590
	public void .ctor() { }

	// RVA: 0x305C5A0 Offset: 0x305B7A0 VA: 0x18305C5A0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x305C890 Offset: 0x305BA90 VA: 0x18305C890 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x305C900 Offset: 0x305BB00 VA: 0x18305C900 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x305C970 Offset: 0x305BB70 VA: 0x18305C970
	public int get_characterCountVisible() { }

	// RVA: 0x305C9F0 Offset: 0x305BBF0 VA: 0x18305C9F0
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x21C8610 Offset: 0x21C7810 VA: 0x1821C8610
	public void Invalidate() { }

	// RVA: 0x305CE30 Offset: 0x305C030 VA: 0x18305CE30
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x305CEB0 Offset: 0x305C0B0 VA: 0x18305CEB0
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x305CF30 Offset: 0x305C130 VA: 0x18305CF30
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x305CFB0 Offset: 0x305C1B0 VA: 0x18305CFB0
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x305D0A0 Offset: 0x305C2A0 VA: 0x18305D0A0
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x305D190 Offset: 0x305C390 VA: 0x18305D190
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x305D3B0 Offset: 0x305C5B0 VA: 0x18305D3B0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x305D410 Offset: 0x305C610 VA: 0x18305D410
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x305D530 Offset: 0x305C730 VA: 0x18305D530
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x305D9B0 Offset: 0x305CBB0 VA: 0x18305D9B0
	public IList<UIVertex> get_verts() { }

	// RVA: 0x305DA50 Offset: 0x305CC50 VA: 0x18305DA50
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x305DAF0 Offset: 0x305CCF0 VA: 0x18305DAF0
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x305DB90 Offset: 0x305CD90 VA: 0x18305DB90
	public Rect get_rectExtents() { }

	// RVA: 0x305DC20 Offset: 0x305CE20 VA: 0x18305DC20
	public int get_characterCount() { }

	// RVA: 0x305DC90 Offset: 0x305CE90 VA: 0x18305DC90
	public int get_lineCount() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x305DD00 Offset: 0x305CF00 VA: 0x18305DD00
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x305DD50 Offset: 0x305CF50 VA: 0x18305DD50
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x305DDA0 Offset: 0x305CFA0 VA: 0x18305DDA0
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x305E0C0 Offset: 0x305D2C0 VA: 0x18305E0C0
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrows]
	// RVA: 0x305CF30 Offset: 0x305C130 VA: 0x18305CF30
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x305CE30 Offset: 0x305C030 VA: 0x18305CE30
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x305CEB0 Offset: 0x305C0B0 VA: 0x18305CEB0
	private void GetLinesInternal(object lines) { }

	// RVA: 0x305E320 Offset: 0x305D520 VA: 0x18305E320
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x305E380 Offset: 0x305D580 VA: 0x18305E380
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x305E3D0 Offset: 0x305D5D0 VA: 0x18305E3D0
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x305E420 Offset: 0x305D620 VA: 0x18305E420
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x305E500 Offset: 0x305D700 VA: 0x18305E500
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	// RVA: 0x305E560 Offset: 0x305D760 VA: 0x18305E560
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	// RVA: 0x305E5C0 Offset: 0x305D7C0 VA: 0x18305E5C0
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }
}

// Namespace: UnityEngine
public enum TextAnchor // TypeDefIndex: 16006
{
	// Fields
	public int value__; // 0x0
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum TextGeneratorType // TypeDefIndex: 16007
{
	// Fields
	public int value__; // 0x0
	public const TextGeneratorType Standard = 0;
	public const TextGeneratorType Advanced = 1;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode // TypeDefIndex: 16008
{
	// Fields
	public int value__; // 0x0
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode // TypeDefIndex: 16009
{
	// Fields
	public int value__; // 0x0
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UICharInfo // TypeDefIndex: 16010
{
	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UILineInfo // TypeDefIndex: 16011
{
	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UIVertex // TypeDefIndex: 16012
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector4 uv0; // 0x2C
	public Vector4 uv1; // 0x3C
	public Vector4 uv2; // 0x4C
	public Vector4 uv3; // 0x5C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x305E620 Offset: 0x305D820 VA: 0x18305E620
	private static void .cctor() { }
}

// Namespace: 
public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 16013
{
	// Methods

	// RVA: 0x477570 Offset: 0x476770 VA: 0x180477570
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464320 Offset: 0x463520 VA: 0x180464320 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object // TypeDefIndex: 16014
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x305E870 Offset: 0x305DA70 VA: 0x18305E870
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x305E9A0 Offset: 0x305DBA0 VA: 0x18305E9A0
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x305EAD0 Offset: 0x305DCD0 VA: 0x18305EAD0
	public Material get_material() { }

	// RVA: 0x305EB90 Offset: 0x305DD90 VA: 0x18305EB90
	public bool get_dynamic() { }

	// RVA: 0x305EC30 Offset: 0x305DE30 VA: 0x18305EC30
	public int get_fontSize() { }

	// RVA: 0x305ECD0 Offset: 0x305DED0 VA: 0x18305ECD0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x305ED30 Offset: 0x305DF30 VA: 0x18305ED30
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x305EDB0 Offset: 0x305DFB0 VA: 0x18305EDB0
	public bool HasCharacter(char c) { }

	// RVA: 0x305EE60 Offset: 0x305E060 VA: 0x18305EE60
	private bool HasCharacter(int c) { }

	// RVA: 0x305EF10 Offset: 0x305E110 VA: 0x18305EF10
	public static string[] GetPathsToOSFonts() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x305EF60 Offset: 0x305E160 VA: 0x18305EF60
	internal static string[] GetOSFallbacks() { }

	// RVA: 0x305EFB0 Offset: 0x305E1B0 VA: 0x18305EFB0
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x305F100 Offset: 0x305E300 VA: 0x18305F100
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	// RVA: 0x305F150 Offset: 0x305E350 VA: 0x18305F150
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	// RVA: 0x305F1A0 Offset: 0x305E3A0 VA: 0x18305F1A0
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x305F1F0 Offset: 0x305E3F0 VA: 0x18305F1F0
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	// RVA: 0x305F250 Offset: 0x305E450 VA: 0x18305F250
	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16015
{}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public class ITilemap // TypeDefIndex: 16016
{
	// Fields
	internal static ITilemap s_Instance; // 0x0
	internal Tilemap m_Tilemap; // 0x10
	internal bool m_AddToList; // 0x18
	internal int m_RefreshCount; // 0x1C
	internal NativeArray<Vector3Int> m_RefreshPos; // 0x20

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	internal void .ctor() { }

	// RVA: 0x305F2B0 Offset: 0x305E4B0 VA: 0x18305F2B0
	public void RefreshTile(Vector3Int position) { }

	[RequiredByNativeCode]
	// RVA: 0x305F5C0 Offset: 0x305E7C0 VA: 0x18305F5C0
	private static ITilemap CreateInstance() { }

	[RequiredByNativeCode]
	// RVA: 0x305F670 Offset: 0x305E870 VA: 0x18305F670
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x305FAB0 Offset: 0x305ECB0 VA: 0x18305FAB0
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }
}

// Namespace: 
public enum Tile.ColliderType // TypeDefIndex: 16017
{
	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;
}

// Namespace: UnityEngine.Tilemaps
[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
[Serializable]
public class Tile : TileBase // TypeDefIndex: 16018
{
	// Fields
	[SerializeField]
	private Sprite m_Sprite; // 0x18
	[SerializeField]
	private Color m_Color; // 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField]
	private TileFlags m_Flags; // 0x78
	[SerializeField]
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1D98F20 Offset: 0x1D98120 VA: 0x181D98F20
	public Sprite get_sprite() { }

	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	public void set_sprite(Sprite value) { }

	// RVA: 0x305FD30 Offset: 0x305EF30 VA: 0x18305FD30
	public Color get_color() { }

	// RVA: 0x2216AB0 Offset: 0x2215CB0 VA: 0x182216AB0
	public void set_color(Color value) { }

	// RVA: 0x305FD40 Offset: 0x305EF40 VA: 0x18305FD40
	public Matrix4x4 get_transform() { }

	// RVA: 0x305FD70 Offset: 0x305EF70 VA: 0x18305FD70
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x2F964F0 Offset: 0x2F956F0 VA: 0x182F964F0
	public GameObject get_gameObject() { }

	// RVA: 0x4BFFF0 Offset: 0x4BF1F0 VA: 0x1804BFFF0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x2F7D220 Offset: 0x2F7C420 VA: 0x182F7D220
	public TileFlags get_flags() { }

	// RVA: 0x4C0060 Offset: 0x4BF260 VA: 0x1804C0060
	public void set_flags(TileFlags value) { }

	// RVA: 0x305FD90 Offset: 0x305EF90 VA: 0x18305FD90
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x305FDA0 Offset: 0x305EFA0 VA: 0x18305FDA0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x305FDB0 Offset: 0x305EFB0 VA: 0x18305FDB0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x305FE60 Offset: 0x305F060 VA: 0x18305FE60
	public void .ctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject // TypeDefIndex: 16019
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x305FEF0 Offset: 0x305F0F0 VA: 0x18305FEF0 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x305FF30 Offset: 0x305F130 VA: 0x18305FF30
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x11B51F0 Offset: 0x11B43F0 VA: 0x1811B51F0 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x3060010 Offset: 0x305F210 VA: 0x183060010
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x30600A0 Offset: 0x305F2A0 VA: 0x1830600A0
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[RequiredByNativeCode]
	// RVA: 0x11B51F0 Offset: 0x11B43F0 VA: 0x1811B51F0 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[RequiredByNativeCode]
	// RVA: 0x30600E0 Offset: 0x305F2E0 VA: 0x1830600E0
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

	// RVA: 0x496280 Offset: 0x495480 VA: 0x180496280
	protected void .ctor() { }
}

// Namespace: 
[RequiredByNativeCode]
public struct Tilemap.SyncTile // TypeDefIndex: 16020
{
	// Fields
	internal Vector3Int m_Position; // 0x0
	internal TileBase m_Tile; // 0x10
	internal TileData m_TileData; // 0x18
}

// Namespace: 
internal struct Tilemap.SyncTileCallbackSettings // TypeDefIndex: 16021
{
	// Fields
	internal bool hasSyncTileCallback; // 0x0
	internal bool hasPositionsChangedCallback; // 0x1
	internal bool isBufferSyncTile; // 0x2
}

// Namespace: UnityEngine.Tilemaps
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[RequireComponent(typeof(Transform))]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
public sealed class Tilemap : GridLayout // TypeDefIndex: 16022
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Tilemap, Tilemap.SyncTile[]> tilemapTileChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Tilemap, NativeArray<Vector3Int>> loopEndedForTileAnimation; // 0x10
	private bool m_BufferSyncTile; // 0x18

	// Properties
	internal bool bufferSyncTile { get; }

	// Methods

	// RVA: 0x3060120 Offset: 0x305F320 VA: 0x183060120
	internal bool get_bufferSyncTile() { }

	// RVA: 0x3060130 Offset: 0x305F330 VA: 0x183060130
	internal static bool HasLoopEndedForTileAnimationCallback() { }

	// RVA: 0x3060170 Offset: 0x305F370 VA: 0x183060170
	private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x3060220 Offset: 0x305F420 VA: 0x183060220
	private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions) { }

	// RVA: 0x30602D0 Offset: 0x305F4D0 VA: 0x1830602D0
	internal static bool HasSyncTileCallback() { }

	// RVA: 0x3060310 Offset: 0x305F510 VA: 0x183060310
	internal static bool HasPositionsChangedCallback() { }

	// RVA: 0x3060350 Offset: 0x305F550 VA: 0x183060350
	private void HandleSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x30603B0 Offset: 0x305F5B0 VA: 0x1830603B0
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x3060460 Offset: 0x305F660 VA: 0x183060460
	private void SendTilemapTileChangedCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x3060510 Offset: 0x305F710 VA: 0x183060510
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[NativeMethod(Name = "RefreshTileAsset")]
	// RVA: 0x30605C0 Offset: 0x305F7C0 VA: 0x1830605C0
	public void RefreshTile(Vector3Int position) { }

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	// RVA: 0x3060670 Offset: 0x305F870 VA: 0x183060670
	internal void RefreshTilesNative(void* positions, int count) { }

	[RequiredByNativeCode]
	// RVA: 0x3060730 Offset: 0x305F930 VA: 0x183060730
	internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback) { }

	[RequiredByNativeCode]
	// RVA: 0x3060170 Offset: 0x305F370 VA: 0x183060170
	private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x3060780 Offset: 0x305F980 VA: 0x183060780
	internal void GetSyncTileCallbackSettings(ref Tilemap.SyncTileCallbackSettings settings) { }

	[RequiredByNativeCode]
	// RVA: 0x3060350 Offset: 0x305F550 VA: 0x183060350
	private void DoSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	[RequiredByNativeCode]
	// RVA: 0x30603B0 Offset: 0x305F5B0 VA: 0x1830603B0
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x3060820 Offset: 0x305FA20 VA: 0x183060820
	private static void RefreshTile_Injected(IntPtr _unity_self, in Vector3Int position) { }

	// RVA: 0x3060880 Offset: 0x305FA80 VA: 0x183060880
	private static void RefreshTilesNative_Injected(IntPtr _unity_self, void* positions, int count) { }
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileFlags // TypeDefIndex: 16023
{
	// Fields
	public int value__; // 0x0
	public const TileFlags None = 0;
	public const TileFlags LockColor = 1;
	public const TileFlags LockTransform = 2;
	public const TileFlags InstantiateGameObjectRuntimeOnly = 4;
	public const TileFlags KeepGameObjectRuntimeOnly = 8;
	public const TileFlags LockAll = 3;
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileAnimationFlags // TypeDefIndex: 16024
{
	// Fields
	public int value__; // 0x0
	public const TileAnimationFlags None = 0;
	public const TileAnimationFlags LoopOnce = 1;
	public const TileAnimationFlags PauseAnimation = 2;
	public const TileAnimationFlags UpdatePhysics = 4;
	public const TileAnimationFlags UnscaledTime = 8;
	public const TileAnimationFlags SyncAnimation = 16;
}

// Namespace: UnityEngine.Tilemaps
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[RequireComponent(typeof(Tilemap))]
public sealed class TilemapRenderer : Renderer // TypeDefIndex: 16025
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x30608F0 Offset: 0x305FAF0 VA: 0x1830608F0
	internal void RegisterSpriteAtlasRegistered() { }

	[RequiredByNativeCode]
	// RVA: 0x3060970 Offset: 0x305FB70 VA: 0x183060970
	internal void UnregisterSpriteAtlasRegistered() { }

	// RVA: 0x3060B00 Offset: 0x305FD00 VA: 0x183060B00
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	// RVA: 0x3060BE0 Offset: 0x305FDE0 VA: 0x183060BE0
	private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas) { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileData // TypeDefIndex: 16026
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
	internal static readonly TileData Default; // 0x0

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x3060C40 Offset: 0x305FE40 VA: 0x183060C40
	public void set_sprite(Sprite value) { }

	// RVA: 0x2E00070 Offset: 0x2DFF270 VA: 0x182E00070
	public void set_color(Color value) { }

	// RVA: 0x3060D30 Offset: 0x305FF30 VA: 0x183060D30
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x3060D50 Offset: 0x305FF50 VA: 0x183060D50
	public void set_gameObject(GameObject value) { }

	// RVA: 0x75EC50 Offset: 0x75DE50 VA: 0x18075EC50
	public void set_flags(TileFlags value) { }

	// RVA: 0xCE42D0 Offset: 0xCE34D0 VA: 0x180CE42D0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x3060E40 Offset: 0x3060040 VA: 0x183060E40
	private static TileData CreateDefault() { }

	// RVA: 0x3060F80 Offset: 0x3060180 VA: 0x183060F80
	private static void .cctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
internal struct TileDataNative // TypeDefIndex: 16027
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[Serializable]
public struct TileChangeData // TypeDefIndex: 16028
{
	// Fields
	[SerializeField]
	private Vector3Int m_Position; // 0x0
	[SerializeField]
	private Object m_TileAsset; // 0x10
	[SerializeField]
	private Color m_Color; // 0x18
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x28
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileAnimationData // TypeDefIndex: 16029
{
	// Fields
	private Sprite[] m_AnimatedSprites; // 0x0
	private float m_AnimationSpeed; // 0x8
	private float m_AnimationStartTime; // 0xC
	private TileAnimationFlags m_Flags; // 0x10
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16030
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 16031
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x2FB8DF0 Offset: 0x2FB7FF0 VA: 0x182FB8DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17318B0 Offset: 0x1730AB0 VA: 0x1817318B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FB8EC0 Offset: 0x2FB80C0 VA: 0x182FB8EC0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2EE81D0 Offset: 0x2EE73D0 VA: 0x182EE81D0 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x2FB8F50 Offset: 0x2FB8150 VA: 0x182FB8F50
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x2FB90B0 Offset: 0x2FB82B0 VA: 0x182FB90B0
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x2FB91B0 Offset: 0x2FB83B0 VA: 0x182FB91B0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2FB9300 Offset: 0x2FB8500 VA: 0x182FB9300
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2FB9360 Offset: 0x2FB8560 VA: 0x182FB9360
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastArray_Binding")]
	// RVA: 0x2FB9400 Offset: 0x2FB8600 VA: 0x182FB9400
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x2FB9520 Offset: 0x2FB8720 VA: 0x182FB9520
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2FB9870 Offset: 0x2FB8A70 VA: 0x182FB9870
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethod("GetRayIntersectionArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x2FB99B0 Offset: 0x2FB8BB0 VA: 0x182FB99B0
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x2FB9AD0 Offset: 0x2FB8CD0 VA: 0x182FB9AD0
	private static void Raycast_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2FB9B60 Offset: 0x2FB8D60 VA: 0x182FB9B60
	private static int RaycastArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref ManagedSpanWrapper results) { }

	// RVA: 0x2FB9BF0 Offset: 0x2FB8DF0 VA: 0x182FB9BF0
	private static int RaycastList_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref BlittableListWrapper results) { }

	// RVA: 0x2FB9C80 Offset: 0x2FB8E80 VA: 0x182FB9C80
	private static int GetRayIntersectionArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results) { }
}

// Namespace: UnityEngine
[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[StaticAccessor("GetPhysicsManager2D()", 1)]
[NativeHeader("Physics2DScriptingClasses.h")]
public class Physics2D // TypeDefIndex: 16032
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0x12A52B0 Offset: 0x12A44B0 VA: 0x1812A52B0
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x2FB9D10 Offset: 0x2FB8F10 VA: 0x182FB9D10
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocs]
	// RVA: 0x2FB9D60 Offset: 0x2FB8F60 VA: 0x182FB9D60
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x2FB9E40 Offset: 0x2FB9040 VA: 0x182FB9E40
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2FB9F20 Offset: 0x2FB9120 VA: 0x182FB9F20
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x2FBA0E0 Offset: 0x2FB92E0 VA: 0x182FBA0E0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2FBA2A0 Offset: 0x2FB94A0 VA: 0x182FBA2A0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x2FBA460 Offset: 0x2FB9660 VA: 0x182FBA460
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2FBA610 Offset: 0x2FB9810 VA: 0x182FBA610
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x2FBA7C0 Offset: 0x2FB99C0 VA: 0x182FBA7C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x2FBA890 Offset: 0x2FB9A90 VA: 0x182FBA890
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x2FBA930 Offset: 0x2FB9B30 VA: 0x182FBA930
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x2FBA9D0 Offset: 0x2FB9BD0 VA: 0x182FBA9D0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	// RVA: 0x2FBAA80 Offset: 0x2FB9C80 VA: 0x182FBAA80
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[RequiredByNativeCode]
	// RVA: 0x2FBAD30 Offset: 0x2FB9F30 VA: 0x182FBAD30
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	[EditorBrowsable(1)]
	[ExcludeFromDocs]
	// RVA: 0x2FBAED0 Offset: 0x2FBA0D0 VA: 0x182FBAED0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	[EditorBrowsable(1)]
	[ExcludeFromDocs]
	// RVA: 0x2FBB060 Offset: 0x2FBA260 VA: 0x182FBB060
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	// RVA: 0x2FBB1F0 Offset: 0x2FBA3F0 VA: 0x182FBB1F0
	private static void .cctor() { }

	// RVA: 0x2FBB2D0 Offset: 0x2FBA4D0 VA: 0x182FBB2D0
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[NativeClass("ContactFilter", "struct ContactFilter;")]
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 16033
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x2FBB360 Offset: 0x2FBA560 VA: 0x182FBB360
	private void CheckConsistency() { }

	// RVA: 0x2FBB3B0 Offset: 0x2FBA5B0 VA: 0x182FBB3B0
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x2FBB3C0 Offset: 0x2FBA5C0 VA: 0x182FBB3C0
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x2FBB420 Offset: 0x2FBA620 VA: 0x182FBB420
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class Collision2D // TypeDefIndex: 16034
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38
}

// Namespace: UnityEngine
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
public struct ContactPoint2D // TypeDefIndex: 16035
{
	// Fields
	[NativeName("point")]
	private Vector2 m_Point; // 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeName("friction")]
	private float m_Friction; // 0x18
	[NativeName("bounciness")]
	private float m_Bounciness; // 0x1C
	[NativeName("separation")]
	private float m_Separation; // 0x20
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; // 0x24
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; // 0x28
	[NativeName("collider")]
	private int m_Collider; // 0x2C
	[NativeName("otherCollider")]
	private int m_OtherCollider; // 0x30
	[NativeName("rigidbody")]
	private int m_Rigidbody; // 0x34
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; // 0x38
	[NativeName("enabled")]
	private int m_Enabled; // 0x3C
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
public struct RaycastHit2D // TypeDefIndex: 16036
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component // TypeDefIndex: 16037
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 16038
{}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SubsystemsAnalyticBase : AnalyticsEventBase // TypeDefIndex: 16039
{
	// Fields
	public string subsystem; // 0x30

	// Methods

	// RVA: 0x3111210 Offset: 0x3110410 VA: 0x183111210
	public void .ctor(string eventName) { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class SubsystemsAnalyticStart : SubsystemsAnalyticBase // TypeDefIndex: 16040
{
	// Methods

	// RVA: 0x3111280 Offset: 0x3110480 VA: 0x183111280
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111310 Offset: 0x3110510 VA: 0x183111310
	internal static SubsystemsAnalyticStart CreateSubsystemsAnalyticStart() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SubsystemsAnalyticStop : SubsystemsAnalyticBase // TypeDefIndex: 16041
{
	// Methods

	// RVA: 0x31113D0 Offset: 0x31105D0 VA: 0x1831113D0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111460 Offset: 0x3110660 VA: 0x183111460
	internal static SubsystemsAnalyticStop CreateSubsystemsAnalyticStop() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase // TypeDefIndex: 16042
{
	// Fields
	private string id; // 0x38
	private string plugin_name; // 0x40
	private string version; // 0x48
	private string library_name; // 0x50

	// Methods

	// RVA: 0x3111520 Offset: 0x3110720 VA: 0x183111520
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x31115B0 Offset: 0x31107B0 VA: 0x1831115B0
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class VRDeviceAnalyticBase : AnalyticsEventBase // TypeDefIndex: 16043
{
	// Methods

	// RVA: 0x3111670 Offset: 0x3110870 VA: 0x183111670
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceAnalyticAspect : VRDeviceAnalyticBase // TypeDefIndex: 16044
{
	// Fields
	public float vr_aspect_ratio; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x31116E0 Offset: 0x31108E0 VA: 0x1831116E0
	internal static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect() { }

	// RVA: 0x3111730 Offset: 0x3110930 VA: 0x183111730
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceMirrorAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 16045
{
	// Fields
	public bool vr_device_mirror_mode; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3111740 Offset: 0x3110940 VA: 0x183111740
	internal static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic() { }

	// RVA: 0x3111730 Offset: 0x3110930 VA: 0x183111730
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceUserAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 16046
{
	// Fields
	public int vr_user_presence; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3111790 Offset: 0x3110990 VA: 0x183111790
	internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic() { }

	// RVA: 0x3111730 Offset: 0x3110930 VA: 0x183111730
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 16047
{
	// Fields
	public string[] vr_active_controllers; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x31117E0 Offset: 0x31109E0 VA: 0x1831117E0
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

	// RVA: 0x3111730 Offset: 0x3110930 VA: 0x183111730
	public void .ctor() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class AssetDatabaseRefreshAnalytic : AnalyticsEventBase // TypeDefIndex: 16048
{
	// Fields
	[SerializeField]
	public bool isV2; // 0x30
	[SerializeField]
	public long Imports_Imported; // 0x38
	[SerializeField]
	public long Imports_ImportedInProcess; // 0x40
	[SerializeField]
	public long Imports_ImportedOutOfProcess; // 0x48
	[SerializeField]
	public long Imports_Refresh; // 0x50
	[SerializeField]
	public long Imports_DomainReload; // 0x58
	[SerializeField]
	public long CacheServer_MetadataRequested; // 0x60
	[SerializeField]
	public long CacheServer_MetadataDownloaded; // 0x68
	[SerializeField]
	public long CacheServer_MetadataFailedToDownload; // 0x70
	[SerializeField]
	public long CacheServer_MetadataUploaded; // 0x78
	[SerializeField]
	public long CacheServer_ArtifactsFailedToUpload; // 0x80
	[SerializeField]
	public long CacheServer_MetadataVersionsDownloaded; // 0x88
	[SerializeField]
	public long CacheServer_MetadataMatched; // 0x90
	[SerializeField]
	public long CacheServer_ArtifactsDownloaded; // 0x98
	[SerializeField]
	public long CacheServer_ArtifactFilesDownloaded; // 0xA0
	[SerializeField]
	public long CacheServer_ArtifactFilesFailedToDownload; // 0xA8
	[SerializeField]
	public long CacheServer_ArtifactsUploaded; // 0xB0
	[SerializeField]
	public long CacheServer_ArtifactFilesUploaded; // 0xB8
	[SerializeField]
	public long CacheServer_ArtifactFilesFailedToUpload; // 0xC0
	[SerializeField]
	public long CacheServer_Connects; // 0xC8
	[SerializeField]
	public long CacheServer_Disconnects; // 0xD0

	// Methods

	// RVA: 0x3111830 Offset: 0x3110A30 VA: 0x183111830
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x31118A0 Offset: 0x3110AA0 VA: 0x1831118A0
	internal static AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class BuildAssetBundleAnalytic : AnalyticsEventBase // TypeDefIndex: 16049
{
	// Fields
	public bool success; // 0x30
	public string error; // 0x38

	// Methods

	// RVA: 0x3111940 Offset: 0x3110B40 VA: 0x183111940
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x31119B0 Offset: 0x3110BB0 VA: 0x1831119B0
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class CollabOperationAnalytic : AnalyticsEventBase // TypeDefIndex: 16050
{
	// Fields
	public string category; // 0x30
	public string operation; // 0x38
	public string result; // 0x40
	public long start_ts; // 0x48
	public long duration; // 0x50

	// Methods

	// RVA: 0x3111A50 Offset: 0x3110C50 VA: 0x183111A50
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111AC0 Offset: 0x3110CC0 VA: 0x183111AC0
	internal static CollabOperationAnalytic CreateCollabOperationAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class LicensingErrorAnalytic : AnalyticsEventBase // TypeDefIndex: 16051
{
	// Fields
	public string licensingErrorType; // 0x30
	public string additionalData; // 0x38
	public string errorMessage; // 0x40
	public string correlationId; // 0x48
	public string sessionId; // 0x50

	// Methods

	// RVA: 0x3111B60 Offset: 0x3110D60 VA: 0x183111B60
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111BD0 Offset: 0x3110DD0 VA: 0x183111BD0
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class LicensingInitAnalytic : AnalyticsEventBase // TypeDefIndex: 16052
{
	// Fields
	public string licensingProtocolVersion; // 0x30
	public string licensingClientVersion; // 0x38
	public string channelType; // 0x40
	public double initTime; // 0x48
	public bool isLegacy; // 0x50
	public string sessionId; // 0x58
	public string correlationId; // 0x60

	// Methods

	// RVA: 0x3111C70 Offset: 0x3110E70 VA: 0x183111C70
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111CE0 Offset: 0x3110EE0 VA: 0x183111CE0
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class MetalPatchShaderComputeBufferAnalytic : AnalyticsEventBase // TypeDefIndex: 16053
{
	// Methods

	// RVA: 0x3111D80 Offset: 0x3110F80 VA: 0x183111D80
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111DF0 Offset: 0x3110FF0 VA: 0x183111DF0
	internal static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class NavmeshBakingAnalytic : AnalyticsEventBase // TypeDefIndex: 16054
{
	// Fields
	private bool new_nav_api; // 0x30
	private bool bake_at_runtime; // 0x31
	private int height_meshes_count; // 0x34
	private int offmesh_links_count; // 0x38

	// Methods

	// RVA: 0x3111E90 Offset: 0x3111090 VA: 0x183111E90
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3111F00 Offset: 0x3111100 VA: 0x183111F00
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase // TypeDefIndex: 16055
{
	// Fields
	private int agent_types_count; // 0x30
	private int areas_count; // 0x34

	// Methods

	// RVA: 0x3111FA0 Offset: 0x31111A0 VA: 0x183111FA0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112010 Offset: 0x3111210 VA: 0x183112010
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SendGameBuildAnalytic : AnalyticsEventBase // TypeDefIndex: 16056
{
	// Fields
	private int navmesh_count; // 0x30

	// Methods

	// RVA: 0x31120B0 Offset: 0x31112B0 VA: 0x1831120B0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112120 Offset: 0x3111320 VA: 0x183112120
	internal static SendGameBuildAnalytic CreateSendGameBuildAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class PackageManagerBaseAnalytic : AnalyticsEventBase // TypeDefIndex: 16057
{
	// Fields
	public long start_ts; // 0x30
	public long duration; // 0x38
	public bool blocking; // 0x40
	public string package_id; // 0x48
	public int status_code; // 0x50
	public string error_message; // 0x58

	// Methods

	// RVA: 0x31121C0 Offset: 0x31113C0 VA: 0x1831121C0
	public void .ctor(string eventName) { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerAddPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16058
{
	// Methods

	// RVA: 0x3112230 Offset: 0x3111430 VA: 0x183112230
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x31122C0 Offset: 0x31114C0 VA: 0x1831122C0
	internal static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerTestAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16059
{
	// Methods

	// RVA: 0x3112380 Offset: 0x3111580 VA: 0x183112380
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112410 Offset: 0x3111610 VA: 0x183112410
	internal static PackageManagerTestAnalytic CreatePackageManagerTestAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerRemovePackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16060
{
	// Methods

	// RVA: 0x31124D0 Offset: 0x31116D0 VA: 0x1831124D0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112560 Offset: 0x3111760 VA: 0x183112560
	internal static PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16061
{
	// Fields
	public string[] packages; // 0x60
	public string[] package_registries; // 0x68
	public string[] package_signatures; // 0x70
	public string[] package_sources; // 0x78
	public string[] package_types; // 0x80

	// Methods

	// RVA: 0x3112620 Offset: 0x3111820 VA: 0x183112620
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x31126B0 Offset: 0x31118B0 VA: 0x1831126B0
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerEmbedPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16062
{
	// Methods

	// RVA: 0x3112770 Offset: 0x3111970 VA: 0x183112770
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112800 Offset: 0x3111A00 VA: 0x183112800
	internal static PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResetPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16063
{
	// Methods

	// RVA: 0x31128C0 Offset: 0x3111AC0 VA: 0x1831128C0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112950 Offset: 0x3111B50 VA: 0x183112950
	internal static PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16064
{
	// Fields
	public string reason; // 0x60
	public string action; // 0x68

	// Methods

	// RVA: 0x3112A10 Offset: 0x3111C10 VA: 0x183112A10
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112AA0 Offset: 0x3111CA0 VA: 0x183112AA0
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class PackageManagerStartServerPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 16065
{
	// Methods

	// RVA: 0x3112B60 Offset: 0x3111D60 VA: 0x183112B60
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112BF0 Offset: 0x3111DF0 VA: 0x183112BF0
	internal static PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class AssetImportStatusAnalytic : AnalyticsEventBase // TypeDefIndex: 16066
{
	// Fields
	public string package_name; // 0x30
	public int package_items_count; // 0x38
	public int package_import_status; // 0x3C
	public string error_message; // 0x40
	public int project_assets_count; // 0x48
	public int unselected_assets_count; // 0x4C
	public int selected_new_assets_count; // 0x50
	public int selected_changed_assets_count; // 0x54
	public int unchanged_assets_count; // 0x58
	public string[] selected_asset_extensions; // 0x60

	// Methods

	// RVA: 0x3112CB0 Offset: 0x3111EB0 VA: 0x183112CB0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112D30 Offset: 0x3111F30 VA: 0x183112D30
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class AssetImportAnalytic : AnalyticsEventBase // TypeDefIndex: 16067
{
	// Fields
	public string package_name; // 0x30
	public int package_import_choice; // 0x38

	// Methods

	// RVA: 0x3112DE0 Offset: 0x3111FE0 VA: 0x183112DE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112E50 Offset: 0x3112050 VA: 0x183112E50
	public static AssetImportAnalytic CreateAssetImportAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class AssetExportAnalytic : AnalyticsEventBase // TypeDefIndex: 16068
{
	// Fields
	public string package_name; // 0x30
	public string error_message; // 0x38
	public int items_count; // 0x40
	public string[] asset_extensions; // 0x48
	public bool include_upm_dependencies; // 0x50

	// Methods

	// RVA: 0x3112EF0 Offset: 0x31120F0 VA: 0x183112EF0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3112F60 Offset: 0x3112160 VA: 0x183112F60
	public static AssetExportAnalytic CreateAssetExportAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class StallSummaryAnalytic : AnalyticsEventBase // TypeDefIndex: 16069
{
	// Fields
	public double Duration; // 0x30

	// Methods

	// RVA: 0x3113000 Offset: 0x3112200 VA: 0x183113000
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3113070 Offset: 0x3112270 VA: 0x183113070
	internal static StallSummaryAnalytic CreateStallSummaryAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class StallMarkerAnalytic : AnalyticsEventBase // TypeDefIndex: 16070
{
	// Fields
	public string Name; // 0x30
	public bool HasProgressMarkup; // 0x38
	public double Duration; // 0x40

	// Methods

	// RVA: 0x3113110 Offset: 0x3112310 VA: 0x183113110
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3113180 Offset: 0x3112380 VA: 0x183113180
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class TestAnalytic : AnalyticsEventBase // TypeDefIndex: 16071
{
	// Fields
	public int param; // 0x30

	// Methods

	// RVA: 0x3113220 Offset: 0x3112420 VA: 0x183113220
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x3113290 Offset: 0x3112490 VA: 0x183113290
	public static TestAnalytic CreateTestAnalytic() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16072
{}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4, Inherited = False)]
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 16073
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x4ED520 Offset: 0x4EC720 VA: 0x1804ED520
	public void .ctor(string preferredExtension, string[] otherExtensions) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 16074
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(2048, AllowMultiple = False)]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute // TypeDefIndex: 16075
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4)]
internal class RejectDragAndDropMaterial : Attribute // TypeDefIndex: 16076
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(1)]
[VisibleToOtherModules]
internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 16077
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(12, Inherited = False)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 16078
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <QualifiedNativeName>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Declaration>k__BackingField; // 0x18

	// Properties
	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	private void set_QualifiedNativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	private void set_Declaration(string value) { }

	// RVA: 0x2FEA340 Offset: 0x2FE9540 VA: 0x182FEA340
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x4ED520 Offset: 0x4EC720 VA: 0x1804ED520
	public void .ctor(string qualifiedCppName, string declaration) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal sealed class UnityString // TypeDefIndex: 16079
{
	// Methods

	// RVA: 0x2FEA440 Offset: 0x2FE9640 VA: 0x182FEA440
	public static string Format(string fmt, object[] args) { }
}

// Namespace: UnityEngine.Bindings
[Usage(5628, Inherited = False)]
[VisibleToOtherModules]
internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 16080
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor(string[] modules) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 16081
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Condition>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x18

	// Properties
	public string Condition { set; }
	public bool Enabled { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_Condition(string value) { }

	[CompilerGenerated]
	// RVA: 0x5FEC10 Offset: 0x5FDE10 VA: 0x1805FEC10
	public void set_Enabled(bool value) { }

	// RVA: 0x242F890 Offset: 0x242EA90 VA: 0x18242F890
	public void .ctor(string condition) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10716, AllowMultiple = True)]
internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 16082
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10

	// Properties
	public string Header { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0 Slot: 4
	public void set_Header(string value) { }

	// RVA: 0x2FEA5B0 Offset: 0x2FE97B0 VA: 0x182FEA5B0
	public void .ctor(string header) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(448)]
internal class NativeNameAttribute : Attribute // TypeDefIndex: 16083
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0 Slot: 4
	public void set_Name(string value) { }

	// RVA: 0x2FEA720 Offset: 0x2FE9920 VA: 0x182FEA720
	public void .ctor(string name) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeMethodAttribute : Attribute // TypeDefIndex: 16084
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0 Slot: 4
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x5FEC10 Offset: 0x5FDE10 VA: 0x1805FEC10 Slot: 5
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6F35F0 Offset: 0x6F27F0 VA: 0x1806F35F0 Slot: 6
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2FEA890 Offset: 0x2FE9A90 VA: 0x182FEA890 Slot: 7
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2920920 Offset: 0x291FB20 VA: 0x182920920 Slot: 8
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2FEA8A0 Offset: 0x2FE9AA0 VA: 0x182FEA8A0
	public void .ctor(string name) { }

	// RVA: 0x2FEAA10 Offset: 0x2FE9C10 VA: 0x182FEAA10
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x2FEAA40 Offset: 0x2FE9C40 VA: 0x182FEAA40
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum TargetType // TypeDefIndex: 16085
{
	// Fields
	public int value__; // 0x0
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
[Usage(128)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 16086
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TargetType <TargetType>k__BackingField; // 0x20

	// Properties
	public TargetType TargetType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4EDA80 Offset: 0x4ECC80 VA: 0x1804EDA80
	public void set_TargetType(TargetType value) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2FEAA80 Offset: 0x2FE9C80 VA: 0x182FEAA80
	public void .ctor(string name) { }

	// RVA: 0x2FEAA90 Offset: 0x2FE9C90 VA: 0x182FEAA90
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x2FEAAD0 Offset: 0x2FE9CD0 VA: 0x182FEAAD0
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum CodegenOptions // TypeDefIndex: 16087
{
	// Fields
	public int value__; // 0x0
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4)]
internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 16088
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(28)]
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 16089
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0 Slot: 4
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x4ED5D0 Offset: 0x4EC7D0 VA: 0x1804ED5D0
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4EDA80 Offset: 0x4ECC80 VA: 0x1804EDA80 Slot: 5
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x4BCCB0 Offset: 0x4BBEB0 VA: 0x1804BCCB0
	public void .ctor() { }

	// RVA: 0x4EDA80 Offset: 0x4ECC80 VA: 0x1804EDA80
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x2FEAB10 Offset: 0x2FE9D10 VA: 0x182FEAB10
	public void .ctor(string header) { }

	// RVA: 0x2FEAC90 Offset: 0x2FE9E90 VA: 0x182FEAC90
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(2048)]
internal class NotNullAttribute : Attribute // TypeDefIndex: 16090
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10240)]
internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 16091
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 16092
{
	// Methods

	// RVA: 0x2FEACF0 Offset: 0x2FE9EF0 VA: 0x182FEACF0
	public void .ctor() { }

	// RVA: 0x2FEAD00 Offset: 0x2FE9F00 VA: 0x182FEAD00
	public void .ctor(string name) { }

	// RVA: 0x2FEAD20 Offset: 0x2FE9F20 VA: 0x182FEAD20
	public void .ctor(string name, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 16093
{
	// Methods

	// RVA: 0x2FEAD50 Offset: 0x2FE9F50 VA: 0x182FEAD50
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum StaticAccessorType // TypeDefIndex: 16094
{
	// Fields
	public int value__; // 0x0
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
[Usage(204)]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 16095
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x73C890 Offset: 0x73BA90 VA: 0x18073C890
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	internal void .ctor(string name) { }

	// RVA: 0xCDED30 Offset: 0xCDDF30 VA: 0x180CDED30
	public void .ctor(string name, StaticAccessorType type) { }
}

// Namespace: UnityEngine.Bindings
[Usage(192)]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 16096
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties
	public bool ThrowsException { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490E20 Offset: 0x490020 VA: 0x180490E20 Slot: 4
	public void set_ThrowsException(bool value) { }

	// RVA: 0x72BB20 Offset: 0x72AD20 VA: 0x18072BB20
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(256)]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute // TypeDefIndex: 16097
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public bool DoesNotContributeToSize { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x490E20 Offset: 0x490020 VA: 0x180490E20
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4, AllowMultiple = False, Inherited = False)]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 16098
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: UnityEngine.Scripting
[VisibleToOtherModules]
[Usage(1532, Inherited = False)]
internal class UsedByNativeCodeAttribute : Attribute // TypeDefIndex: 16099
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_Name(string value) { }
}

// Namespace: UnityEngine.Scripting
[VisibleToOtherModules]
[Usage(1532, Inherited = False)]
internal class RequiredByNativeCodeAttribute : Attribute // TypeDefIndex: 16100
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Optional>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Properties
	public string Name { set; }
	public bool Optional { set; }
	public bool GenerateProxy { set; }

	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void .ctor(string name) { }

	// RVA: 0x5FEC10 Offset: 0x5FDE10 VA: 0x1805FEC10
	public void .ctor(bool optional) { }

	[CompilerGenerated]
	// RVA: 0x490DC0 Offset: 0x48FFC0 VA: 0x180490DC0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x5FEC10 Offset: 0x5FDE10 VA: 0x1805FEC10
	public void set_Optional(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6F35F0 Offset: 0x6F27F0 VA: 0x1806F35F0
	public void set_GenerateProxy(bool value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16101
{}

// Namespace: 
internal static class IntegratedSubsystem.BindingsMarshaller // TypeDefIndex: 16102
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem // TypeDefIndex: 16103
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Methods

	// RVA: 0x2FEAD60 Offset: 0x2FE9F60 VA: 0x182FEAD60
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }

	// RVA: 0x2FEADE0 Offset: 0x2FE9FE0 VA: 0x182FEADE0
	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }
}

// Namespace: UnityEngine
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 16104
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 16105
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string id { get; }

	// Methods

	// RVA: 0x2FEAE40 Offset: 0x2FEA040 VA: 0x182FEAE40 Slot: 4
	public string get_id() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	protected void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
[UsedByNativeCode("SubsystemDescriptor")]
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 16106
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-IntegratedSubsystemDescriptor<object>..ctor
	*/
}

// Namespace: UnityEngine
internal static class SubsystemDescriptorBindings // TypeDefIndex: 16107
{
	// Methods

	// RVA: 0x2FEAE50 Offset: 0x2FEA050 VA: 0x182FEAE50
	public static string GetId(IntPtr descriptorPtr) { }

	// RVA: 0x2FEAF20 Offset: 0x2FEA120 VA: 0x182FEAF20
	private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 16108
{
	// Properties
	public abstract string id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_id();
}

// Namespace: UnityEngine
[Obsolete("Use SubsystemWithProvider instead.", False)]
public abstract class Subsystem // TypeDefIndex: 16109
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	protected void .ctor() { }
}

// Namespace: UnityEngine
[Obsolete("Use SubsystemDescriptorWithProvider instead.", False)]
public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 16110
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0 Slot: 4
	public string get_id() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal static class Internal_SubsystemDescriptors // TypeDefIndex: 16111
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2FEAF80 Offset: 0x2FEA180 VA: 0x182FEAF80
	internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager // TypeDefIndex: 16112
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action beforeReloadSubsystems; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsStarted; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2FEB030 Offset: 0x2FEA230 VA: 0x182FEB030
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCode]
	// RVA: 0x2FEB120 Offset: 0x2FEA320 VA: 0x182FEB120
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	// RVA: 0x2FEB210 Offset: 0x2FEA410 VA: 0x182FEB210
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	// RVA: 0x2FEB350 Offset: 0x2FEA550 VA: 0x182FEB350
	private static void ClearSubsystems() { }

	// RVA: 0x2FEB5E0 Offset: 0x2FEA7E0 VA: 0x182FEB5E0
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x2FEB630 Offset: 0x2FEA830 VA: 0x182FEB630
	private static void .cctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	// RVA: 0x2FEB8D0 Offset: 0x2FEAAD0 VA: 0x182FEB8D0
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }
}

// Namespace: UnityEngine.SubsystemsImplementation
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore // TypeDefIndex: 16113
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2FEBA60 Offset: 0x2FEAC60 VA: 0x182FEBA60
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCode]
	// RVA: 0x2FEBB40 Offset: 0x2FEAD40 VA: 0x182FEBB40
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x2FEBD30 Offset: 0x2FEAF30 VA: 0x182FEBD30
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB630 Offset: 0x11CA830 VA: 0x1811CB630
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|
	|-RVA: 0x11CB900 Offset: 0x11CAB00 VA: 0x1811CB900
	|-SubsystemDescriptorStore.RegisterDescriptor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FEBE90 Offset: 0x2FEB090 VA: 0x182FEBE90
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x2FEBF10 Offset: 0x2FEB110 VA: 0x182FEBF10
	private static void .cctor() { }

	// RVA: 0x2FEC160 Offset: 0x2FEB360 VA: 0x182FEC160
	private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id) { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 16114
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0 Slot: 4
	public string get_id() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemWithProvider // TypeDefIndex: 16115
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	protected void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16116
{}

// Namespace: UnityEngine.Experimental.Video
[RequiredByNativeCode]
[StaticAccessor("VideoClipPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable> // TypeDefIndex: 16117
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x16C0C90 Offset: 0x16BFE90 VA: 0x1816C0C90 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x311CFA0 Offset: 0x311C1A0 VA: 0x18311CFA0 Slot: 5
	public bool Equals(VideoClipPlayable other) { }
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
public sealed class VideoClip : Object // TypeDefIndex: 16118
{}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoRenderMode // TypeDefIndex: 16119
{
	// Fields
	public int value__; // 0x0
	public const VideoRenderMode CameraFarPlane = 0;
	public const VideoRenderMode CameraNearPlane = 1;
	public const VideoRenderMode RenderTexture = 2;
	public const VideoRenderMode MaterialOverride = 3;
	public const VideoRenderMode APIOnly = 4;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum Video3DLayout // TypeDefIndex: 16120
{
	// Fields
	public int value__; // 0x0
	public const Video3DLayout No3D = 0;
	public const Video3DLayout SideBySide3D = 1;
	public const Video3DLayout OverUnder3D = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAspectRatio // TypeDefIndex: 16121
{
	// Fields
	public int value__; // 0x0
	public const VideoAspectRatio NoScaling = 0;
	public const VideoAspectRatio FitVertically = 1;
	public const VideoAspectRatio FitHorizontally = 2;
	public const VideoAspectRatio FitInside = 3;
	public const VideoAspectRatio FitOutside = 4;
	public const VideoAspectRatio Stretch = 5;
}

// Namespace: UnityEngine.Video
[Obsolete("VideoTimeSource is deprecated. Use TimeUpdateMode instead. (UnityUpgradable) -> VideoTimeUpdateMode")]
[RequiredByNativeCode]
public enum VideoTimeSource // TypeDefIndex: 16122
{
	// Fields
	public int value__; // 0x0
	[Obsolete("AudioDSPTimeSource is deprecated. Use DSPTime instead. (UnityUpgradable) -> DSPTime")]
	public const VideoTimeSource AudioDSPTimeSource = 0;
	[Obsolete("GameTimeSource is deprecated. Use GameTime instead. (UnityUpgradable) -> GameTime")]
	public const VideoTimeSource GameTimeSource = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeReference // TypeDefIndex: 16123
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeReference Freerun = 0;
	public const VideoTimeReference InternalTime = 1;
	public const VideoTimeReference ExternalTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoSource // TypeDefIndex: 16124
{
	// Fields
	public int value__; // 0x0
	public const VideoSource VideoClip = 0;
	public const VideoSource Url = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeUpdateMode // TypeDefIndex: 16125
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeUpdateMode DSPTime = 0;
	public const VideoTimeUpdateMode GameTime = 1;
	public const VideoTimeUpdateMode UnscaledGameTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAudioOutputMode // TypeDefIndex: 16126
{
	// Fields
	public int value__; // 0x0
	public const VideoAudioOutputMode None = 0;
	public const VideoAudioOutputMode AudioSource = 1;
	public const VideoAudioOutputMode Direct = 2;
	public const VideoAudioOutputMode APIOnly = 3;
}

// Namespace: 
public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 16127
{
	// Methods

	// RVA: 0x46FF20 Offset: 0x46F120 VA: 0x18046FF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(VideoPlayer source) { }
}

// Namespace: 
public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 16128
{
	// Methods

	// RVA: 0x62F0F0 Offset: 0x62E2F0 VA: 0x18062F0F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46EB30 Offset: 0x46DD30 VA: 0x18046EB30 Slot: 12
	public virtual void Invoke(VideoPlayer source, string message) { }
}

// Namespace: 
public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 16129
{
	// Methods

	// RVA: 0x62F0F0 Offset: 0x62E2F0 VA: 0x18062F0F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46EB30 Offset: 0x46DD30 VA: 0x18046EB30 Slot: 12
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }
}

// Namespace: 
public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 16130
{
	// Methods

	// RVA: 0x311D6A0 Offset: 0x311C8A0 VA: 0x18311D6A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46EB30 Offset: 0x46DD30 VA: 0x18046EB30 Slot: 12
	public virtual void Invoke(VideoPlayer source, double seconds) { }
}

// Namespace: UnityEngine.Video
[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 16131
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	public VideoRenderMode renderMode { set; }
	[NativeHeader("Runtime/Camera/Camera.h")]
	public Camera targetCamera { set; }
	public string targetMaterialProperty { set; }

	// Methods

	// RVA: 0x311D060 Offset: 0x311C260 VA: 0x18311D060
	public void set_renderMode(VideoRenderMode value) { }

	// RVA: 0x311D110 Offset: 0x311C310 VA: 0x18311D110
	public void set_targetCamera(Camera value) { }

	// RVA: 0x311D1F0 Offset: 0x311C3F0 VA: 0x18311D1F0
	public void set_targetMaterialProperty(string value) { }

	[RequiredByNativeCode]
	// RVA: 0x311D380 Offset: 0x311C580 VA: 0x18311D380
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x311D3C0 Offset: 0x311C5C0 VA: 0x18311D3C0
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	// RVA: 0x311D400 Offset: 0x311C600 VA: 0x18311D400
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x311D440 Offset: 0x311C640 VA: 0x18311D440
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x311D480 Offset: 0x311C680 VA: 0x18311D480
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x311D4C0 Offset: 0x311C6C0 VA: 0x18311D4C0
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	// RVA: 0x311D500 Offset: 0x311C700 VA: 0x18311D500
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x311D540 Offset: 0x311C740 VA: 0x18311D540
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	// RVA: 0x494490 Offset: 0x493690 VA: 0x180494490
	public void .ctor() { }

	// RVA: 0x311D580 Offset: 0x311C780 VA: 0x18311D580
	private static void set_renderMode_Injected(IntPtr _unity_self, VideoRenderMode value) { }

	// RVA: 0x311D5E0 Offset: 0x311C7E0 VA: 0x18311D5E0
	private static void set_targetCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x311D640 Offset: 0x311C840 VA: 0x18311D640
	private static void set_targetMaterialProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16132
{}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", 2)]
internal struct DataPlayableOutput // TypeDefIndex: 16133
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x2F865E0 Offset: 0x2F857E0 VA: 0x182F865E0
	internal void .ctor(PlayableOutputHandle handle) { }

	[RequiredByNativeCode]
	// RVA: 0x2F86700 Offset: 0x2F85900 VA: 0x182F86700
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }
}

// Namespace: UnityEngine.Playables
internal interface IDataPlayer // TypeDefIndex: 16134
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Bind(DataPlayableOutput output);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(DataPlayableOutput output);
}

// Namespace: UnityEngine.Playables
[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour // TypeDefIndex: 16135
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<PlayableDirector> played; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<PlayableDirector> paused; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F867D0 Offset: 0x2F859D0 VA: 0x182F867D0
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	// RVA: 0x2F867F0 Offset: 0x2F859F0 VA: 0x182F867F0
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	// RVA: 0x2F86810 Offset: 0x2F85A10 VA: 0x182F86810
	private void SendOnPlayableDirectorStop() { }
}

// Namespace: 
public sealed class PlayableSystems.PlayableSystemDelegate : MulticastDelegate // TypeDefIndex: 16136
{
	// Methods

	// RVA: 0x5A4DB0 Offset: 0x5A3FB0 VA: 0x1805A4DB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(IReadOnlyList<DataPlayableOutput> outputs) { }
}

// Namespace: 
public enum PlayableSystems.PlayableSystemStage // TypeDefIndex: 16137
{
	// Fields
	public ushort value__; // 0x0
	public const PlayableSystems.PlayableSystemStage FixedUpdate = 0;
	public const PlayableSystems.PlayableSystemStage FixedUpdatePostPhysics = 1;
	public const PlayableSystems.PlayableSystemStage Update = 2;
	public const PlayableSystems.PlayableSystemStage AnimationBegin = 3;
	public const PlayableSystems.PlayableSystemStage AnimationEnd = 4;
	public const PlayableSystems.PlayableSystemStage LateUpdate = 5;
	public const PlayableSystems.PlayableSystemStage Render = 6;
}

// Namespace: 
private class PlayableSystems.DataPlayableOutputList.DataPlayableOutputEnumerator : IEnumerator<DataPlayableOutput>, IEnumerator, IDisposable // TypeDefIndex: 16138
{
	// Fields
	private PlayableSystems.DataPlayableOutputList m_List; // 0x10
	private int m_Index; // 0x18

	// Properties
	public DataPlayableOutput Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x23ACF80 Offset: 0x23AC180 VA: 0x1823ACF80
	public void .ctor(PlayableSystems.DataPlayableOutputList list) { }

	// RVA: 0x2F86EB0 Offset: 0x2F860B0 VA: 0x182F86EB0 Slot: 4
	public DataPlayableOutput get_Current() { }

	// RVA: 0x2F87070 Offset: 0x2F86270 VA: 0x182F87070 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x990D80 Offset: 0x98FF80 VA: 0x180990D80 Slot: 5
	public void Dispose() { }

	// RVA: 0x2F870D0 Offset: 0x2F862D0 VA: 0x182F870D0 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x24978A0 Offset: 0x2496AA0 VA: 0x1824978A0 Slot: 8
	public void Reset() { }
}

// Namespace: 
[DefaultMember("Item")]
private class PlayableSystems.DataPlayableOutputList : IReadOnlyList<DataPlayableOutput>, IEnumerable<DataPlayableOutput>, IEnumerable, IReadOnlyCollection<DataPlayableOutput> // TypeDefIndex: 16139
{
	// Fields
	private PlayableOutputHandle* m_Outputs; // 0x10
	private int m_Count; // 0x18

	// Properties
	public DataPlayableOutput Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0xAC9B90 Offset: 0xAC8D90 VA: 0x180AC9B90
	public void .ctor(PlayableOutputHandle* outputs, int count) { }

	// RVA: 0x2F86CC0 Offset: 0x2F85EC0 VA: 0x182F86CC0 Slot: 4
	public DataPlayableOutput get_Item(int index) { }

	// RVA: 0x56C510 Offset: 0x56B710 VA: 0x18056C510 Slot: 5
	public int get_Count() { }

	// RVA: 0x2F86E10 Offset: 0x2F86010 VA: 0x182F86E10 Slot: 6
	public IEnumerator<DataPlayableOutput> GetEnumerator() { }

	// RVA: 0x2F86E10 Offset: 0x2F86010 VA: 0x182F86E10 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.Playables
[StaticAccessor("PlayableSystemsBindings", 2)]
[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
internal static class PlayableSystems // TypeDefIndex: 16140
{
	// Fields
	private static Dictionary<int, Type> s_SystemTypes; // 0x0
	private static Dictionary<int, PlayableSystems.PlayableSystemDelegate> s_Delegates; // 0x8
	private static ReaderWriterLockSlim s_RWLock; // 0x10

	// Methods

	// RVA: 0x2F86830 Offset: 0x2F85A30 VA: 0x182F86830
	private static int CombineTypeAndIndex(int typeIndex, PlayableSystems.PlayableSystemStage stage) { }

	[RequiredByNativeCode]
	// RVA: 0x2F86840 Offset: 0x2F85A40 VA: 0x182F86840
	private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystems.PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs) { }

	// RVA: 0x2F86A40 Offset: 0x2F85C40 VA: 0x182F86A40
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16141
{}

// Namespace: UnityEngine.ProBuilder.KdTree
internal struct HyperRect<T> // TypeDefIndex: 16142
{
	// Fields
	private T[] minPoint; // 0x0
	private T[] maxPoint; // 0x0

	// Properties
	public T[] MinPoint { get; set; }
	public T[] MaxPoint { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T[] get_MinPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x516B20 Offset: 0x515D20 VA: 0x180516B20
	|-HyperRect<float>.get_MinPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.get_MinPoint
	*/

	// RVA: -1 Offset: -1
	public void set_MinPoint(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2AB0 Offset: 0x12A1CB0 VA: 0x1812A2AB0
	|-HyperRect<float>.set_MinPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.set_MinPoint
	*/

	// RVA: -1 Offset: -1
	public T[] get_MaxPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C0480 Offset: 0x5BF680 VA: 0x1805C0480
	|-HyperRect<float>.get_MaxPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.get_MaxPoint
	*/

	// RVA: -1 Offset: -1
	public void set_MaxPoint(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2B90 Offset: 0x12A1D90 VA: 0x1812A2B90
	|-HyperRect<float>.set_MaxPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.set_MaxPoint
	*/

	// RVA: -1 Offset: -1
	public static HyperRect<T> Infinite(int dimensions, ITypeMath<T> math) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2C70 Offset: 0x12A1E70 VA: 0x1812A2C70
	|-HyperRect<float>.Infinite
	|
	|-RVA: 0x12A32D0 Offset: 0x12A24D0 VA: 0x1812A32D0
	|-HyperRect<__Il2CppFullySharedGenericType>.Infinite
	*/

	// RVA: -1 Offset: -1
	public T[] GetClosestPoint(T[] toPoint, ITypeMath<T> math) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2F90 Offset: 0x12A2190 VA: 0x1812A2F90
	|-HyperRect<float>.GetClosestPoint
	|
	|-RVA: 0x12A3890 Offset: 0x12A2A90 VA: 0x1812A3890
	|-HyperRect<__Il2CppFullySharedGenericType>.GetClosestPoint
	*/

	// RVA: -1 Offset: -1
	public HyperRect<T> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A3210 Offset: 0x12A2410 VA: 0x1812A3210
	|-HyperRect<float>.Clone
	|
	|-RVA: 0x12A3CE0 Offset: 0x12A2EE0 VA: 0x1812A3CE0
	|-HyperRect<__Il2CppFullySharedGenericType>.Clone
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal enum AddDuplicateBehavior // TypeDefIndex: 16143
{
	// Fields
	public int value__; // 0x0
	public const AddDuplicateBehavior Skip = 0;
	public const AddDuplicateBehavior Error = 1;
	public const AddDuplicateBehavior Update = 2;
	public const AddDuplicateBehavior Collect = 3;
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class DuplicateNodeError : Exception // TypeDefIndex: 16144
{
	// Methods

	// RVA: 0x28114F0 Offset: 0x28106F0 VA: 0x1828114F0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KdTree.<>c__DisplayClass33_0<TKey, TValue> // TypeDefIndex: 16145
{
	// Fields
	public Stack<KdTreeNode<TKey, TValue>> left; // 0x0
	public Stack<KdTreeNode<TKey, TValue>> right; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-KdTree.<>c__DisplayClass33_0<float, int>..ctor
	|-KdTree.<>c__DisplayClass33_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <GetEnumerator>b__0(KdTreeNode<TKey, TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1267770 Offset: 0x1266970 VA: 0x181267770
	|-KdTree.<>c__DisplayClass33_0<float, int>.<GetEnumerator>b__0
	|
	|-RVA: 0x12677F0 Offset: 0x12669F0 VA: 0x1812677F0
	|-KdTree.<>c__DisplayClass33_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<GetEnumerator>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <GetEnumerator>b__1(KdTreeNode<TKey, TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12677B0 Offset: 0x12669B0 VA: 0x1812677B0
	|-KdTree.<>c__DisplayClass33_0<float, int>.<GetEnumerator>b__1
	|
	|-RVA: 0x12678B0 Offset: 0x1266AB0 VA: 0x1812678B0
	|-KdTree.<>c__DisplayClass33_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<GetEnumerator>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class KdTree.<GetEnumerator>d__33<TKey, TValue> : IEnumerator<KdTreeNode<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 16146
{
	// Fields
	private int <>1__state; // 0x0
	private KdTreeNode<TKey, TValue> <>2__current; // 0x0
	public KdTree<TKey, TValue> <>4__this; // 0x0
	private KdTree.<>c__DisplayClass33_0<TKey, TValue> <>8__1; // 0x0
	private Action<KdTreeNode<TKey, TValue>> <addLeft>5__2; // 0x0
	private Action<KdTreeNode<TKey, TValue>> <addRight>5__3; // 0x0

	// Properties
	private KdTreeNode<TKey, TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x465610 Offset: 0x464810 VA: 0x180465610
	|-KdTree.<GetEnumerator>d__33<float, int>..ctor
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-KdTree.<GetEnumerator>d__33<float, int>.System.IDisposable.Dispose
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AECD50 Offset: 0x1AEBF50 VA: 0x181AECD50
	|-KdTree.<GetEnumerator>d__33<float, int>.MoveNext
	|
	|-RVA: 0x1AED2E0 Offset: 0x1AEC4E0 VA: 0x181AED2E0
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KdTreeNode<TKey, TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	|-KdTree.<GetEnumerator>d__33<float, int>.System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569480 Offset: 0x1568680 VA: 0x181569480
	|-KdTree.<GetEnumerator>d__33<float, int>.System.Collections.IEnumerator.Reset
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70
	|-KdTree.<GetEnumerator>d__33<float, int>.System.Collections.IEnumerator.get_Current
	|-KdTree.<GetEnumerator>d__33<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
[Serializable]
internal class KdTree<TKey, TValue> : IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable // TypeDefIndex: 16147
{
	// Fields
	private int dimensions; // 0x0
	private ITypeMath<TKey> typeMath; // 0x0
	private KdTreeNode<TKey, TValue> root; // 0x0
	[CompilerGenerated]
	private AddDuplicateBehavior <AddDuplicateBehavior>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public AddDuplicateBehavior AddDuplicateBehavior { get; set; }
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int dimensions, ITypeMath<TKey> typeMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EB1F0 Offset: 0x12EA3F0 VA: 0x1812EB1F0
	|-KdTree<float, int>..ctor
	|
	|-RVA: 0x12EC4E0 Offset: 0x12EB6E0 VA: 0x1812EC4E0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int dimensions, ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EB260 Offset: 0x12EA460 VA: 0x1812EB260
	|-KdTree<float, int>..ctor
	|
	|-RVA: 0x12EC550 Offset: 0x12EB750 VA: 0x1812EC550
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56C2D0 Offset: 0x56B4D0 VA: 0x18056C2D0
	|-KdTree<float, int>.get_AddDuplicateBehavior
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_AddDuplicateBehavior
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x722920 Offset: 0x721B20 VA: 0x180722920
	|-KdTree<float, int>.set_AddDuplicateBehavior
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_AddDuplicateBehavior
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Add(TKey[] point, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EB2D0 Offset: 0x12EA4D0 VA: 0x1812EB2D0
	|-KdTree<float, int>.Add
	|
	|-RVA: 0x12EC5B0 Offset: 0x12EB7B0 VA: 0x1812EC5B0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void AddNearestNeighbours(KdTreeNode<TKey, TValue> node, TKey[] target, HyperRect<TKey> rect, int depth, NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbours, TKey maxSearchRadiusSquared) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EB810 Offset: 0x12EAA10 VA: 0x1812EB810
	|-KdTree<float, int>.AddNearestNeighbours
	|
	|-RVA: 0x12ECD20 Offset: 0x12EBF20 VA: 0x1812ECD20
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNearestNeighbours
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EBDD0 Offset: 0x12EAFD0 VA: 0x1812EBDD0
	|-KdTree<float, int>.RadialSearch
	|
	|-RVA: 0x12EDA00 Offset: 0x12ECC00 VA: 0x1812EDA00
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RadialSearch
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7DFB30 Offset: 0x7DED30 VA: 0x1807DFB30
	|-KdTree<float, int>.get_Count
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7DFB40 Offset: 0x7DED40 VA: 0x1807DFB40
	|-KdTree<float, int>.set_Count
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	private void AddNodeToStringBuilder(KdTreeNode<TKey, TValue> node, StringBuilder sb, int depth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EC0E0 Offset: 0x12EB2E0 VA: 0x1812EC0E0
	|-KdTree<float, int>.AddNodeToStringBuilder
	|
	|-RVA: 0x12EDE10 Offset: 0x12ED010 VA: 0x1812EDE10
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNodeToStringBuilder
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EC2B0 Offset: 0x12EB4B0 VA: 0x1812EC2B0
	|-KdTree<float, int>.ToString
	|
	|-RVA: 0x12EDFF0 Offset: 0x12ED1F0 VA: 0x1812EDFF0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	[IteratorStateMachine(typeof(KdTree.<GetEnumerator>d__33<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<KdTreeNode<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EC390 Offset: 0x12EB590 VA: 0x1812EC390
	|-KdTree<float, int>.GetEnumerator
	|
	|-RVA: 0x12EE0D0 Offset: 0x12ED2D0 VA: 0x1812EE0D0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EC430 Offset: 0x12EB630 VA: 0x1812EC430
	|-KdTree<float, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12EE1A0 Offset: 0x12ED3A0 VA: 0x1812EE1A0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
[DefaultMember("Item")]
[Serializable]
internal class KdTreeNode<TKey, TValue> // TypeDefIndex: 16148
{
	// Fields
	public TKey[] Point; // 0x0
	public TValue Value; // 0x0
	public List<TValue> Duplicates; // 0x0
	internal KdTreeNode<TKey, TValue> LeftChild; // 0x0
	internal KdTreeNode<TKey, TValue> RightChild; // 0x0

	// Properties
	internal KdTreeNode<TKey, TValue> Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-KdTreeNode<float, int>..ctor
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey[] point, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDED30 Offset: 0xCDDF30 VA: 0x180CDED30
	|-KdTreeNode<float, int>..ctor
	|
	|-RVA: 0x12EAA60 Offset: 0x12E9C60 VA: 0x1812EAA60
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal KdTreeNode<TKey, TValue> get_Item(int compare) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EA670 Offset: 0x12E9870 VA: 0x1812EA670
	|-KdTreeNode<float, int>.get_Item
	|
	|-RVA: 0x12EABA0 Offset: 0x12E9DA0 VA: 0x1812EABA0
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(int compare, KdTreeNode<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EA680 Offset: 0x12E9880 VA: 0x1812EA680
	|-KdTreeNode<float, int>.set_Item
	|
	|-RVA: 0x12EAC10 Offset: 0x12E9E10 VA: 0x1812EAC10
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void AddDuplicate(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EA740 Offset: 0x12E9940 VA: 0x1812EA740
	|-KdTreeNode<float, int>.AddDuplicate
	|
	|-RVA: 0x12EAC50 Offset: 0x12E9E50 VA: 0x1812EAC50
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddDuplicate
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12EA8E0 Offset: 0x12E9AE0 VA: 0x1812EA8E0
	|-KdTreeNode<float, int>.ToString
	|
	|-RVA: 0x12EAE70 Offset: 0x12EA070 VA: 0x1812EAE70
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface ITypeMath<T> // TypeDefIndex: 16149
{
	// Properties
	public abstract T MinValue { get; }
	public abstract T NegativeInfinity { get; }
	public abstract T PositiveInfinity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_MinValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_MinValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool AreEqual(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract T Multiply(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Multiply
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T get_NegativeInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_NegativeInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract T get_PositiveInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_PositiveInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.DistanceSquaredBetweenPoints
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class NearestNeighbourList<TItem, TDistance> // TypeDefIndex: 16150
{
	// Fields
	private PriorityQueue<TItem, TDistance> queue; // 0x0
	private ITypeMath<TDistance> distanceMath; // 0x0
	private int maxCapacity; // 0x0

	// Properties
	public int MaxCapacity { get; }
	public int Count { get; }
	public bool IsCapacityReached { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity, ITypeMath<TDistance> distanceMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568780 Offset: 0x1567980 VA: 0x181568780
	|-NearestNeighbourList<object, float>..ctor
	|
	|-RVA: 0x1568BF0 Offset: 0x1567DF0 VA: 0x181568BF0
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_MaxCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4EDA70 Offset: 0x4ECC70 VA: 0x1804EDA70
	|-NearestNeighbourList<object, float>.get_MaxCapacity
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_MaxCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15689B0 Offset: 0x1567BB0 VA: 0x1815689B0
	|-NearestNeighbourList<object, float>.get_Count
	|
	|-RVA: 0x1568D30 Offset: 0x1567F30 VA: 0x181568D30
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Add(TItem item, TDistance distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15689D0 Offset: 0x1567BD0 VA: 0x1815689D0
	|-NearestNeighbourList<object, float>.Add
	|
	|-RVA: 0x1568D60 Offset: 0x1567F60 VA: 0x181568D60
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public TDistance GetFurtherestDistance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568B00 Offset: 0x1567D00 VA: 0x181568B00
	|-NearestNeighbourList<object, float>.GetFurtherestDistance
	|
	|-RVA: 0x1569100 Offset: 0x1568300 VA: 0x181569100
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetFurtherestDistance
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public TItem RemoveFurtherest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568B90 Offset: 0x1567D90 VA: 0x181568B90
	|-NearestNeighbourList<object, float>.RemoveFurtherest
	|
	|-RVA: 0x1569220 Offset: 0x1568420 VA: 0x181569220
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveFurtherest
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCapacityReached() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568BC0 Offset: 0x1567DC0 VA: 0x181568BC0
	|-NearestNeighbourList<object, float>.get_IsCapacityReached
	|
	|-RVA: 0x15692D0 Offset: 0x15684D0 VA: 0x1815692D0
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsCapacityReached
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal struct ItemPriority<TItem, TPriority> // TypeDefIndex: 16151
{
	// Fields
	public TItem Item; // 0x0
	public TPriority Priority; // 0x0
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class PriorityQueue<TItem, TPriority> // TypeDefIndex: 16152
{
	// Fields
	private ITypeMath<TPriority> priorityMath; // 0x0
	private ItemPriority<TItem, TPriority>[] queue; // 0x0
	private int capacity; // 0x0
	private int count; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, ITypeMath<TPriority> priorityMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E17D0 Offset: 0x15E09D0 VA: 0x1815E17D0
	|-PriorityQueue<object, float>..ctor
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x670820 Offset: 0x66FA20 VA: 0x180670820
	|-PriorityQueue<object, float>.get_Count
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void ExpandCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1920 Offset: 0x15E0B20 VA: 0x1815E1920
	|-PriorityQueue<object, float>.ExpandCapacity
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ExpandCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Enqueue(TItem item, TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1AB0 Offset: 0x15E0CB0 VA: 0x1815E1AB0
	|-PriorityQueue<object, float>.Enqueue
	|
	|-RVA: 0x15E1FC0 Offset: 0x15E11C0 VA: 0x1815E1FC0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1C60 Offset: 0x15E0E60 VA: 0x1815E1C60
	|-PriorityQueue<object, float>.Dequeue
	|
	|-RVA: 0x15E22C0 Offset: 0x15E14C0 VA: 0x1815E22C0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private void ReorderItem(int index, int direction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1D40 Offset: 0x15E0F40 VA: 0x1815E1D40
	|-PriorityQueue<object, float>.ReorderItem
	|
	|-RVA: 0x15E24E0 Offset: 0x15E16E0 VA: 0x1815E24E0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReorderItem
	*/

	// RVA: -1 Offset: -1
	public TPriority GetHighestPriority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1F40 Offset: 0x15E1140 VA: 0x1815E1F40
	|-PriorityQueue<object, float>.GetHighestPriority
	|
	|-RVA: 0x15E29D0 Offset: 0x15E1BD0 VA: 0x1815E29D0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHighestPriority
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal class FloatMath : TypeMath<float> // TypeDefIndex: 16153
{
	// Properties
	public override float MinValue { get; }
	public override float Zero { get; }
	public override float NegativeInfinity { get; }
	public override float PositiveInfinity { get; }

	// Methods

	// RVA: 0x211F690 Offset: 0x211E890 VA: 0x18211F690 Slot: 11
	public override int Compare(float a, float b) { }

	// RVA: 0x2811560 Offset: 0x2810760 VA: 0x182811560 Slot: 12
	public override bool AreEqual(float a, float b) { }

	// RVA: 0x2811570 Offset: 0x2810770 VA: 0x182811570 Slot: 14
	public override float get_MinValue() { }

	// RVA: 0x4A2600 Offset: 0x4A1800 VA: 0x1804A2600 Slot: 15
	public override float get_Zero() { }

	// RVA: 0x2811580 Offset: 0x2810780 VA: 0x182811580 Slot: 16
	public override float get_NegativeInfinity() { }

	// RVA: 0x2811590 Offset: 0x2810790 VA: 0x182811590 Slot: 17
	public override float get_PositiveInfinity() { }

	// RVA: 0xC4F110 Offset: 0xC4E310 VA: 0x180C4F110 Slot: 18
	public override float Add(float a, float b) { }

	// RVA: 0xC4F120 Offset: 0xC4E320 VA: 0x180C4F120 Slot: 19
	public override float Subtract(float a, float b) { }

	// RVA: 0xC4F130 Offset: 0xC4E330 VA: 0x180C4F130 Slot: 20
	public override float Multiply(float a, float b) { }

	// RVA: 0x28115A0 Offset: 0x28107A0 VA: 0x1828115A0 Slot: 21
	public override float DistanceSquaredBetweenPoints(float[] a, float[] b) { }

	// RVA: 0x28116D0 Offset: 0x28108D0 VA: 0x1828116D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal abstract class TypeMath<T> : ITypeMath<T> // TypeDefIndex: 16154
{
	// Properties
	public abstract T MinValue { get; }
	public abstract T Zero { get; }
	public abstract T NegativeInfinity { get; }
	public abstract T PositiveInfinity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int Compare(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool AreEqual(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool AreEqual(T[] a, T[] b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B45F0 Offset: 0x17B37F0 VA: 0x1817B45F0
	|-TypeMath<float>.AreEqual
	|
	|-RVA: 0x17B46A0 Offset: 0x17B38A0 VA: 0x1817B46A0
	|-TypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract T get_MinValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_MinValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract T get_Zero();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_Zero
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract T get_NegativeInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_NegativeInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract T get_PositiveInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_PositiveInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public abstract T Add(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public abstract T Subtract(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Subtract
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public abstract T Multiply(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Multiply
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.DistanceSquaredBetweenPoints
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	|-TypeMath<float>..ctor
	|-TypeMath<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16155
{}

// Namespace: 
[CompilerGenerated]
private sealed class CustomFog.<RegisterMaterialForInspector>d__10 : IEnumerable<Material>, IEnumerable, IEnumerator<Material>, IEnumerator, IDisposable // TypeDefIndex: 16156
{
	// Fields
	private int <>1__state; // 0x10
	private Material <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public CustomFog <>4__this; // 0x28

	// Properties
	private Material System.Collections.Generic.IEnumerator<UnityEngine.Material>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x737DA0 Offset: 0x736FA0 VA: 0x180737DA0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xF7B860 Offset: 0xF7AA60 VA: 0x180F7B860 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70 Slot: 6
	private Material System.Collections.Generic.IEnumerator<UnityEngine.Material>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0xF7B900 Offset: 0xF7AB00 VA: 0x180F7B900 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x467A70 Offset: 0x466C70 VA: 0x180467A70 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0xF7B940 Offset: 0xF7AB40 VA: 0x180F7B940 Slot: 4
	private IEnumerator<Material> System.Collections.Generic.IEnumerable<UnityEngine.Material>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0xF7B940 Offset: 0xF7AB40 VA: 0x180F7B940 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
public class CustomFog : CustomPass // TypeDefIndex: 16157
{
	// Fields
	private readonly int _fogColorId; // 0xD8
	private readonly int _distanceParamsId; // 0xDC
	[ColorUsage(False, True)]
	public Color FogColor; // 0xE0
	[Range(0, 1)]
	public float FadeIntensity; // 0xF0
	public float EndDistance; // 0xF4
	public float StartDistance; // 0xF8
	[Range(0, 1)]
	public float CoverSkybox; // 0xFC
	private Material _fogMaterial; // 0x100

	// Methods

	// RVA: 0xF7B430 Offset: 0xF7A630 VA: 0x180F7B430 Slot: 11
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd) { }

	// RVA: 0xF7B500 Offset: 0xF7A700 VA: 0x180F7B500 Slot: 10
	protected override void Execute(CustomPassContext ctx) { }

	[IteratorStateMachine(typeof(CustomFog.<RegisterMaterialForInspector>d__10))]
	// RVA: 0xF7B710 Offset: 0xF7A910 VA: 0x180F7B710 Slot: 13
	public override IEnumerable<Material> RegisterMaterialForInspector() { }

	// RVA: 0xF7B7C0 Offset: 0xF7A9C0 VA: 0x180F7B7C0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class FPSForeground : CustomPass // TypeDefIndex: 16158
{
	// Fields
	[CompilerGenerated]
	private readonly string <ShaderName>k__BackingField; // 0xD8
	private static ShaderTagId[] _litForwardTags; // 0x0
	private static ShaderTagId[] _depthTags; // 0x8
	public LayerMask foregroundMask; // 0xE0
	public CustomPass.RenderQueueType renderQueueType; // 0xE4
	public Camera foregroundCamera; // 0xE8
	public bool depthPass; // 0xF0
	public bool clearDepth; // 0xF1
	public bool overrideBlendState; // 0xF2
	public bool overrideDepthState; // 0xF3
	public bool writeDepth; // 0xF4
	public CompareFunction compareFunction; // 0xF8
	private Material depthClearMaterial; // 0x100
	private RenderStateBlock block; // 0x108

	// Properties
	private string ShaderName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4A3FC0 Offset: 0x4A31C0 VA: 0x1804A3FC0
	private string get_ShaderName() { }

	// RVA: 0xF7BA10 Offset: 0xF7AC10 VA: 0x180F7BA10 Slot: 8
	protected override void AggregateCullingParameters(ref ScriptableCullingParameters cullingParameters, HDCamera hdCamera) { }

	// RVA: 0xF7BA70 Offset: 0xF7AC70 VA: 0x180F7BA70 Slot: 11
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd) { }

	// RVA: 0xF7BFE0 Offset: 0xF7B1E0 VA: 0x180F7BFE0
	private void OnValidate() { }

	// RVA: 0xF7C050 Offset: 0xF7B250 VA: 0x180F7C050 Slot: 10
	protected override void Execute(CustomPassContext ctx) { }

	// RVA: 0xF7C500 Offset: 0xF7B700 VA: 0x180F7C500
	public void RenderFromCamera(in CustomPassContext ctx, Camera view, RTHandle targetColor, RTHandle targetDepth, ClearFlag clearFlag, LayerMask layerMask, bool depthTags, CustomPass.RenderQueueType renderQueueFilter, RenderStateBlock overrideRenderState, Material overrideMaterial) { }

	// RVA: 0xF7C8F0 Offset: 0xF7BAF0 VA: 0x180F7C8F0 Slot: 12
	protected override void Cleanup() { }

	// RVA: 0xF7C950 Offset: 0xF7BB50 VA: 0x180F7C950
	public void .ctor() { }
}

// Namespace: 
internal class ScreenSpaceCameraUIBlur : CustomPass // TypeDefIndex: 16159
{
	// Fields
	public float blurRadius; // 0xD8
	public LayerMask uiLayer; // 0xDC
	[Range(0, 1)]
	public float darkenAmount; // 0xE0
	private RTHandle downSampleBuffer; // 0xE8
	private Material darkenMaterial; // 0xF0
	private readonly int _intensityId; // 0xF8

	// Methods

	// RVA: 0xF7CA00 Offset: 0xF7BC00 VA: 0x180F7CA00 Slot: 11
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd) { }

	// RVA: 0xF7CD70 Offset: 0xF7BF70 VA: 0x180F7CD70 Slot: 8
	protected override void AggregateCullingParameters(ref ScriptableCullingParameters cullingParameters, HDCamera hdCamera) { }

	// RVA: 0xF7CDD0 Offset: 0xF7BFD0 VA: 0x180F7CDD0 Slot: 10
	protected override void Execute(CustomPassContext ctx) { }

	// RVA: 0xF7D470 Offset: 0xF7C670 VA: 0x180F7D470 Slot: 12
	protected override void Cleanup() { }

	// RVA: 0xF7D4A0 Offset: 0xF7C6A0 VA: 0x180F7D4A0
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16160
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16161
{
	// Methods

	// RVA: 0xF7D510 Offset: 0xF7C710 VA: 0x180F7D510
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=63 // TypeDefIndex: 16162
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 // TypeDefIndex: 16163
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16164
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 99291113B2530BBBEA93891880510E1CBE3D9F905089D361F1F47057CCA84D05 /*Metadata offset 0x7EF8F8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=63 DD45CE0204F89DD8E3EA0E8E469D9E905ACCAFB6D1B97DDBCA6417AD41514025 /*Metadata offset 0x7EF9B8*/; // 0xBC
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16165
{}

// Namespace: 
public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 16166
{
	// Methods

	// RVA: 0x477570 Offset: 0x476770 VA: 0x180477570
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464320 Offset: 0x463520 VA: 0x180464320 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
public static class RemoteSettings // TypeDefIndex: 16167
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action BeforeFetchFromServer; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3113330 Offset: 0x3112530 VA: 0x183113330
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x3113390 Offset: 0x3112590 VA: 0x183113390
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x31133F0 Offset: 0x31125F0 VA: 0x1831133F0
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[ExcludeFromDocs]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public class RemoteConfigSettings // TypeDefIndex: 16168
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> Updated; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3113470 Offset: 0x3112670 VA: 0x183113470
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }
}

// Namespace: 
[RequiredByNativeCode]
internal enum RemoteConfigSettingsHelper.Tag // TypeDefIndex: 16169
{
	// Fields
	public int value__; // 0x0
	public const RemoteConfigSettingsHelper.Tag kUnknown = 0;
	public const RemoteConfigSettingsHelper.Tag kIntVal = 1;
	public const RemoteConfigSettingsHelper.Tag kInt64Val = 2;
	public const RemoteConfigSettingsHelper.Tag kUInt64Val = 3;
	public const RemoteConfigSettingsHelper.Tag kDoubleVal = 4;
	public const RemoteConfigSettingsHelper.Tag kBoolVal = 5;
	public const RemoteConfigSettingsHelper.Tag kStringVal = 6;
	public const RemoteConfigSettingsHelper.Tag kArrayVal = 7;
	public const RemoteConfigSettingsHelper.Tag kMixedArrayVal = 8;
	public const RemoteConfigSettingsHelper.Tag kMapVal = 9;
	public const RemoteConfigSettingsHelper.Tag kMaxTags = 10;
}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper // TypeDefIndex: 16170
{}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
[NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
[ExcludeFromDocs]
public class ContinuousEvent // TypeDefIndex: 16171
{}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
public enum AnalyticsSessionState // TypeDefIndex: 16172
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: 
public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 16173
{
	// Methods

	// RVA: 0x3113590 Offset: 0x3112790 VA: 0x183113590
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990 Slot: 12
	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }
}

// Namespace: 
public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 16174
{
	// Methods

	// RVA: 0x46FF20 Offset: 0x46F120 VA: 0x18046FF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FC90 Offset: 0x46EE90 VA: 0x18046FC90 Slot: 12
	public virtual void Invoke(string token) { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
public static class AnalyticsSessionInfo // TypeDefIndex: 16175
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x31134A0 Offset: 0x31126A0 VA: 0x1831134A0
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x3113530 Offset: 0x3112730 VA: 0x183113530
	internal static void CallIdentityTokenChanged(string token) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16176
{}

// Namespace: UnityEngine
[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility // TypeDefIndex: 16177
{
	// Methods

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	// RVA: 0x2FB46A0 Offset: 0x2FB38A0 VA: 0x182FB46A0
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	[ThreadSafe]
	// RVA: 0x2FB47D0 Offset: 0x2FB39D0 VA: 0x182FB47D0
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x2FB4940 Offset: 0x2FB3B40 VA: 0x182FB4940
	public static string ToJson(object obj) { }

	// RVA: 0x2FB4AB0 Offset: 0x2FB3CB0 VA: 0x182FB4AB0
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1139C70 Offset: 0x1138E70 VA: 0x181139C70
	|-JsonUtility.FromJson<SavedHotkey>
	|
	|-RVA: 0x1139D80 Offset: 0x1138F80 VA: 0x181139D80
	|-JsonUtility.FromJson<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FB4C30 Offset: 0x2FB3E30 VA: 0x182FB4C30
	public static object FromJson(string json, Type type) { }

	// RVA: 0x2FB4E00 Offset: 0x2FB4000 VA: 0x182FB4E00
	private static void ToJsonInternal_Injected(object obj, bool prettyPrint, out ManagedSpanWrapper ret) { }

	// RVA: 0x2FB4E70 Offset: 0x2FB4070 VA: 0x182FB4E70
	private static object FromJsonInternal_Injected(ref ManagedSpanWrapper json, object objectToOverwrite, Type type) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16178
{}

// Namespace: 
internal static class DownloadHandlerAudioClip.BindingsMarshaller // TypeDefIndex: 16179
{
	// Methods

	// RVA: 0xB616F0 Offset: 0xB608F0 VA: 0x180B616F0
	public static IntPtr ConvertToNative(DownloadHandlerAudioClip handler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
public sealed class DownloadHandlerAudioClip : DownloadHandler // TypeDefIndex: 16180
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Properties
	[NativeThrows]
	public AudioClip audioClip { get; }

	// Methods

	// RVA: 0x3113660 Offset: 0x3112860 VA: 0x183113660
	private static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType) { }

	// RVA: 0x31137C0 Offset: 0x31129C0 VA: 0x1831137C0
	private void InternalCreateAudioClip(string url, AudioType audioType) { }

	// RVA: 0x31137C0 Offset: 0x31129C0 VA: 0x1831137C0
	public void .ctor(string url, AudioType audioType) { }

	// RVA: 0x31137E0 Offset: 0x31129E0 VA: 0x1831137E0 Slot: 5
	public override void Dispose() { }

	// RVA: 0x3113880 Offset: 0x3112A80 VA: 0x183113880
	public AudioClip get_audioClip() { }

	// RVA: 0x3113930 Offset: 0x3112B30 VA: 0x183113930
	public static AudioClip GetContent(UnityWebRequest www) { }

	// RVA: 0x3113A10 Offset: 0x3112C10 VA: 0x183113A10
	private static IntPtr Create_Injected(DownloadHandlerAudioClip obj, ref ManagedSpanWrapper url, AudioType audioType) { }

	// RVA: 0x3113A80 Offset: 0x3112C80 VA: 0x183113A80
	private static IntPtr get_audioClip_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestMultimedia // TypeDefIndex: 16181
{
	// Methods

	// RVA: 0x3113AD0 Offset: 0x3112CD0 VA: 0x183113AD0
	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16182
{}

// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 16183
{
	// Methods

	// RVA: 0x474D30 Offset: 0x473F30 VA: 0x180474D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46EB30 Offset: 0x46DD30 VA: 0x18046EB30 Slot: 12
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }
}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEventBuffer // TypeDefIndex: 16184
{
	// Fields
	public void* eventBuffer; // 0x0
	public int eventCount; // 0x8
	public int sizeInBytes; // 0xC
	public int capacityInBytes; // 0x10
}

// Namespace: UnityEngineInternal.Input
[Flags]
internal enum NativeInputUpdateType // TypeDefIndex: 16185
{
	// Fields
	public int value__; // 0x0
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = -2147483648;
}

// Namespace: UnityEngineInternal.Input
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
[NativeHeader("Modules/Input/Private/InputInternal.h")]
internal class NativeInputSystem // TypeDefIndex: 16186
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x2FB43D0 Offset: 0x2FB35D0 VA: 0x182FB43D0
	private static void .cctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2FB4420 Offset: 0x2FB3620 VA: 0x182FB4420
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCode]
	// RVA: 0x2FB44A0 Offset: 0x2FB36A0 VA: 0x182FB44A0
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCode]
	// RVA: 0x2FB4540 Offset: 0x2FB3740 VA: 0x182FB4540
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x2FB45C0 Offset: 0x2FB37C0 VA: 0x182FB45C0
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x2FB4650 Offset: 0x2FB3850 VA: 0x182FB4650
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16187
{}

// Namespace: 
public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 16188
{
	// Methods

	// RVA: 0x477570 Offset: 0x476770 VA: 0x180477570
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464320 Offset: 0x463520 VA: 0x180464320 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.AI
[StaticAccessor("NavMeshBindings", 2)]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public static class NavMesh // TypeDefIndex: 16189
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x2E96AC0 Offset: 0x2E95CC0 VA: 0x182E96AC0
	private static void ClearPreUpdateListeners() { }

	[RequiredByNativeCode]
	// RVA: 0x2E96B60 Offset: 0x2E95D60 VA: 0x182E96B60
	private static void Internal_CallOnNavMeshPreUpdate() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16190
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16191
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16192
{
	// Methods

	// RVA: 0x251F340 Offset: 0x251E540 VA: 0x18251F340
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: GameObjectPools
public interface IPoolResettable // TypeDefIndex: 16193
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ResetObject();
}

// Namespace: GameObjectPools
public interface IPoolSpawnable // TypeDefIndex: 16194
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SpawnObject();
}

// Namespace: 
internal enum Pool.OverflowModes // TypeDefIndex: 16195
{
	// Fields
	public int value__; // 0x0
	public const Pool.OverflowModes RecycleOldPrefab = 0;
	public const Pool.OverflowModes DoNotSpawnPrefab = 1;
	public const Pool.OverflowModes CreateMorePrefabs = 2;
}

// Namespace: GameObjectPools
[Serializable]
internal class Pool // TypeDefIndex: 16196
{
	// Fields
	[SerializeField]
	internal PoolObject Prefab; // 0x10
	private Stack<PoolObject> _pool; // 0x18
	private Queue<PoolObject> _spawnQueue; // 0x20
	private Transform parentTransform; // 0x28
	private int _currentMax; // 0x30
	private List<int> _maxEachRound; // 0x38

	// Properties
	private Pool.OverflowModes OverflowMode { get; }

	// Methods

	// RVA: 0x15689B0 Offset: 0x1567BB0 VA: 0x1815689B0
	private Pool.OverflowModes get_OverflowMode() { }

	// RVA: 0x251F4B0 Offset: 0x251E6B0 VA: 0x18251F4B0
	private void AddNewPrefabToPool() { }

	// RVA: 0x251F520 Offset: 0x251E720 VA: 0x18251F520
	internal void Initialize() { }

	// RVA: 0x251F6F0 Offset: 0x251E8F0 VA: 0x18251F6F0
	internal bool TryGetPoolableObject(out PoolObject poolableObject) { }

	// RVA: 0x251FBC0 Offset: 0x251EDC0 VA: 0x18251FBC0
	internal void ReturnObject(PoolObject poolableObject) { }

	// RVA: 0x251FD10 Offset: 0x251EF10 VA: 0x18251FD10
	private void ResetObject(PoolObject poolableObject) { }

	// RVA: 0x251FD90 Offset: 0x251EF90 VA: 0x18251FD90
	internal void RestartRound() { }

	// RVA: 0x251FE40 Offset: 0x251F040 VA: 0x18251FE40
	internal void PrintDebug() { }

	// RVA: 0x2520360 Offset: 0x251F560 VA: 0x182520360
	private PoolObject SpawnObject() { }

	// RVA: 0x2520640 Offset: 0x251F840 VA: 0x182520640
	public void .ctor() { }
}

// Namespace: GameObjectPools
public class PoolManager : MonoBehaviour // TypeDefIndex: 16197
{
	// Fields
	public static PoolManager Singleton; // 0x0
	internal Dictionary<GameObject, PoolObject> PoolObjectLookup; // 0x20
	[SerializeField]
	private List<Pool> objectPools; // 0x28
	private Dictionary<GameObject, Pool> _poolLookup; // 0x30

	// Methods

	// RVA: 0x2520830 Offset: 0x251FA30 VA: 0x182520830
	public void TryAddPool(PoolObject prefab) { }

	// RVA: 0x25209B0 Offset: 0x251FBB0 VA: 0x1825209B0
	public bool TryGetPoolObject(GameObject prefab, Transform parent, out PoolObject poolObject, bool autoSetup = True) { }

	// RVA: 0x2520A40 Offset: 0x251FC40 VA: 0x182520A40
	public bool TryGetPoolObject(GameObject prefab, Transform parent, bool worldPositionStays, out PoolObject poolObject, bool autoSetup = True) { }

	// RVA: 0x2520AE0 Offset: 0x251FCE0 VA: 0x182520AE0
	public bool TryGetPoolObject(GameObject prefab, out PoolObject poolObject, bool autoSetup = True) { }

	// RVA: 0x2520DC0 Offset: 0x251FFC0 VA: 0x182520DC0
	public bool TryReturnPoolObject(GameObject poolGameObject) { }

	// RVA: 0x2520EF0 Offset: 0x25200F0 VA: 0x182520EF0
	public void ReturnPoolObject(PoolObject poolObject) { }

	// RVA: 0x2520F20 Offset: 0x2520120 VA: 0x182520F20
	public void ReturnAllPoolObjects() { }

	// RVA: 0x2521160 Offset: 0x2520360 VA: 0x182521160
	public void RestartRound() { }

	// RVA: 0x2521390 Offset: 0x2520590 VA: 0x182521390
	private void Awake() { }

	// RVA: 0x2521740 Offset: 0x2520940 VA: 0x182521740
	private void OnDestroy() { }

	// RVA: 0x2521960 Offset: 0x2520B60 VA: 0x182521960
	public void .ctor() { }
}

// Namespace: GameObjectPools
public class PoolObject : MonoBehaviour // TypeDefIndex: 16198
{
	// Fields
	[SerializeField]
	internal int InitialPoolSize; // 0x20
	[SerializeField]
	internal Pool.OverflowModes OverflowMode; // 0x24
	[CompilerGenerated]
	private bool <Pooled>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <DetachedFromPool>k__BackingField; // 0x29
	private IPoolResettable[] _poolResetables; // 0x30
	private IPoolSpawnable[] _poolSpawnables; // 0x38
	[CompilerGenerated]
	private Pool <_myPool>k__BackingField; // 0x40

	// Properties
	public bool Pooled { get; set; }
	public bool DetachedFromPool { get; set; }
	private Pool _myPool { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49BE30 Offset: 0x49B030 VA: 0x18049BE30
	public bool get_Pooled() { }

	[CompilerGenerated]
	// RVA: 0x49BE40 Offset: 0x49B040 VA: 0x18049BE40
	public void set_Pooled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E6600 Offset: 0x4E5800 VA: 0x1804E6600
	public bool get_DetachedFromPool() { }

	[CompilerGenerated]
	// RVA: 0x4E6610 Offset: 0x4E5810 VA: 0x1804E6610
	public void set_DetachedFromPool(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4A2630 Offset: 0x4A1830 VA: 0x1804A2630
	private Pool get__myPool() { }

	[CompilerGenerated]
	// RVA: 0x5189F0 Offset: 0x517BF0 VA: 0x1805189F0
	private void set__myPool(Pool value) { }

	// RVA: 0x2521AF0 Offset: 0x2520CF0 VA: 0x182521AF0
	public void ReturnToPool(bool checkChildren = True) { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10 Slot: 4
	protected virtual void OnInstantiated() { }

	// RVA: 0x2521D80 Offset: 0x2520F80 VA: 0x182521D80
	internal void InitializePoolObject(Pool poolOwner) { }

	// RVA: 0x2521F00 Offset: 0x2521100 VA: 0x182521F00
	public void ResetPoolObject() { }

	// RVA: 0x2522010 Offset: 0x2521210 VA: 0x182522010
	public void SetupPoolObject() { }

	// RVA: 0x59E720 Offset: 0x59D920 VA: 0x18059E720
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=159 // TypeDefIndex: 16199
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 // TypeDefIndex: 16200
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16201
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=159 14B052DC1F6FBC6BF8E3A85217DAD2CA76DD668F77B412E00F93B71D96E09D3A /*Metadata offset 0x7EFA18*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 F9080D672794B687714B1A3046B4AB86563C563F56C103B4669BFA0194C2E2FB /*Metadata offset 0x7EFAB8*/; // 0x9F
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16202
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 16203
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 16204
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 16205
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation // TypeDefIndex: 16206
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 16207
{}

// Namespace: UnityEngine
[NativeClass("Unity::Cloth")]
[NativeHeader("Modules/Cloth/Cloth.h")]
[RequireComponent(typeof(Transform), typeof(SkinnedMeshRenderer))]
public sealed class Cloth : Component // TypeDefIndex: 16208
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 16209
{}

// Namespace: UnityEngine
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[RequireComponent(typeof(Transform))]
public class GridLayout : Behaviour // TypeDefIndex: 16210
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	private void DoNothing() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16211
{}

// Namespace: UnityEngine
[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion // TypeDefIndex: 16212
{
	// Methods

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToEXR", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2F8C500 Offset: 0x2F8B700 VA: 0x182F8C500
	public static byte[] EncodeToEXR(Texture2D tex, Texture2D.EXRFlags flags) { }

	// RVA: 0x2F8C650 Offset: 0x2F8B850 VA: 0x182F8C650
	private static void EncodeToEXR_Injected(IntPtr tex, Texture2D.EXRFlags flags, out BlittableArrayWrapper ret) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16213
{}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
public static class XRDevice // TypeDefIndex: 16214
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string> deviceLoaded; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x311D790 Offset: 0x311C990 VA: 0x18311D790
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16215
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Terrain/Public/TerrainData.h")]
[NativeHeader("Modules/TerrainPhysics/TerrainCollider.h")]
public class TerrainCollider : Collider // TypeDefIndex: 16216
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 16217
{}

// Namespace: 
public abstract class ParentCommand : CommandHandler, ICommand // TypeDefIndex: 16218
{
	// Properties
	public abstract string Command { get; }
	public abstract string[] Aliases { get; }
	public abstract string Description { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 20
	public abstract string get_Command();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract string[] get_Aliases();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string get_Description();

	// RVA: 0xF7A5E0 Offset: 0xF797E0 VA: 0x180F7A5E0 Slot: 19
	public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) { }

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response);

	// RVA: 0x80B1B0 Offset: 0x80A3B0 VA: 0x18080B1B0
	protected void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16219
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16220
{
	// Methods

	// RVA: 0xF7A7F0 Offset: 0xF799F0 VA: 0x180F7A7F0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: CommandSystem
public abstract class CommandHandler : ICommandHandler // TypeDefIndex: 16221
{
	// Fields
	protected readonly Dictionary<string, ICommand> Commands; // 0x10
	protected readonly Dictionary<string, string> CommandAliases; // 0x18

	// Properties
	public virtual IEnumerable<ICommand> AllCommands { get; }

	// Methods

	// RVA: 0xF7A960 Offset: 0xF79B60 VA: 0x180F7A960 Slot: 10
	public virtual IEnumerable<ICommand> get_AllCommands() { }

	// RVA: 0xF7A9B0 Offset: 0xF79BB0 VA: 0x180F7A9B0 Slot: 11
	public virtual bool TryGetCommand(string query, out ICommand command) { }

	// RVA: 0xF7AA60 Offset: 0xF79C60 VA: 0x180F7AA60 Slot: 12
	public virtual void RegisterCommand(ICommand command) { }

	// RVA: 0xF7AD60 Offset: 0xF79F60 VA: 0x180F7AD60 Slot: 13
	public virtual void UnregisterCommand(ICommand command) { }

	// RVA: 0xF7AE80 Offset: 0xF7A080 VA: 0x180F7AE80 Slot: 14
	public virtual void ClearCommands() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void LoadGeneratedCommands();

	// RVA: 0xF7AEF0 Offset: 0xF7A0F0 VA: 0x180F7AEF0
	protected void .ctor() { }
}

// Namespace: CommandSystem
[Usage(4, AllowMultiple = True)]
public class CommandHandlerAttribute : Attribute // TypeDefIndex: 16222
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor(Type type) { }
}

// Namespace: CommandSystem
public interface ICommand // TypeDefIndex: 16223
{
	// Properties
	public abstract string Command { get; }
	public abstract string[] Aliases { get; }
	public abstract string Description { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Command();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string[] get_Aliases();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response);
}

// Namespace: CommandSystem
public interface ICommandHandler // TypeDefIndex: 16224
{
	// Properties
	public abstract IEnumerable<ICommand> AllCommands { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<ICommand> get_AllCommands();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryGetCommand(string query, out ICommand command);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterCommand(ICommand command);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UnregisterCommand(ICommand command);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ClearCommands();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LoadGeneratedCommands();
}

// Namespace: CommandSystem
public interface ICommandSender // TypeDefIndex: 16225
{
	// Properties
	public abstract string LogName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Respond(string message, bool success = True);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LogName();
}

// Namespace: CommandSystem
public interface IHelpProvider // TypeDefIndex: 16226
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetHelp(ArraySegment<string> arguments);
}

// Namespace: CommandSystem
public interface IHiddenCommand // TypeDefIndex: 16227
{}

// Namespace: CommandSystem
public interface IUsageProvider // TypeDefIndex: 16228
{
	// Properties
	public abstract string[] Usage { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string[] get_Usage();
}

// Namespace: CommandSystem
[Extension]
public static class HelpProviderExtensions // TypeDefIndex: 16229
{
	// Methods

	[Extension]
	// RVA: 0xF7B120 Offset: 0xF7A320 VA: 0x180F7B120
	public static string DisplayCommandUsage(IUsageProvider provider) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=327 // TypeDefIndex: 16230
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=551 // TypeDefIndex: 16231
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16232
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=551 8363C466DA13BD287AB69CD5087127A5A400474ACF5D8FC9D095FC239E628B00 /*Metadata offset 0x7EFC00*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=327 9EA60AFCEE76F6805719329650CFD5BCA1045A4B431430A67A31DDA6FBAB15D4 /*Metadata offset 0x7EFE28*/; // 0x227
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16233
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16234
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16235
{
	// Methods

	// RVA: 0xF79A20 Offset: 0xF78C20 VA: 0x180F79A20
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct CaressData : IDisposable // TypeDefIndex: 16236
{
	// Fields
	public IntPtr Ptr; // 0x0
	public uint Length; // 0x8

	// Methods

	// RVA: 0xF79B90 Offset: 0xF78D90 VA: 0x180F79B90
	public string StringValue() { }

	// RVA: 0xF79BF0 Offset: 0xF78DF0 VA: 0x180F79BF0
	public byte[] ByteValue() { }

	// RVA: 0xF79CA0 Offset: 0xF78EA0 VA: 0x180F79CA0
	public void .ctor(IntPtr ptr) { }

	// RVA: 0xF79CB0 Offset: 0xF78EB0 VA: 0x180F79CB0
	public void .ctor(string value) { }

	// RVA: 0xF79DC0 Offset: 0xF78FC0 VA: 0x180F79DC0
	public void .ctor(byte[] value) { }

	// RVA: 0xF79EA0 Offset: 0xF790A0 VA: 0x180F79EA0 Slot: 4
	public void Dispose() { }
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct ApiError // TypeDefIndex: 16237
{
	// Fields
	public byte Code; // 0x0
	public CaressData Data; // 0x8
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct PointerResult // TypeDefIndex: 16238
{
	// Fields
	public IntPtr Ptr; // 0x0
	public ApiError Error; // 0x8
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct DataResult // TypeDefIndex: 16239
{
	// Fields
	public CaressData Data; // 0x0
	public ApiError Error; // 0x10
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct IntResult // TypeDefIndex: 16240
{
	// Fields
	public int Value; // 0x0
	public ApiError Error; // 0x8
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct BoolResult // TypeDefIndex: 16241
{
	// Fields
	public bool Value; // 0x0
	public ApiError Error; // 0x8
}

// Namespace: VoiceChat.CaressNoiseReduction
public enum ErrorCode // TypeDefIndex: 16242
{
	// Fields
	public byte value__; // 0x0
	public const ErrorCode CaressOk = 1;
	public const ErrorCode ErrorInitialize = 2;
	public const ErrorCode ErrorUnInitialized = 3;
	public const ErrorCode ErrorNoDataSupplied = 4;
	public const ErrorCode ErrorNoTargetBuffer = 5;
	public const ErrorCode ErrorSuppliedDataSize = 6;
	public const ErrorCode ErrorEncode = 7;
	public const ErrorCode ErrorDecode = 8;
	public const ErrorCode ErrorSetBitrate = 9;
	public const ErrorCode ErrorGetBitrate = 10;
	public const ErrorCode ErrorSetBitrateInvalidSize = 11;
	public const ErrorCode ErrorSetComplexity = 12;
	public const ErrorCode ErrorSetComplexityInvalidSize = 13;
	public const ErrorCode ErrorGetComplexity = 14;
	public const ErrorCode ErrorSetSignal = 15;
	public const ErrorCode ErrorSetSignalInvalidValue = 16;
	public const ErrorCode ErrorGetSignal = 17;
	public const ErrorCode ErrorSetInBandFec = 18;
	public const ErrorCode ErrorGetInBandFec = 19;
	public const ErrorCode ErrorSetPacketLossPerc = 20;
	public const ErrorCode ErrorSetPacketLossPercInvalidValue = 21;
	public const ErrorCode ErrorGetPacketLossPerc = 22;
	public const ErrorCode ErrorUnDefined = 23;
}

// Namespace: VoiceChat.CaressNoiseReduction
internal static class CaressWrapper // TypeDefIndex: 16243
{
	// Fields
	private const string DllName = "libcaress";

	// Methods

	// RVA: 0xF79F10 Offset: 0xF79110 VA: 0x180F79F10
	public static extern void CreateNoiseReducer(ref NoiseReducerConfig config, out PointerResult result) { }

	// RVA: 0xF79FA0 Offset: 0xF791A0 VA: 0x180F79FA0
	public static extern void ReduceNoise(IntPtr ptr, short[] pcm, int pcmLength, int channel) { }

	// RVA: 0xF7A050 Offset: 0xF79250 VA: 0x180F7A050
	public static extern void ReduceNoiseFloat(IntPtr ptr, float[] pcm, int pcmLength, int channel) { }

	// RVA: 0xF7A100 Offset: 0xF79300 VA: 0x180F7A100
	public static extern void SetMaxAttenuation(IntPtr ptr, double attenuation) { }

	// RVA: 0xF7A190 Offset: 0xF79390 VA: 0x180F7A190
	public static extern void ChangeRnnModel(IntPtr ptr, RnNoiseModel model) { }

	// RVA: 0xF7A220 Offset: 0xF79420 VA: 0x180F7A220
	public static extern void DestroyNoiseReducer(ref CaressData data) { }
}

// Namespace: VoiceChat.CaressNoiseReduction
public class NoiseReducer : IDisposable // TypeDefIndex: 16244
{
	// Fields
	private IntPtr _ptr; // 0x10

	// Methods

	// RVA: 0xF7A2A0 Offset: 0xF794A0 VA: 0x180F7A2A0
	public void .ctor(NoiseReducerConfig config) { }

	// RVA: 0xF7A3D0 Offset: 0xF795D0 VA: 0x180F7A3D0
	public void ReduceNoise(float[] pcm) { }

	// RVA: 0xF7A4C0 Offset: 0xF796C0 VA: 0x180F7A4C0 Slot: 4
	public void Dispose() { }

	// RVA: 0xF7A5A0 Offset: 0xF797A0 VA: 0x180F7A5A0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: VoiceChat.CaressNoiseReduction
public enum RnNoiseModel // TypeDefIndex: 16245
{
	// Fields
	public byte value__; // 0x0
	public const RnNoiseModel General = 0;
	public const RnNoiseModel GeneralRecording = 1;
	public const RnNoiseModel Voice = 2;
	public const RnNoiseModel VoiceRecording = 3;
	public const RnNoiseModel Speech = 4;
	public const RnNoiseModel SpeechRecording = 5;
	public const RnNoiseModel None = 6;
}

// Namespace: VoiceChat.CaressNoiseReduction
public struct NoiseReducerConfig // TypeDefIndex: 16246
{
	// Fields
	public int NumChannels; // 0x0
	public int SampleRate; // 0x4
	public double Attenuation; // 0x8
	public RnNoiseModel Model; // 0x10
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=359 // TypeDefIndex: 16247
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=427 // TypeDefIndex: 16248
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16249
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=427 BF5114FEA3329F70CDD4D2BEC800E5204F1298269002742B9A19025ABED67C5F /*Metadata offset 0x7EFF98*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=359 C651E3738B7D2E045714E0B556257F09433018FE50BEC5F29039FC9F7F30F511 /*Metadata offset 0x7F0148*/; // 0x1AB
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16250
{}

// Namespace: 
public static class WinApi // TypeDefIndex: 16251
{
	// Fields
	private const string Library = "__Internal";
	private const CallingConvention Convention = 3;
	private static void* _windowHandle; // 0x0

	// Properties
	public static void* WindowHandle { get; }

	// Methods

	// RVA: 0x2184A90 Offset: 0x2183C90 VA: 0x182184A90
	public static void* get_WindowHandle() { }

	// RVA: 0x2184BD0 Offset: 0x2183DD0 VA: 0x182184BD0
	public static extern void* GetWindow() { }

	// RVA: 0x2184C10 Offset: 0x2183E10 VA: 0x182184C10
	public static extern void* FindWindow(ushort* windowClass, ushort* name) { }

	// RVA: 0x2184C50 Offset: 0x2183E50 VA: 0x182184C50
	public static extern uint FlashWindow(void* window, uint enabled) { }

	// RVA: 0x2184CE0 Offset: 0x2183EE0 VA: 0x182184CE0
	public static extern uint ShowWindow(void* window, uint enabled) { }

	// RVA: 0x2184D50 Offset: 0x2183F50 VA: 0x182184D50
	public static extern void* GetPinnedModule(ushort* name) { }

	// RVA: 0x2184DB0 Offset: 0x2183FB0 VA: 0x182184DB0
	public static extern void* GetProcAddress(void* module, sbyte* name) { }

	// RVA: 0x2184E00 Offset: 0x2184000 VA: 0x182184E00
	public static void Throw() { }

	// RVA: 0x2184E50 Offset: 0x2184050 VA: 0x182184E50
	public static void* Throw(void* ptr) { }

	// RVA: 0x2184E70 Offset: 0x2184070 VA: 0x182184E70
	public static uint Throw(uint value) { }

	[CompilerGenerated]
	// RVA: 0x2184E90 Offset: 0x2184090 VA: 0x182184E90
	internal static extern int <Throw>g__GetLastError|11_0() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 16252
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 16253
{
	// Methods

	// RVA: 0x2184EB0 Offset: 0x21840B0 VA: 0x182184EB0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 16254
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 16255
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 16256
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 95AD8D551EB52C590149E43B917BCFE3F117CE5B705E20517E3DD22DD65E3AFB /*Metadata offset 0x7F02C0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 A62EDBE1C652A00E3F5EB3B7C0E777C2F873D13CA2E458246A98E2F2F2932A53 /*Metadata offset 0x7F02F8*/; // 0x30
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16257
{}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 16258
{
	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public string get_Name() { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 16259
{
	// Fields
	private string value; // 0x10

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x4F2FB0 Offset: 0x4F21B0 VA: 0x1804F2FB0
	public string get_Value() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 16260
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 16261
{}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 16262
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x252C180 Offset: 0x252B380 VA: 0x18252C180 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x252C1B0 Offset: 0x252B3B0 VA: 0x18252C1B0 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x252C1E0 Offset: 0x252B3E0 VA: 0x18252C1E0 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x252C210 Offset: 0x252B410 VA: 0x18252C210 Slot: 7
	protected internal virtual void ResetModified() { }
}

// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 16263
{
	// Methods

	// RVA: 0x252C240 Offset: 0x252B440 VA: 0x18252C240 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x252C270 Offset: 0x252B470 VA: 0x18252C270 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x252C2A0 Offset: 0x252B4A0 VA: 0x18252C2A0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x252C2D0 Offset: 0x252B4D0 VA: 0x18252C2D0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public enum ConfigurationSaveMode // TypeDefIndex: 16264
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class ConfigurationPropertyCollection // TypeDefIndex: 16265
{}

// Namespace: System.Configuration
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 16266
{}

// Namespace: System.Configuration
[Usage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 16267
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor(Type itemType) { }
}

// Namespace: System.Configuration
public class ConfigurationSectionGroup // TypeDefIndex: 16268
{}

// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 16269
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x252C300 Offset: 0x252B500 VA: 0x18252C300
	public void .ctor() { }

	// RVA: 0x252C330 Offset: 0x252B530 VA: 0x18252C330 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x252C360 Offset: 0x252B560 VA: 0x18252C360 Slot: 8
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x252C390 Offset: 0x252B590 VA: 0x18252C390 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x252C3C0 Offset: 0x252B5C0 VA: 0x18252C3C0 Slot: 6
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x252C3F0 Offset: 0x252B5F0 VA: 0x18252C3F0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x252C420 Offset: 0x252B620 VA: 0x18252C420 Slot: 9
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 16270
{
	// Methods

	// RVA: 0x252C450 Offset: 0x252B650 VA: 0x18252C450
	public static void ThrowNotSupportedException() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16271
{}

// Namespace: UnityEngine.Rendering.HighDefinition
public class ShaderConfig // TypeDefIndex: 16272
{
	// Fields
	public static int s_CameraRelativeRendering; // 0x0
	public static int s_PreExposition; // 0x4
	public static int s_XrMaxViews; // 0x8
	public static int s_PrecomputedAtmosphericAttenuation; // 0xC
	public static int s_AreaLights; // 0x10
	public static int s_BarnDoor; // 0x14
	public static bool s_GlobalMipBias; // 0x18
	public static int FPTLMaxLightCount; // 0x1C
	public static int PathTracingMaxLightCount; // 0x20

	// Methods

	// RVA: 0x2A42CA0 Offset: 0x2A41EA0 VA: 0x182A42CA0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.HighDefinition
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Packages\com.unity.render-pipelines.high-definition-config\Runtime\ShaderConfig.cs")]
public class InternalLightCullingDefs // TypeDefIndex: 16273
{
	// Fields
	public static int s_MaxNrBigTileLightsPlusOne; // 0x0
	public static int s_LightListMaxCoarseEntries; // 0x4
	public static int s_LightClusterMaxCoarseEntries; // 0x8
	public static int s_LightDwordPerFptlTile; // 0xC
	public static int s_LightClusterPackingCountBits; // 0x10
	public static int s_LightClusterPackingCountMask; // 0x14
	public static int s_LightClusterPackingOffsetBits; // 0x18
	public static int s_LightClusterPackingOffsetMask; // 0x1C

	// Methods

	// RVA: 0x2A42D90 Offset: 0x2A41F90 VA: 0x182A42D90
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 16274
{}

// Namespace: Unity.Burst
internal static class Unsafe // TypeDefIndex: 16275
{
	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937D30 Offset: 0x936F30 VA: 0x180937D30
	|-Unsafe.AsRef<AllocatorManager.Array32768<AllocatorManager.TableEntry>>
	|-Unsafe.AsRef<IntPtr>
	|-Unsafe.AsRef<Long1024>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 16276
{
	// Methods

	// RVA: 0x462F10 Offset: 0x462110 VA: 0x180462F10
	public void .ctor() { }
}

// Namespace: 
internal interface IActivationFactory // TypeDefIndex: 16277
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public override object ActivateInstance() { }
}

// Namespace: System
internal class __Il2CppComObject // TypeDefIndex: 16278
{
	// Methods

	// RVA: 0x3177920 Offset: 0x3176B20 VA: 0x183177920 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System
internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 16279
{
	// Methods

	// RVA: 0x3177920 Offset: 0x3176B20 VA: 0x183177920 Slot: 1
	protected override void Finalize() { }
}

// Namespace: Unity.IL2CPP.Metadata
internal abstract class __Il2CppFullySharedGenericType : ValueType // TypeDefIndex: 16280
{}

// Namespace: Unity.IL2CPP.Metadata
internal abstract struct __Il2CppFullySharedGenericStructType // TypeDefIndex: 16281
{}
