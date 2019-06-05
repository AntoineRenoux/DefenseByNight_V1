﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class EnumAtoutFlaw
    {
        public enum TypeAtout
        {
            Clan,
            General,
            Morality,
            Rarity
        }

        #region Clan Rarity
        public readonly static string ATOUT_UNCOMMUN_CLAN_KEY = "ATOUT_UNCOMMUN_CLAN_KEY";
        public readonly static string ATOUT_UNCOMMUN_CLAN_NAME = "ATOUT_UNCOMMUN_CLAN_NAME";
        public readonly static string ATOUT_UNCOMMUN_CLAN_DESCRIPTION = "ATOUT_UNCOMMUN_CLAN_DESCRIPTION";

        public readonly static string ATOUT_RARE_CLAN_KEY = "ATOUT_RARE_CLAN_KEY";
        public readonly static string ATOUT_RARE_CLAN_NAME = "ATOUT_RARE_CLAN_NAME";
        public readonly static string ATOUT_RARE_CLAN_DESCRIPTION = "ATOUT_RARE_CLAN_DESCRIPTION";

        public readonly static string ATOUT_RESTRAINED_CLAN_KEY = "ATOUT_RESTRAINED_CLAN_KEY";
        public readonly static string ATOUT_RESTRAINED_CLAN_NAME = "ATOUT_RESTRAINED_CLAN_NAME";
        public readonly static string ATOUT_RESTRAINED_CLAN_DESCRIPTION = "ATOUT_RESTRAINED_CLAN_DESCRIPTION";
        #endregion

        #region General
        public readonly static string ATOUT_AMBIDEXTROUS_KEY = "ATOUT_AMBIDEXTROUS_KEY";
        public readonly static string ATOUT_AMBIDEXTROUS_NAME = "ATOUT_AMBIDEXTROUS_NAME";
        public readonly static string ATOUT_AMBIDEXTROUS_DESCRIPTION = "ATOUT_AMBIDEXTROUS_DESCRIPTION";

        public readonly static string ATOUT_EEL_KEY = "ATOUT_EEL_KEY";
        public readonly static string ATOUT_EEL_NAME = "ATOUT_EEL_NAME";
        public readonly static string ATOUT_EEL_DESCRIPTION = "ATOUT_EEL_DESCRIPTION";

        public readonly static string ATOUT_ABLE_IN_COMPETENCE_KEY = "ATOUT_ABLE_IN_COMPETENCE_KEY";
        public readonly static string ATOUT_ABLE_IN_COMPETENCE_NAME = "ATOUT_ABLE_IN_COMPETENCE_NAME";
        public readonly static string ATOUT_ABLE_IN_COMPETENCE_DESCRIPTION = "ATOUT_ABLE_IN_COMPETENCE_DESCRIPTION";

        public readonly static string ATOUT_ARCANE_KEY = "ATOUT_ARCANE_KEY";
        public readonly static string ATOUT_ARCANE_NAME = "ATOUT_ARCANE_NAME";
        public readonly static string ATOUT_ARCANE_DESCRIPTION = "ATOUT_ARCANE_DESCRIPTION";

        public readonly static string ATOUT_BLASE_KEY = "ATOUT_BLASE_KEY";
        public readonly static string ATOUT_BLASE_NAME = "ATOUT_BLASE_NAME";
        public readonly static string ATOUT_BLASE_DESCRIPTION = "ATOUT_BLASE_DESCRIPTION";

        public readonly static string ATOUT_DARE_DEVIL_KEY = "ATOUT_DARE_DEVIL_KEY";
        public readonly static string ATOUT_DARE_DEVIL_NAME = "ATOUT_DARE_DEVIL_NAME";
        public readonly static string ATOUT_DARE_DEVIL_DESCRIPTION = "ATOUT_DARE_DEVIL_DESCRIPTION";

        public readonly static string ATOUT_PROPHECY_KEY = "ATOUT_PROPHECY_KEY";
        public readonly static string ATOUT_PROPHECY_NAME = "ATOUT_PROPHECY_NAME";
        public readonly static string ATOUT_PROPHECY_DESCRIPTION = "ATOUT_PROPHECY_DESCRIPTION";

        public readonly static string ATOUT_LUCKY_KEY = "ATOUT_LUCKY_KEY";
        public readonly static string ATOUT_LUCKY_NAME = "ATOUT_LUCKY_NAME";
        public readonly static string ATOUT_LUCKY_DESCRIPTION = "ATOUT_LUCKY_DESCRIPTION";

        public readonly static string ATOUT_FARSEEING_KEY = "ATOUT_FARSEEING_KEY";
        public readonly static string ATOUT_FARSEEING_NAME = "ATOUT_FARSEEING_NAME";
        public readonly static string ATOUT_FARSEEING_DESCRIPTION = "ATOUT_FARSEEING_DESCRIPTION";

        public readonly static string ATOUT_HONOR_KEY = "ATOUT_HONOR_KEY";
        public readonly static string ATOUT_HONOR_NAME = "ATOUT_HONOR_NAME";
        public readonly static string ATOUT_HONOR_DESCRIPTION = "ATOUT_HONOR_DESCRIPTION";

        public readonly static string ATOUT_DIGESTION_KEY = "ATOUT_DIGESTION_KEY";
        public readonly static string ATOUT_DIGESTION_NAME = "ATOUT_DIGESTION_NAME";
        public readonly static string ATOUT_DIGESTION_DESCRIPTION = "ATOUT_DIGESTION_DESCRIPTION";

        public readonly static string ATOUT_COMMON_DISCIPLINE_KEY = "ATOUT_COMMON_DISCIPLINE_KEY";
        public readonly static string ATOUT_COMMON_DISCIPLINE_NAME = "ATOUT_COMMON_DISCIPLINE_NAME";
        public readonly static string ATOUT_COMMON_DISCIPLINE_DESCRIPTION = "ATOUT_COMMON_DISCIPLINE_DESCRIPTION";

        public readonly static string ATOUT_LANGUAGE_GIFT_KEY = "ATOUT_LANGUAGE_GIFT_KEY";
        public readonly static string ATOUT_LANGUAGE_GIFT_NAME = "ATOUT_LANGUAGE_GIFT_NAME";
        public readonly static string ATOUT_LANGUAGE_GIFT_DESCRIPTION = "ATOUT_LANGUAGE_GIFT_DESCRIPTION";

        public readonly static string ATOUT_SCHOLAR_KEY = "ATOUT_SCHOLAR_KEY";
        public readonly static string ATOUT_SCHOLAR_NAME = "ATOUT_SCHOLAR_NAME";
        public readonly static string ATOUT_SCHOLAR_DESCRIPTION = "ATOUT_SCHOLAR_DESCRIPTION";

        public readonly static string ATOUT_NECROMANCY_KEY = "ATOUT_NECROMANCY_KEY";
        public readonly static string ATOUT_NECROMANCY_NAME = "ATOUT_NECROMANCY_NAME";
        public readonly static string ATOUT_NECROMANCY_DESCRIPTION = "ATOUT_NECROMANCY_DESCRIPTION";

        public readonly static string ATOUT_THAUMATURGY_KEY = "ATOUT_THAUMATURGY_KEY";
        public readonly static string ATOUT_THAUMATURGY_NAME = "ATOUT_THAUMATURGY_NAME";
        public readonly static string ATOUT_THAUMATURGY_DESCRIPTION = "ATOUT_THAUMATURGY_DESCRIPTION";

        public readonly static string ATOUT_INALIENABLE_KEY = "ATOUT_INALIENABLE_KEY";
        public readonly static string ATOUT_INALIENABLE_NAME = "ATOUT_INALIENABLE_NAME";
        public readonly static string ATOUT_INALIENABLE_DESCRIPTION = "ATOUT_INALIENABLE_DESCRIPTION";

        public readonly static string ATOUT_INFLEXIBLE_KEY = "ATOUT_INFLEXIBLE_KEY";
        public readonly static string ATOUT_INFLEXIBLE_NAME = "ATOUT_INFLEXIBLE_NAME";
        public readonly static string ATOUT_INFLEXIBLE_DESCRIPTION = "ATOUT_INFLEXIBLE_DESCRIPTION";

        public readonly static string ATOUT_PERSONNAL_MASCARADE_KEY = "ATOUT_PERSONNAL_MASCARADE_KEY";
        public readonly static string ATOUT_PERSONNAL_MASCARADE_NAME = "ATOUT_PERSONNAL_MASCARADE_NAME";
        public readonly static string ATOUT_PERSONNAL_MASCARADE_DESCRIPTION = "ATOUT_PERSONNAL_MASCARADE_DESCRIPTION";

        public readonly static string ATOUT_MEDIUM_KEY = "ATOUT_MEDIUM_KEY";
        public readonly static string ATOUT_MEDIUM_NAME = "ATOUT_MEDIUM_NAME";
        public readonly static string ATOUT_MEDIUM_DESCRIPTION = "ATOUT_MEDIUM_DESCRIPTION";

        public readonly static string ATOUT_INFERNAL_POWER_KEY = "ATOUT_INFERNAL_POWER_KEY";
        public readonly static string ATOUT_INFERNAL_POWER_NAME = "ATOUT_INFERNAL_POWER_NAME";
        public readonly static string ATOUT_INFERNAL_POWER_DESCRIPTION = "ATOUT_INFERNAL_POWER_DESCRIPTION";

        public readonly static string ATOUT_PRECOCIOUS_KEY = "ATOUT_PRECOCIOUS_KEY";
        public readonly static string ATOUT_PRECOCIOUS_NAME = "ATOUT_PRECOCIOUS_NAME";
        public readonly static string ATOUT_PRECOCIOUS_DESCRIPTION = "ATOUT_PRECOCIOUS_DESCRIPTION";

        public readonly static string ATOUT_REPUTATION_KEY = "ATOUT_REPUTATION_KEY";
        public readonly static string ATOUT_REPUTATION_NAME = "ATOUT_REPUTATION_NAME";
        public readonly static string ATOUT_REPUTATION_DESCRIPTION = "ATOUT_REPUTATION_DESCRIPTION";

        public readonly static string ATOUT_MAGIC_RESIST_KEY = "ATOUT_MAGIC_RESIST_KEY";
        public readonly static string ATOUT_MAGIC_RESIST_NAME = "ATOUT_MAGIC_RESIST_NAME";
        public readonly static string ATOUT_MAGIC_RESIST_DESCRIPTION = "ATOUT_MAGIC_RESIST_DESCRIPTION";

        public readonly static string ATOUT_ROBUST_KEY = "ATOUT_ROBUST_KEY";
        public readonly static string ATOUT_ROBUST_NAME = "ATOUT_ROBUST_NAME";
        public readonly static string ATOUT_ROBUST_DESCRIPTION = "ATOUT_ROBUST_DESCRIPTION";

        public readonly static string ATOUT_COOL_KEY = "ATOUT_COOL_KEY";
        public readonly static string ATOUT_COOL_NAME = "ATOUT_COOL_NAME";
        public readonly static string ATOUT_COOL_DESCRIPTION = "ATOUT_COOL_DESCRIPTION";

        public readonly static string ATOUT_SENSE_KEY = "ATOUT_SENSE_KEY";
        public readonly static string ATOUT_SENSE_NAME = "ATOUT_SENSE_NAME";
        public readonly static string ATOUT_SENSE_DESCRIPTION = "ATOUT_SENSE_DESCRIPTION";

        public readonly static string ATOUT_LIGHT_SLEEP_KEY = "ATOUT_LIGHT_SLEEP_KEY";
        public readonly static string ATOUT_LIGHT_SLEEP_NAME = "ATOUT_LIGHT_SLEEP_NAME";
        public readonly static string ATOUT_LIGHT_SLEEP_DESCRIPTION = "ATOUT_LIGHT_SLEEP_DESCRIPTION";

        public readonly static string ATOUT_LIFE_BREATH_KEY = "ATOUT_LIFE_BREATH_KEY";
        public readonly static string ATOUT_LIFE_BREATH_NAME = "ATOUT_LIFE_BREATH_NAME";
        public readonly static string ATOUT_LIFE_BREATH_DESCRIPTION = "ATOUT_LIFE_BREATH_DESCRIPTION";

        public readonly static string ATOUT_GOLCONDE_PATH_KEY = "ATOUT_GOLCONDE_PATH_KEY";
        public readonly static string ATOUT_GOLCONDE_PATH_NAME = "ATOUT_GOLCONDE_PATH_NAME";
        public readonly static string ATOUT_GOLCONDE_PATH_DESCRIPTION = "ATOUT_GOLCONDE_PATH_DESCRIPTION";

        public readonly static string ATOUT_JACK_OF_ALL_TRADE_KEY = "ATOUT_JACK_OF_ALL_TRADE_KEY";
        public readonly static string ATOUT_JACK_OF_ALL_TRADE_NAME = "ATOUT_JACK_OF_ALL_TRADE_NAME";
        public readonly static string ATOUT_JACK_OF_ALL_TRADE_DESCRIPTION = "ATOUT_JACK_OF_ALL_TRADE_DESCRIPTION";

        public readonly static string ATOUT_VITALITY_KEY = "ATOUT_VITALITY_KEY";
        public readonly static string ATOUT_VITALITY_NAME = "ATOUT_VITALITY_NAME";
        public readonly static string ATOUT_VITALITY_DESCRIPTION = "ATOUT_VITALITY_DESCRIPTION";

        public readonly static string ATOUT_IRON_WILL_KEY = "ATOUT_IRON_WILL_KEY";
        public readonly static string ATOUT_IRON_WILL_NAME = "ATOUT_IRON_WILL_NAME";
        public readonly static string ATOUT_IRON_WILL_DESCRIPTION = "ATOUT_IRON_WILL_DESCRIPTION";

        #endregion

        #region Assamite
        public readonly static string ATOUT_ASSAMITE_SURPRISE_KEY = "ATOUT_ASSAMITE_SURPRISE_KEY";
        public readonly static string ATOUT_ASSAMITE_SURPRISE_NAME = "ATOUT_ASSAMITE_SURPRISE_NAME";
        public readonly static string ATOUT_ASSAMITE_SURPRISE_DESCRIPTION = "ATOUT_ASSAMITE_SURPRISE_DESCRIPTION";

        public readonly static string ATOUT_ASSAMITE_VIZIR_KEY = "ATOUT_ASSAMITE_VIZIR_KEY";
        public readonly static string ATOUT_ASSAMITE_VIZIR_NAME = "ATOUT_ASSAMITE_VIZIR_NAME";
        public readonly static string ATOUT_ASSAMITE_VIZIR_DESCRIPTION = "ATOUT_ASSAMITE_VIZIR_DESCRIPTION";

        public readonly static string ATOUT_ASSAMITE_STEAL_KEY = "ATOUT_ASSAMITE_STEAL_KEY";
        public readonly static string ATOUT_ASSAMITE_STEAL_NAME = "ATOUT_ASSAMITE_STEAL_NAME";
        public readonly static string ATOUT_ASSAMITE_STEAL_DESCRIPTION = "ATOUT_ASSAMITE_STEAL_DESCRIPTION";

        public readonly static string ATOUT_ASSAMITE_WARLOCK_KEY = "ATOUT_ASSAMITE_WARLOCK_KEY";
        public readonly static string ATOUT_ASSAMITE_WARLOCK_NAME = "ATOUT_ASSAMITE_WARLOCK_NAME";
        public readonly static string ATOUT_ASSAMITE_WARLOCK_DESCRIPTION = "ATOUT_ASSAMITE_WARLOCK_DESCRIPTION";
        #endregion

        #region Brujah
        public readonly static string ATOUT_BRUJAH_BROTHERHOOD_KEY = "ATOUT_BRUJAH_BROTHERHOOD_KEY";
        public readonly static string ATOUT_BRUJAH_BROTHERHOOD_NAME = "ATOUT_BRUJAH_BROTHERHOOD_NAME";
        public readonly static string ATOUT_BRUJAH_BROTHERHOOD_DESCRIPTION = "ATOUT_BRUJAH_BROTHERHOOD_DESCRIPTION";

        public readonly static string ATOUT_BRUJAH_ANGER_KEY = "ATOUT_BRUJAH_ANGER_KEY";
        public readonly static string ATOUT_BRUJAH_ANGER_NAME = "ATOUT_BRUJAH_ANGER_NAME";
        public readonly static string ATOUT_BRUJAH_ANGER_DESCRIPTION = "ATOUT_BRUJAH_ANGER_DESCRIPTION";

        public readonly static string ATOUT_BRUJAH_ALECTO_KEY = "ATOUT_BRUJAH_ALECTO_KEY";
        public readonly static string ATOUT_BRUJAH_ALECTO_NAME = "ATOUT_BRUJAH_ALECTO_NAME";
        public readonly static string ATOUT_BRUJAH_ALECTO_DESCRIPTION = "ATOUT_BRUJAH_ALECTO_DESCRIPTION";

        public readonly static string ATOUT_BRUJAH_TRUE_KEY = "ATOUT_BRUJAH_TRUE_KEY";
        public readonly static string ATOUT_BRUJAH_TRUE_NAME = "ATOUT_BRUJAH_TRUE_NAME";
        public readonly static string ATOUT_BRUJAH_TRUE_DESCRIPTION = "ATOUT_BRUJAH_TRUE_DESCRIPTION";
        #endregion

        #region Set
        public readonly static string ATOUT_SET_PERSONNAL_KULT_KEY = "ATOUT_SET_PERSONNAL_KULT_KEY";
        public readonly static string ATOUT_SET_PERSONNAL_KULT_NAME = "ATOUT_SET_PERSONNAL_KULT_NAME";
        public readonly static string ATOUT_SET_PERSONNAL_KULT_DESCRIPTION = "ATOUT_SET_PERSONNAL_KULT_DESCRIPTION";
                                            
        public readonly static string ATOUT_SET_TLACIQUE_KEY = "ATOUT_SET_TLACIQUE_KEY";
        public readonly static string ATOUT_SET_TLACIQUE_NAME = "ATOUT_SET_TLACIQUE_NAME";
        public readonly static string ATOUT_SET_TLACIQUE_DESCRIPTION = "ATOUT_SET_TLACIQUE_DESCRIPTION";
                                            
        public readonly static string ATOUT_SET_VIPERS_KEY = "ATOUT_SET_VIPERS_KEY";
        public readonly static string ATOUT_SET_VIPERS_NAME = "ATOUT_SET_VIPERS_NAME";
        public readonly static string ATOUT_SET_VIPERS_DESCRIPTION = "ATOUT_SET_VIPERS_DESCRIPTION";
                                            
        public readonly static string ATOUT_SET_BLOOD_KEY = "ATOUT_SET_BLOOD_KEY";
        public readonly static string ATOUT_SET_BLOOD_NAME = "ATOUT_SET_BLOOD_NAME";
        public readonly static string ATOUT_SET_BLOOD_DESCRIPTION = "ATOUT_SET_BLOOD_DESCRIPTION";

        public readonly static string ATOUT_SET_WITCHCRAFT_KEY = "ATOUT_SET_WITCHCRAFT_KEY";
        public readonly static string ATOUT_SET_WITCHCRAFT_NAME = "ATOUT_SET_WITCHCRAFT_NAME";
        public readonly static string ATOUT_SET_WITCHCRAFT_DESCRIPTION = "ATOUT_SET_WITCHCRAFT_DESCRIPTION";
        #endregion

        #region Gangrel
        public readonly static string ATOUT_GANGREL_BLOOD_KEY = "ATOUT_GANGREL_BLOOD_KEY";
        public readonly static string ATOUT_GANGREL_BLOOD_NAME = "ATOUT_GANGREL_BLOOD_NAME";
        public readonly static string ATOUT_GANGREL_BLOOD_DESCRIPTION = "ATOUT_GANGREL_BLOOD_DESCRIPTION";

        public readonly static string ATOUT_GANGREL_COYOTE_KEY = "ATOUT_GANGREL_COYOTE_KEY";
        public readonly static string ATOUT_GANGREL_COYOTE_NAME = "ATOUT_GANGREL_COYOTE_NAME";
        public readonly static string ATOUT_GANGREL_COYOTE_DESCRIPTION = "ATOUT_GANGREL_COYOTE_DESCRIPTION";

        public readonly static string ATOUT_GANGREL_NOIAD_KEY = "ATOUT_GANGREL_NOIAD_KEY";
        public readonly static string ATOUT_GANGREL_NOIAD_NAME = "ATOUT_GANGREL_NOIAD_NAME";
        public readonly static string ATOUT_GANGREL_NOIAD_DESCRIPTION = "ATOUT_GANGREL_NOIAD_DESCRIPTION";

        public readonly static string ATOUT_GANGREL_BEAST_ANGER_KEY = "ATOUT_GANGREL_BEAST_ANGER_KEY";
        public readonly static string ATOUT_GANGREL_BEAST_ANGER_NAME = "ATOUT_GANGREL_BEAST_ANGER_NAME";
        public readonly static string ATOUT_GANGREL_BEAST_ANGER_DESCRIPTION = "ATOUT_GANGREL_BEAST_ANGER_DESCRIPTION";

        public readonly static string ATOUT_GANGREL_AHRIMANES_KEY = "ATOUT_GANGREL_AHRIMANES_ANGER_KEY";
        public readonly static string ATOUT_GANGREL_AHRIMANES_NAME = "ATOUT_GANGREL_AHRIMANES_ANGER_NAME";
        public readonly static string ATOUT_GANGREL_AHRIMANES_DESCRIPTION = "ATOUT_GANGREL_AHRIMANES_ANGER_DESCRIPTION";
        #endregion

        #region Giovanni
        public readonly static string ATOUT_GIOVANNI_NECROMANCY_KEY = "ATOUT_GIOVANNI_NECROMANCY_KEY";
        public readonly static string ATOUT_GIOVANNI_NECROMANCY_NAME = "ATOUT_GIOVANNI_NECROMANCY_NAME";
        public readonly static string ATOUT_GIOVANNI_NECROMANCY_DESCRIPTION = "ATOUT_GIOVANNI_NECROMANCY_DESCRIPTION";

        public readonly static string ATOUT_GIOVANNI_BIG_ARMS_KEY = "ATOUT_GIOVANNI_BIG_ARMS_KEY";
        public readonly static string ATOUT_GIOVANNI_BIG_ARMS_NAME = "ATOUT_GIOVANNI_BIG_ARMS_NAME";
        public readonly static string ATOUT_GIOVANNI_BIG_ARMS_DESCRIPTION = "ATOUT_GIOVANNI_BIG_ARMS_DESCRIPTION";

        public readonly static string ATOUT_GIOVANNI_GHOST_KEY = "ATOUT_GIOVANNI_GHOST_KEY";
        public readonly static string ATOUT_GIOVANNI_GHOST_NAME = "ATOUT_GIOVANNI_GHOST_NAME";
        public readonly static string ATOUT_GIOVANNI_GHOST_DESCRIPTION = "ATOUT_GIOVANNI_GHOST_DESCRIPTION";

        public readonly static string ATOUT_GIOVANNI_PREMASCINE_KEY = "ATOUT_GIOVANNI_PREMASCINE_KEY";
        public readonly static string ATOUT_GIOVANNI_PREMASCINE_NAME = "ATOUT_GIOVANNI_PREMASCINE_NAME";
        public readonly static string ATOUT_GIOVANNI_PREMASCINE_DESCRIPTION = "ATOUT_GIOVANNI_PREMASCINE_DESCRIPTION";
        #endregion

        #region Lasombra
        public readonly static string ATOUT_LASOMBRA_ANGEL_FACE_KEY = "ATOUT_LASOMBRA_ANGEL_FACE_KEY";
        public readonly static string ATOUT_LASOMBRA_ANGEL_FACE_NAME = "ATOUT_LASOMBRA_ANGEL_FACE_NAME";
        public readonly static string ATOUT_LASOMBRA_ANGEL_FACE_DESCRIPTION = "ATOUT_LASOMBRA_ANGEL_FACE_DESCRIPTION";

        public readonly static string ATOUT_LASOMBRA_BORN_IN_SHADOWS_KEY = "ATOUT_LASOMBRA_BORN_IN_SHADOWS_KEY";
        public readonly static string ATOUT_LASOMBRA_BORN_IN_SHADOWS_NAME = "ATOUT_LASOMBRA_BORN_IN_SHADOWS_NAME";
        public readonly static string ATOUT_LASOMBRA_BORN_IN_SHADOWS_DESCRIPTION = "ATOUT_LASOMBRA_BORN_IN_SHADOWS_DESCRIPTION";

        public readonly static string ATOUT_LASOMBRA_ABYSS_KEY = "ATOUT_LASOMBRA_ABYSS_KEY";
        public readonly static string ATOUT_LASOMBRA_ABYSS_NAME = "ATOUT_LASOMBRA_ABYSS_NAME";
        public readonly static string ATOUT_LASOMBRA_ABYSS_DESCRIPTION = "ATOUT_LASOMBRA_ABYSS_DESCRIPTION";

        public readonly static string ATOUT_LASOMBRA_KIASYDE_KEY = "ATOUT_LASOMBRA_KIASYDE_KEY";
        public readonly static string ATOUT_LASOMBRA_KIASYDE_NAME = "ATOUT_LASOMBRA_KIASYDE_NAME";
        public readonly static string ATOUT_LASOMBRA_KIASYDE_DESCRIPTION = "ATOUT_LASOMBRA_KIASYDE_DESCRIPTION";
        #endregion

        public enum TypeFlaw
        {
            Clan,
            General
        }
    }
}
