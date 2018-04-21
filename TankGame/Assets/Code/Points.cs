using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TankGame.Localization;

namespace TankGame
{
    public class Points : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        [SerializeField]
        private string _key;

        [SerializeField]
        private string _secondKey;

        public static int points;

        public static int deaths;

        private void Awake()
        {
            Localization.Localization.LanguageLoaded += OnLanguageLoaded;
        }

        private void OnLanguageLoaded(LangCode currentLanguage)
        {
            _text.text =
                Localization.Localization.CurrentLanguage.GetTranslation(_key);
        }

        void Start()
        {
            OnLanguageLoaded(Localization.Localization.CurrentLanguage.LanguageCode);
        }

        private void Update()
        {
            _text.text =
                Localization.Localization.CurrentLanguage.GetTranslation(_key)+ points + "\n" 
                + Localization.Localization.CurrentLanguage.GetTranslation(_secondKey) + deaths;
        }
    }
}

