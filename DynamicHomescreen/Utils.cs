using System;
using DayNight;
using SML;

namespace DynamicHomescreen
{
	// Token: 0x02000013 RID: 19
	public static class Utils
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public static bool SkyControllerExists()
		{
			if (ModStates.IsEnabled("curtis.day.night.sync"))
			{
				string a = "nnnah!!";
				try
				{
					a = ModSettings.GetString("Tribunal Skybox", "curtis.day.night.sync");
				}
				catch
				{
					a = "nnnah!!";
				}
				return a != "nnnah!!" && a != "";
			}
			return false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005D28 File Offset: 0x00003F28
		public static bool IsSkyController()
		{
			bool result;
			try
			{
				result = Utils.IsSkyControllerBypass();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022B1 File Offset: 0x000004B1
		private static bool IsSkyControllerBypass()
		{
			return Utils.SkyControllerExists();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005D54 File Offset: 0x00003F54
		public static void TempTrib()
		{
			try
			{
				SkyInfo.Phase = "Tribunal";
				SkyInfo.Instance.UpdateSky();
			}
			catch
			{
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005D8C File Offset: 0x00003F8C
		public static void TempApoc()
		{
			try
			{
				SkyInfo.Instance.Pest = 1;
				SkyInfo.Instance.UpdateSky();
			}
			catch
			{
			}
		}
	}
}
