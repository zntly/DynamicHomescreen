using System;
using SkyControllerPP;
using SML;

namespace DynamicHomescreen
{
	// Token: 0x02000077 RID: 119
	public static class Utils
	{
		// Token: 0x060003C0 RID: 960
		public static bool SkyControllerPPExists()
		{
			if (ModStates.IsEnabled("curtis.day.night.sync"))
			{
				string set = "nnnah!!";
				try
				{
					set = ModSettings.GetString("Tribunal Skybox", "curtis.day.night.sync");
				}
				catch
				{
					set = "nnnah!!";
				}
				return set != "nnnah!!" && set != "";
			}
			return false;
		}

		// Token: 0x060003C1 RID: 961
		public static bool IsSkyControllerPP()
		{
			bool result;
			try
			{
				result = Utils.IsSkyControllerPPBypass();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003C2 RID: 962
		private static bool IsSkyControllerPPBypass()
		{
			return Utils.SkyControllerPPExists();
		}

		// Token: 0x060003C6 RID: 966
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

		// Token: 0x060003C7 RID: 967
		public static void TempApoc()
		{
			try
			{
				SkyInfo.Instance.Pest = true;
				SkyInfo.Instance.UpdateSky();
			}
			catch
			{
			}
		}
	}
}
