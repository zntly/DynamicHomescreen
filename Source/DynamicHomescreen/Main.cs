using System;
using System.Collections.Generic;
using Cinematics;
using Cinematics.Effects;
using Home.Shared;
using Server.Shared.State;
using Services;
using SML;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DynamicHomescreen
{
	// Token: 0x02000004 RID: 4
	[Mod.SalemMod]
	public class Main
	{
		// Token: 0x06000003 RID: 3
		public void Start()
		{
			Service.Home.ApplicationService.OnSceneLoaded += delegate(SceneType sceneType, LoadSceneMode loadSceneMode)
			{
				if (this.MarshCoroutine != null)
				{
					ApplicationController.ApplicationContext.StopCoroutine(this.MarshCoroutine);
					this.MarshCoroutine = null;
				}
				if (this.ApocCoroutine != null)
				{
					ApplicationController.ApplicationContext.StopCoroutine(this.ApocCoroutine);
					this.ApocCoroutine = null;
				}
				if (this.WitchCoroutine != null)
				{
					ApplicationController.ApplicationContext.StopCoroutine(this.WitchCoroutine);
					this.WitchCoroutine = null;
				}
				if (this.SKCoroutine != null)
				{
					ApplicationController.ApplicationContext.StopCoroutine(this.SKCoroutine);
					this.SKCoroutine = null;
				}
				if (this.WerewolfCoroutine != null)
				{
					ApplicationController.ApplicationContext.StopCoroutine(this.WerewolfCoroutine);
					this.WerewolfCoroutine = null;
				}
				if (Leo.IsHomeScene())
				{
					GameObject gameObject = GameObject.Find("HomeSceneCustomizations/⬢⬡● CharacterWrapper");
					if (gameObject != null)
					{
						int randa = Main.random.Next(1, 5);
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(-10f, 10f, -85f), Quaternion.identity, gameObject.transform.parent);
						gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
						AnimationWrapper component = gameObject2.GetComponent<AnimationWrapper>();
						if (component != null)
						{
							if (randa == 1)
							{
								component.SwapWithSilhouette(55, true);
								this.MarshCoroutine = this.MarshalWait(gameObject2);
								ApplicationController.ApplicationContext.StartCoroutine(this.MarshCoroutine);
							}
							else if (randa == 2)
							{
								component.SwapWithSilhouette(44, true);
							}
							else if (randa == 3)
							{
								component.SwapWithSilhouette(13, true);
							}
							else if (randa == 4)
							{
								component.SwapWithSilhouette(240, true);
							}
						}
						int num2 = Main.random.Next(1, 6);
						if (num2 != 5)
						{
							GameObject gameObject3;
							if (num2 != 3)
							{
								gameObject3 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(-1f, 10f, -75f), Quaternion.identity, gameObject.transform.parent);
							}
							else
							{
								gameObject3 = gameObject;
								gameObject3.transform.position = new Vector3(-1f, 10f, -75f);
							}
							gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
							AnimationWrapper component2 = gameObject3.GetComponent<AnimationWrapper>();
							if (component2 != null)
							{
								if (num2 != 1)
								{
									if (num2 == 2)
									{
										component2.SwapWithSilhouette(39, true);
										this.WitchCoroutine = this.WitchLaugh(gameObject3);
										ApplicationController.ApplicationContext.StartCoroutine(this.WitchCoroutine);
									}
									else if (num2 == 4)
									{
										component2.SwapWithSilhouette(11, true);
									}
								}
								else
								{
									component2.SwapWithSilhouette(45, true);
								}
							}
						}
						int num3 = Main.random.Next(1, 6);
						if (Main.random.Next(1, 11) == 1)
						{
							num3 = 6;
						}
						if (num3 > 1)
						{
							GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(62f, 41f, 63f), Quaternion.identity, gameObject.transform.parent);
							gameObject4.transform.localScale = new Vector3(-1f, 1f, 1f);
							AnimationWrapper component3 = gameObject4.GetComponent<AnimationWrapper>();
							if (component3 != null)
							{
								switch (num3)
								{
								case 2:
									component3.SwapWithSilhouette(43, true);
									break;
								case 3:
									component3.SwapWithSilhouette(26, true);
									break;
								case 4:
									component3.SwapWithSilhouette(25, true);
									break;
								case 5:
									component3.SwapWithSilhouette(49, true);
									break;
								case 6:
									component3.SwapWithSilhouette(52, true);
									break;
								}
							}
						}
						if (Main.random.Next(1, 11) == 1)
						{
							int num4 = Main.random.Next(1, 7);
							int theapocid = 0;
							if (num4 == 1)
							{
								theapocid = 41;
							}
							else if (num4 == 2)
							{
								theapocid = 42;
							}
							else if (num4 == 3)
							{
								theapocid = 47;
							}
							else if (num4 == 4)
							{
								theapocid = 50;
							}
							GameObject gameObjec = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(-45f, 3f, -29.1f), Quaternion.identity, gameObject.transform.parent);
							gameObjec.transform.localScale = new Vector3(1f, 1f, 1f);
							AnimationWrapper componen = gameObjec.GetComponent<AnimationWrapper>();
							if (componen != null)
							{
								if (theapocid != 0)
								{
									componen.SwapWithSilhouette(theapocid, true);
									this.ApocCoroutine = this.ApocTransform(gameObjec, theapocid);
									ApplicationController.ApplicationContext.StartCoroutine(this.ApocCoroutine);
									return;
								}
								if (num4 == 5)
								{
									componen.SwapWithSilhouette(48, true);
									if (num2 != 3)
									{
										this.SKCoroutine = this.SKWait(gameObjec, gameObject);
										ApplicationController.ApplicationContext.StartCoroutine(this.SKCoroutine);
									}
								}
								if (num4 == 6)
								{
									componen.SwapWithSilhouette(51, true);
									if (num2 != 3)
									{
										this.WerewolfCoroutine = this.WerewolfWait(gameObjec, gameObject);
										ApplicationController.ApplicationContext.StartCoroutine(this.WerewolfCoroutine);
									}
								}
							}
						}
						return;
					}
					Debug.Log("Couldn't find character wrapper");
				}
			};
		}

		// Token: 0x06000006 RID: 6
		public IEnumerator<WaitForSeconds> MarshalWait(GameObject themarsh)
		{
			int TribunalAnim = 0;
			while (TribunalAnim != 1)
			{
				yield return new WaitForSeconds(15f);
				TribunalAnim = Main.random.Next(1, 6);
				if (TribunalAnim == 1)
				{
					AnimationWrapper component = themarsh.GetComponent<AnimationWrapper>();
					if (component != null)
					{
						component.Trigger("Cinematic_1");
						if (Utils.IsSkyControllerPP())
						{
							Utils.TempTrib();
						}
					}
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000092 RID: 146
		public IEnumerator<WaitForSeconds> ApocTransform(GameObject theapoc, int apocid)
		{
			int TransformAnim = 0;
			while (TransformAnim != 1)
			{
				yield return new WaitForSeconds(20f);
				TransformAnim = Main.random.Next(1, 11);
				if (TransformAnim == 1)
				{
					AnimationWrapper component = theapoc.GetComponent<AnimationWrapper>();
					if (component != null)
					{
						CinematicEffectPlayer cinematicEffectPlayer = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.ClericBubble), component.transform);
						Debug.Log(cinematicEffectPlayer);
						component.Trigger(cinematicEffectPlayer.playAnimationOnStart);
						int newid;
						if (apocid == 41)
						{
							newid = 250;
						}
						else if (apocid == 42)
						{
							newid = 251;
						}
						else if (apocid == 47)
						{
							newid = 252;
						}
						else
						{
							newid = 253;
						}
						yield return new WaitForSeconds(0.5f);
						component.SwapWithSilhouette(newid, true);
						if (Utils.IsSkyControllerPP())
						{
							Utils.TempApoc();
						}
					}
					component = null;
					component = null;
					component = null;
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000166 RID: 358
		public IEnumerator<WaitForSeconds> WitchLaugh(GameObject thewitch)
		{
			int LaughAnim = 0;
			while (LaughAnim != 1)
			{
				yield return new WaitForSeconds(12f);
				LaughAnim = Main.random.Next(1, 6);
				if (LaughAnim == 1)
				{
					AnimationWrapper component = thewitch.GetComponent<AnimationWrapper>();
					if (component != null)
					{
						component.Trigger("Cinematic_1");
						Service.Home.AudioService.PlaySound("Audio/Sfx/Cackle.wav", false, 1f, 1f);
						yield return new WaitForSeconds(3.6f);
						component.SwapWithSilhouette(39, true);
					}
					component = null;
					component = null;
					component = null;
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001D1 RID: 465
		public IEnumerator<WaitForSeconds> SKWait(GameObject thesk, GameObject theplr)
		{
			int KillAnim = 0;
			float startTime = -72f;
			while (KillAnim != 1)
			{
				yield return new WaitForSeconds(20f);
				KillAnim = Main.random.Next(1, 11);
				if (KillAnim == 1)
				{
					AnimationWrapper component = thesk.GetComponent<AnimationWrapper>();
					if (component != null)
					{
						startTime = Time.time;
						Debug.Log("set start time");
						component.BoolOn("isRunning");
					}
				}
				yield return null;
			}
			if (startTime != -72f)
			{
				AnimationWrapper component2 = thesk.GetComponent<AnimationWrapper>();
				AnimationWrapper plrc = theplr.GetComponent<AnimationWrapper>();
				while (startTime != -72f)
				{
					float frac = (Time.time - startTime) / 2.5f;
					Debug.Log(Time.time - startTime);
					Debug.Log(frac);
					if (frac > 1f)
					{
						frac = 1f;
					}
					if (thesk.transform.position != new Vector3(30f, 3f, -29.1f))
					{
						thesk.transform.position = Vector3.Lerp(new Vector3(-45f, 3f, -29.1f), new Vector3(30f, 3f, -29.1f), frac);
					}
					if (thesk.transform.position == new Vector3(30f, 3f, -29.1f) || frac == 1f)
					{
						component2.BoolOff("isRunning");
						component2.Trigger("Attack");
						theplr.transform.localScale = new Vector3(-1f, 1f, 1f);
						plrc.Trigger("AwaitDeath");
						yield return new WaitForSeconds(1.4f);
						plrc.Trigger("Death");
						yield return new WaitForSeconds(1.25f);
						component2.Trigger("Cinematic_1");
						startTime = -72f;
					}
					yield return null;
				}
				component2 = null;
				plrc = null;
				component2 = null;
				plrc = null;
				component2 = null;
				plrc = null;
			}
			yield break;
		}

		// Token: 0x060002F8 RID: 760
		public IEnumerator<WaitForSeconds> WerewolfWait(GameObject theww, GameObject theplr)
		{
			int KillAnim = 0;
			float startTime = -72f;
			while (KillAnim != 1)
			{
				yield return new WaitForSeconds(20f);
				KillAnim = Main.random.Next(1, 11);
				if (KillAnim == 1)
				{
					AnimationWrapper component = theww.GetComponent<AnimationWrapper>();
					if (component != null)
					{
						startTime = Time.time;
						Debug.Log("set start time");
						component.BoolOn("isRunning");
					}
				}
				yield return null;
			}
			if (startTime != -72f)
			{
				AnimationWrapper component2 = theww.GetComponent<AnimationWrapper>();
				AnimationWrapper plrc = theplr.GetComponent<AnimationWrapper>();
				while (startTime != -72f)
				{
					float frac = (Time.time - startTime) / 2.5f;
					float frac2 = -72f;
					if (frac > 1f)
					{
						frac = 1f;
					}
					if (frac2 == -72f && theww.transform.position != new Vector3(-15f, 3f, -29.1f))
					{
						theww.transform.position = Vector3.Lerp(new Vector3(-45f, 3f, -29.1f), new Vector3(-15f, 3f, -29.1f), frac);
					}
					if (frac == 1f)
					{
						if (frac2 == -72f)
						{
							theplr.transform.localScale = new Vector3(-1f, 1f, 1f);
							plrc.Trigger("AwaitDeath");
						}
						frac2 = Time.time - (startTime + 2.5f);
						if (frac2 > 1f)
						{
							frac2 = 1f;
						}
						if (theww.transform.position != new Vector3(30f, 3f, -29.1f))
						{
							theww.transform.position = Vector3.Lerp(new Vector3(-15f, 3f, -29.1f), new Vector3(30f, 3f, -29.1f), frac2);
						}
					}
					if (theww.transform.position == new Vector3(30f, 3f, -29.1f) || frac2 == 1f)
					{
						component2.BoolOff("isRunning");
						component2.Trigger("Kill");
						yield return new WaitForSeconds(0.25f);
						plrc.Trigger("Death");
						yield return new WaitForSeconds(1.25f);
						component2.Trigger("Cinematic_1");
						startTime = -72f;
					}
					yield return null;
				}
				component2 = null;
				plrc = null;
				component2 = null;
				plrc = null;
				component2 = null;
				plrc = null;
			}
			yield break;
		}

		// Token: 0x04000002 RID: 2
		public IEnumerator<WaitForSeconds> MarshCoroutine;

		// Token: 0x04000003 RID: 3
		public static System.Random random = new System.Random();

		// Token: 0x0400004C RID: 76
		public IEnumerator<WaitForSeconds> ApocCoroutine;

		// Token: 0x040000D8 RID: 216
		public IEnumerator<WaitForSeconds> WitchCoroutine;

		// Token: 0x0400014D RID: 333
		public IEnumerator<WaitForSeconds> SKCoroutine;

		// Token: 0x04000263 RID: 611
		public IEnumerator<WaitForSeconds> WerewolfCoroutine;
	}
}
