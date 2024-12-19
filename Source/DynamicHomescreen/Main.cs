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
						int num = Main.random.Next(1, 5);
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(-10f, 10f, -85f), Quaternion.identity, gameObject.transform.parent);
						gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
						AnimationWrapper component = gameObject2.GetComponent<AnimationWrapper>();
						if (component != null)
						{
							if (num == 1)
							{
								component.SwapWithSilhouette(55, true);
								this.MarshCoroutine = this.MarshalWait(gameObject2);
								ApplicationController.ApplicationContext.StartCoroutine(this.MarshCoroutine);
							}
							else if (num == 2)
							{
								component.SwapWithSilhouette(44, true);
							}
							else if (num == 3)
							{
								component.SwapWithSilhouette(13, true);
							}
							else if (num == 4)
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
						int num3 = Main.random.Next(1, 7);
						if (Main.random.Next(1, 11) == 1)
						{
							num3 = 7;
						}
						GameObject gameObject4 = null;
						if (num3 > 1)
						{
							gameObject4 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(62f, 41f, 63f), Quaternion.identity, gameObject.transform.parent);
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
									component3.SwapWithSilhouette(56, true);
									break;
								case 7:
									component3.SwapWithSilhouette(52, true);
									break;
								}
							}
						}
						if (Main.random.Next(1, 11) == 1)
						{
							int num4 = Main.random.Next(1, 7);
							int num5 = 0;
							if (num4 == 1)
							{
								num5 = 41;
							}
							else if (num4 == 2)
							{
								num5 = 42;
							}
							else if (num4 == 3)
							{
								num5 = 47;
							}
							else if (num4 == 4)
							{
								num5 = 50;
							}
							GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(gameObject, new Vector3(-45f, 3f, -29.1f), Quaternion.identity, gameObject.transform.parent);
							gameObject5.transform.localScale = new Vector3(1f, 1f, 1f);
							AnimationWrapper component4 = gameObject5.GetComponent<AnimationWrapper>();
							if (component4 != null)
							{
								if (num5 != 0)
								{
									component4.SwapWithSilhouette(num5, true);
									this.ApocCoroutine = this.ApocTransform(gameObject5, num5);
									ApplicationController.ApplicationContext.StartCoroutine(this.ApocCoroutine);
									return;
								}
								if (num4 == 5)
								{
									component4.SwapWithSilhouette(48, true);
									if (num2 != 3)
									{
										this.SKCoroutine = this.SKWait(gameObject5, gameObject, num3, gameObject4);
										ApplicationController.ApplicationContext.StartCoroutine(this.SKCoroutine);
									}
								}
								if (num4 == 6)
								{
									component4.SwapWithSilhouette(51, true);
									if (num2 != 3)
									{
										this.WerewolfCoroutine = this.WerewolfWait(gameObject5, gameObject, num3, gameObject4);
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

		// Token: 0x06000008 RID: 8
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
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000009 RID: 9
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
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
					component = null;
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000071 RID: 113
		public IEnumerator<WaitForSeconds> SKWait(GameObject thesk, GameObject theplr, int thefloatnum, GameObject thefloatguy)
		{
			int KillAnim = 0;
			float startTime = -72f;
			while (KillAnim != 1)
			{
				yield return new WaitForSeconds(7f);
				KillAnim = Main.random.Next(1, 11);
				if (KillAnim == 1)
				{
					AnimationWrapper component3 = thesk.GetComponent<AnimationWrapper>();
					if (component3 != null)
					{
						startTime = Time.time;
						Debug.Log("set start time");
						component3.BoolOn("isRunning");
					}
				}
				yield return null;
			}
			if (startTime != -72f)
			{
				AnimationWrapper component4 = thesk.GetComponent<AnimationWrapper>();
				AnimationWrapper plrc = theplr.GetComponent<AnimationWrapper>();
				while (startTime != -72f)
				{
					float num = (Time.time - startTime) / 2.5f;
					Debug.Log(Time.time - startTime);
					Debug.Log(num);
					if (num > 1f)
					{
						num = 1f;
					}
					if (thesk.transform.position != new Vector3(30f, 3f, -29.1f))
					{
						thesk.transform.position = Vector3.Lerp(new Vector3(-45f, 3f, -29.1f), new Vector3(30f, 3f, -29.1f), num);
					}
					if (thesk.transform.position == new Vector3(30f, 3f, -29.1f) || num == 1f)
					{
						component4.BoolOff("isRunning");
						component4.Trigger("Attack");
						theplr.transform.localScale = new Vector3(-1f, 1f, 1f);
						if (thefloatnum != 6)
						{
							plrc.Trigger("AwaitDeath");
							yield return new WaitForSeconds(1.4f);
						}
						else
						{
							yield return new WaitForSeconds(0.5f);
							thefloatguy.GetComponent<AnimationWrapper>().BoolOn("isRunning");
							yield return null;
							thefloatguy.GetComponent<AnimationWrapper>().BoolOff("isRunning");
							yield return new WaitForSeconds(0.9f);
						}
						if (thefloatnum != 6)
						{
							CinematicEffectPlayer cinematicEffectPlayer = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.AttackHits), plrc.transform);
							plrc.Trigger(cinematicEffectPlayer.playAnimationOnStart);
							plrc.Trigger("Death");
						}
						else
						{
							CinematicEffectPlayer cinematicEffectPlayer2 = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.ClericBubble), plrc.transform);
							plrc.Trigger(cinematicEffectPlayer2.playAnimationOnStart);
						}
						yield return new WaitForSeconds(1.25f);
						if (thefloatnum != 6)
						{
							component4.Trigger("Cinematic_1");
						}
						else
						{
							component4.SwapWithSilhouette(48, true);
							while (thefloatnum == 6)
							{
								yield return new WaitForSeconds(10f);
								component4.Trigger("Attack");
								yield return new WaitForSeconds(0.5f);
								thefloatguy.GetComponent<AnimationWrapper>().BoolOn("isRunning");
								yield return null;
								thefloatguy.GetComponent<AnimationWrapper>().BoolOff("isRunning");
								yield return new WaitForSeconds(0.9f);
								CinematicEffectPlayer cinematicEffectPlayer3 = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.ClericBubble), plrc.transform);
								plrc.Trigger(cinematicEffectPlayer3.playAnimationOnStart);
								yield return new WaitForSeconds(1.25f);
								component4.SwapWithSilhouette(48, true);
							}
						}
						startTime = -72f;
					}
					yield return null;
				}
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
			}
			yield break;
		}

		// Token: 0x06000072 RID: 114
		public IEnumerator<WaitForSeconds> WerewolfWait(GameObject theww, GameObject theplr, int thefloatnum, GameObject thefloatguy)
		{
			int KillAnim = 0;
			float startTime = -72f;
			while (KillAnim != 1)
			{
				yield return new WaitForSeconds(7f);
				KillAnim = Main.random.Next(1, 11);
				if (KillAnim == 1)
				{
					AnimationWrapper component3 = theww.GetComponent<AnimationWrapper>();
					if (component3 != null)
					{
						startTime = Time.time;
						Debug.Log("set start time");
						component3.BoolOn("isRunning");
					}
				}
				yield return null;
			}
			if (startTime != -72f)
			{
				AnimationWrapper component4 = theww.GetComponent<AnimationWrapper>();
				AnimationWrapper plrc = theplr.GetComponent<AnimationWrapper>();
				while (startTime != -72f)
				{
					float num = (Time.time - startTime) / 2.5f;
					float num2 = -72f;
					if (num > 1f)
					{
						num = 1f;
					}
					if (num2 == -72f && theww.transform.position != new Vector3(-15f, 3f, -29.1f))
					{
						theww.transform.position = Vector3.Lerp(new Vector3(-45f, 3f, -29.1f), new Vector3(-15f, 3f, -29.1f), num);
					}
					if (num == 1f)
					{
						if (num2 == -72f)
						{
							theplr.transform.localScale = new Vector3(-1f, 1f, 1f);
							if (thefloatnum != 6)
							{
								plrc.Trigger("AwaitDeath");
							}
						}
						num2 = Time.time - (startTime + 2.5f);
						if (num2 > 1f)
						{
							num2 = 1f;
						}
						if (theww.transform.position != new Vector3(30f, 3f, -29.1f))
						{
							theww.transform.position = Vector3.Lerp(new Vector3(-15f, 3f, -29.1f), new Vector3(30f, 3f, -29.1f), num2);
						}
					}
					if (theww.transform.position == new Vector3(30f, 3f, -29.1f) || num2 == 1f)
					{
						component4.BoolOff("isRunning");
						if (thefloatnum == 6)
						{
							thefloatguy.GetComponent<AnimationWrapper>().BoolOn("isRunning");
							yield return null;
							thefloatguy.GetComponent<AnimationWrapper>().BoolOff("isRunning");
							yield return new WaitForSeconds(0.65f);
						}
						component4.Trigger("Kill");
						yield return new WaitForSeconds(0.25f);
						if (thefloatnum != 6)
						{
							CinematicEffectPlayer cinematicEffectPlayer = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.AttackHits), plrc.transform);
							plrc.Trigger(cinematicEffectPlayer.playAnimationOnStart);
							plrc.Trigger("Death");
						}
						else
						{
							CinematicEffectPlayer cinematicEffectPlayer2 = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.ClericBubble), plrc.transform);
							plrc.Trigger(cinematicEffectPlayer2.playAnimationOnStart);
						}
						yield return new WaitForSeconds(1.25f);
						if (thefloatnum != 6)
						{
							component4.Trigger("Cinematic_1");
						}
						else
						{
							component4.SwapWithSilhouette(51, true);
							while (thefloatnum == 6)
							{
								yield return new WaitForSeconds(10f);
								thefloatguy.GetComponent<AnimationWrapper>().BoolOn("isRunning");
								yield return null;
								thefloatguy.GetComponent<AnimationWrapper>().BoolOff("isRunning");
								yield return new WaitForSeconds(0.65f);
								component4.Trigger("Kill");
								yield return new WaitForSeconds(0.25f);
								CinematicEffectPlayer cinematicEffectPlayer3 = UnityEngine.Object.Instantiate<CinematicEffectPlayer>(Service.Game.Cinematic.GetCinematicAttackEffectPlayerTemplate(CinematicAttackEffect.ClericBubble), plrc.transform);
								plrc.Trigger(cinematicEffectPlayer3.playAnimationOnStart);
								yield return new WaitForSeconds(1.25f);
								component4.SwapWithSilhouette(51, true);
							}
						}
						startTime = -72f;
					}
					yield return null;
				}
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
				component4 = null;
				plrc = null;
			}
			yield break;
		}

		// Token: 0x04000002 RID: 2
		public IEnumerator<WaitForSeconds> MarshCoroutine;

		// Token: 0x04000003 RID: 3
		public static System.Random random = new System.Random();

		// Token: 0x04000004 RID: 4
		public IEnumerator<WaitForSeconds> ApocCoroutine;

		// Token: 0x04000005 RID: 5
		public IEnumerator<WaitForSeconds> WitchCoroutine;

		// Token: 0x04000006 RID: 6
		public IEnumerator<WaitForSeconds> SKCoroutine;

		// Token: 0x04000007 RID: 7
		public IEnumerator<WaitForSeconds> WerewolfCoroutine;
	}
}
