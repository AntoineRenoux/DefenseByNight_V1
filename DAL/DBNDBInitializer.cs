using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Ref;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class DBNDBInitializer : DropCreateDatabaseAlways<DBNContext>
    {
        protected override void Seed(DBNContext context)
        {
            //1036 : Français

            LabelInitializer.Initializer(context);
            ErrorMessageInitializer.Initializer(context);

            #region Focus
            var focus = new List<Focus>
            {
               new Focus{FocusKey = "PHYSICAL_STRENGTH_NAME", FocusName = "PHYSICAL_STRENGTH_NAME", Description = "PHYSICAL_STRENGTH_DESCRIPTION" },
               new Focus{FocusKey = "PHYSICAL_DEXTERITY_NAME", FocusName = "PHYSICAL_DEXTERITY_NAME", Description = "PHYSICAL_DEXTERITY_DESCRIPTION" },
               new Focus{FocusKey = "PHYSICAL_STAMINA_NAME", FocusName = "PHYSICAL_STAMINA_NAME", Description = "PHYSICAL_STAMINA_DESCRIPTION" },
               new Focus{FocusKey = "SOCIAL_CHARISMA_NAME", FocusName = "SOCIAL_CHARISMA_NAME", Description = "SOCIAL_CHARISMA_DESCRIPTION" },
               new Focus{FocusKey = "SOCIAL_MANIPULATION_NAME", FocusName = "SOCIAL_MANIPULATION_NAME", Description = "SOCIAL_MANIPULATION_DESCRIPTION" },
               new Focus{FocusKey = "SOCIAL_APPEARANCE_NAME", FocusName = "SOCIAL_APPEARANCE_NAME", Description = "SOCIAL_APPEARANCE_DESCRIPTION" },
               new Focus{FocusKey = "MENTAL_PERCEPTION_NAME", FocusName = "MENTAL_PERCEPTION_NAME", Description = "MENTAL_PERCEPTION_DESCRIPTION" },
               new Focus{FocusKey = "MENTAL_INTELLIGENCE_NAME", FocusName = "MENTAL_INTELLIGENCE_NAME", Description = "MENTAL_INTELLIGENCE_DESCRIPTION" },
               new Focus{FocusKey = "MENTAL_WITZ_NAME", FocusName = "MENTAL_WITZ_NAME", Description = "MENTAL_WITZ_DESCRIPTION" },
            };

            focus.ForEach(f =>
            {
                context.Focus.Add(f);
            });

            context.SaveChanges();

            #region Traduction
            var focusTraductions = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PHYSICAL_STRENGTH_NAME", Text = "Force"},
                new Traduction{LCID = 1036, Key = "PHYSICAL_DEXTERITY_NAME", Text = "Dextérité"},
                new Traduction{LCID = 1036, Key = "PHYSICAL_STAMINA_NAME", Text = "Endurance"},

                new Traduction{LCID = 1036, Key = "PHYSICAL_STRENGTH_DESCRIPTION", Text = "Un personnage focalisé sur la Force est costaud et musclé. Une fois par combat, de tels personnages peuvent utiliser gratuitement une manœuvre de combat basée sur la Force (Désarmer, Agripper, Assommer ou Percer le Cœur)."},
                new Traduction{LCID = 1036, Key = "PHYSICAL_DEXTERITY_DESCRIPTION", Text = "Un personnage focalisé sur la Dextérité est rapide et agile. Une fois par combat, de tels personnages peuvent utiliser gratuitement une manœuvre de combat basée sur la Dextérité (Accélération, Désarmer, Combat à l’Aveugle ou Dégainage rapide)."},
                new Traduction{LCID = 1036, Key = "PHYSICAL_STAMINA_DESCRIPTION", Text = "Un personnage focalisé sur l’Endurance est coriace et robuste. De tels personnages ne subissent pas les pénalités de blessure. De plus, ils ne peuvent être ni assommés ni mis à terre par une manœuvre de combat à moins que l’attaquant ait un attribut Physique supérieur à celui de votre personnage."},

                new Traduction{LCID = 1036, Key = "SOCIAL_CHARISMA_NAME", Text = "Charisme"},
                new Traduction{LCID = 1036, Key = "SOCIAL_MANIPULATION_NAME", Text = "Manipulation"},
                new Traduction{LCID = 1036, Key = "SOCIAL_APPEARANCE_NAME", Text = "Apparence"},

                new Traduction{LCID = 1036, Key = "SOCIAL_CHARISMA_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "SOCIAL_MANIPULATION_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "SOCIAL_APPEARANCE_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},

                new Traduction{LCID = 1036, Key = "MENTAL_PERCEPTION_NAME", Text = "Perception"},
                new Traduction{LCID = 1036, Key = "MENTAL_INTELLIGENCE_NAME", Text = "Intelligence"},
                new Traduction{LCID = 1036, Key = "MENTAL_WITZ_NAME", Text = "Astuce"},

                new Traduction{LCID = 1036, Key = "MENTAL_PERCEPTION_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "MENTAL_INTELLIGENCE_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "MENTAL_WITZ_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."}
            };

            focusTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #endregion

            #region Attributs
            var attributs = new List<Attribut>
            {
                new Attribut {AttributKey = "PHYSICAL_KEY", AttributName = "PHYSICAL_NAME", Description = "PHYSICAL_DESCRIPTION", Focus = new List<Focus> { focus[0], focus[1], focus[2] } },
                new Attribut {AttributKey = "SOCIAL_KEY", AttributName = "SOCIAL_NAME", Description = "SOCIAL_DESCRIPTION", Focus = new List<Focus> { focus[3], focus[4], focus[5] } },
                new Attribut {AttributKey = "MENTAL_KEY", AttributName = "MENTAL_NAME", Description = "MENTAL_DESCRIPTION", Focus = new List<Focus> { focus[6], focus[7], focus[8] } }
            };

            attributs.ForEach(a =>
            {
                context.Attributs.Add(a);
            });

            context.SaveChanges();

            #region Traduction
            var attributsTraductions = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PHYSICAL_NAME", Text = "Physique"},
                new Traduction{LCID = 1036, Key = "SOCIAL_NAME", Text = "Social"},
                new Traduction{LCID = 1036, Key = "MENTAL_NAME", Text = "Mental"},

                new Traduction{LCID = 1036, Key = "PHYSICAL_DESCRIPTION", Text = "Les attributs physiques quantifient de manière générale la force, l’agilité et la vigueur d’un personnage. Un personnage avec de modestes attributs physiques n’est pas très athlétique, tandis qu’un personnage avec des attributs physiques élevés est exceptionnellement fort, dextre ou robuste. Les vampires peuvent dépenser des points de Sang pour augmenter surnaturellement leurs attributs Physiques (et seulement leur Physique) pour une courte période. Pour davantage d’informations sur la manière de dépenser ainsi du Sang, voyez le chapitre Le sang."},
                new Traduction{LCID = 1036, Key = "SOCIAL_DESCRIPTION", Text = "Les vampires sont des créatures manipulatrices, usant des humains (et réciproquement) comme des composantes de leurs tentatives afin de faire avancer leurs objectifs personnels. Les attributs sociaux décrivent l’apparence, le charme et la capacité à interagir avec autrui d’un personnage. Si votre personnage a peu d’attribut en Social, il est maladroit, timide ou encore commun. Un personnage avec un haut niveau dans l’attribut Social est séduisant, fascinant et doux, doué pour convaincre autrui d’aller dans son sens."},
                new Traduction{LCID = 1036, Key = "MENTAL_DESCRIPTION", Text = "Les attributs mentaux indiquent la capacité du personnage à résoudre des problèmes, apprendre, déduire et à être attentif. Un personnage avec un attribut Mental élevé est vigilant, logique ou intuitif. D’autre part, si l’attribut Mental du personnage est faible, il n’est pas aussi doué. Un tel personnage peut avoir fait peu d’études, être naïf ou lent à la détente."}
            };

            attributsTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #endregion


            AnimalismInitializer.Initialize(context, focus);

        }

        #region Labels
        private static class LabelInitializer
        {
            public static void Initializer(DBNContext context)
            {
                var labels = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "GEN_LBL_SITE_NAME", Text = "Defense By Night"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONNEXION", Text = "Connexion"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_REGISTRATION", Text = "Inscription"},
                 new Traduction{LCID = 1036, Key = "GEN_LBL_Home", Text = "Accueil"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_FIRSTNAME", Text = "Prénom"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_LASTNAME", Text = "Nom de famille"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_EMAIL", Text = "Adresse mail"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_PASSWORD", Text = "Mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONFIRM_PASSWORD", Text = "Confirmation du mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_BIRTHDATE", Text = "Date de naissance"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_ALIAS", Text = "Pseudo"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_MOBILE_PHONE", Text = "Téléphone portable"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_ACCOUNT", Text = "Mon Compte"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_DISCONNECT", Text = "Déconnexion"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_CREATE_CHARACTER", Text = "Création de personnage"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_NEXT_GAME", Text = "Prochaine partie"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_WELLCOME", Text = "Bienvenue sur la Cité de Verre !"},
            };

                labels.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
            }
        }
        #endregion

        #region Messages d'erreurs
        private static class ErrorMessageInitializer
        {
            public static void Initializer(DBNContext context)
            {
                var errorMessages = new List<Traduction>
                {
                    new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_MISSING", Text = "Le prénom n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_TO_LONG", Text = "Le prénom ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_LASTNAME_MISSING", Text = "Le nom de famille n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_LASTNAME_TO_LONG", Text = "Le nom de famille ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_ALIAS_MISSING", Text = "Le pseudo n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_ALIAS_TO_LONG", Text = "Le pseudo ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_EMAIL_MISSING", Text = "L'adresse mail n'est pas renseignée."},
                    new Traduction{LCID = 1036, Key = "ERR_EMAIL_UNCORRECT", Text = "L'adresse mail n'est pas correcte."},

                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_MISSING", Text = "Le mot de passe n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_TO_SHORT", Text = "Le mot de passe doit faire au moins 8 caractères."},
                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_NOT_MATCHING", Text = "Le mot de passe ne correcpond pas à celui renseigné."},

                    new Traduction{LCID = 1036, Key = "ERR_BIRTHDATE_MISSING", Text = "La date de naissance n'est pas renseignée."},

                    new Traduction{LCID = 1036, Key = "ERR_SIGNIN_FAIL", Text = "L'adresse mail ou le mot de passe est incorrecte."},
                };

                errorMessages.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });

                context.SaveChanges();
            }
        }
        #endregion

        #region Disciplines

        private static class AnimalismInitializer
        {
            public static void Initialize(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "ANIMALISM_POWER_1_NAME", Description = "ANIMALISM_POWER_1_DESCRIPTION", System = "ANIMALISM_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 2, PowerName = "ANIMALISM_POWER_2_NAME", Description = "ANIMALISM_POWER_2_DESCRIPTION", System = "ANIMALISM_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 3, PowerName = "ANIMALISM_POWER_3_NAME", Description = "ANIMALISM_POWER_3_DESCRIPTION", System = "ANIMALISM_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 4, PowerName = "ANIMALISM_POWER_4_NAME", Description = "ANIMALISM_POWER_4_DESCRIPTION", System = "ANIMALISM_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 5, PowerName = "ANIMALISM_POWER_5_NAME", Description = "ANIMALISM_POWER_5_DESCRIPTION", System = "ANIMALISM_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "ANIMALISM_NAME", Text = "Animalisme"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_DESCRIPTION", Text = "Quand un vampire est Étreint, son âme est accablée par un instinct sombre et primal : La Bête. La Bête le change en prédateur, le conduisant à des actes sauvages pour sa survie. Certains vampires résistent à leur Bête, tandis que d’autres se réjouissent de leur nouvelle nature animale. En s'appuyant sur cet instinct sauvage et cette pulsion prédatrice, un vampire peut communiquer avec et contrôler des animaux, en établissant son emprise sur les bêtes plus primitives que lui. L'Animalisme peut être utilisé sur les oiseaux, les mammifères, les marsupiaux et les poissons. Il ne peut pas être utilisé sur les insectes, ni sur les créatures dont l’esprit est trop élémentaire pour comprendre une communication rudimentaire, tels que les mollusques ou les vers."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_NAME", Text = "Murmures Sauvages"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_NAME", Text = "Appel"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_NAME", Text = "Dompter la Bête"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_NAME", Text = "Soumission de l’esprit"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_NAME", Text = "Conquérir la Bête"},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_DESCRIPTION", Text = "Les animaux vous reconnaissent comme un prédateur et réagissent avec suspicion et peur. Vous pouvez communiquer avec les animaux en poussant des grognements et en utilisant le langage corporel. Bien qu’un animal ne soit pas obligé de vous obéir, il aura tendance à répondre favorablement aux personnes qui utilisent ce pouvoir."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_DESCRIPTION", Text = "En poussant un hurlement, une série de gazouillis, ou tout autre bruit d’animal identifiable, vous invoquez des animaux jusqu'à vous. Selon la forme de votre appel, vous pouvez choisir la taille et le type d’animal commun dans la zone. Bien que ces animaux ne soient pas vos esclaves, ils sont relativement amicaux envers vous et tenteront de vous assister de leur mieux pour ce que vous leur demandez."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_DESCRIPTION", Text = "La Bête est une créature féroce, désireuse de dominer les autres, sujette à de violentes pulsions et agissant de manière primitive. Toutefois, la Bête peut être domptée, ou bien intimidée, par ceux qui savent comment maîtriser ses pulsions. Certains vampires utilisent ce pouvoir comme un alpha le ferait sur une créature inférieure, forçant la Bête au calme. D’autres apaisent les émotions de leur cible, plongeant la Bête de l’autre dans une paisible tranquillité. Quelle que soit la méthode utilisée, le résultat est le même et le vampire ciblé doit temporairement survivre sans les instincts acérés de sa Bête."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_DESCRIPTION", Text = "La Bête est une chose palpable, capable d’influencer les esprits des autres animaux. Vous pouvez non seulement intimider les créatures inférieures, mais pouvez aussi envoyer votre conscience dans le corps d’un animal, le soumettant complètement. Le corps de l’animal devient complètement soumis à votre volonté et vous pouvez l’utiliser comme si c’était votre forme naturelle. Pendant que votre esprit est dans le corps de l’animal, votre propre corps tombe dans un état comateux. Bien que vous puissiez utiliser l’entièreté de votre intelligence, votre ruse et vos souvenirs, vous êtes limités par les capacités physiques de l’animal."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_DESCRIPTION", Text = "Grâce à votre fine compréhension de votre propre nature primitive et vos instincts de prédateur, vous êtes en communion avec la Bête. Bien que personne ne dirait que le monstre est dompté, la capacité de lâcher ou restreindre volontairement votre Bête est effroyable et peut donner à un vampire un avantage de taille."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_SYSTEM", Text = "Vous pouvez communiquer avec les animaux en poussant des grognements et en utilisant le langage corporel. Pour poser des questions à un animal, consultez un Conteur. Le Conteur doit répondre du point de vue de l’animal qui aura été attiré par votre appel. Un personnage qui souhaite établir une communication doit être visible et audible de la créature. Vous pouvez parler à un animal en particulier, ou bien utiliser ce pouvoir pour questionner toute la faune locale à portée d’écoute. S’il n’y a pas d’animaux à proximité, vos requêtes peuvent rester sans réponse. De plus, si le Conteur pense que vous demandez quelque chose qu’un animal ne remarquerait pas (ou pourrait ne pas comprendre), votre personnage recevra une réponse confuse ou incomplète. Demander «Est-ce que des créatures à deux pattes (humain ou vampire) sont passées par ici cette nuit ?» recevrait une réponse raisonnable. Les écureuils, les chiens errants ou les oiseaux locaux pourraient vous dire qu’un groupe de six hommes sont passés par ici très récemment. Toutefois, ces animaux seraient incapables de différencier un humain d’un autre, ni d’identifier le type d’équipement qu’ils portaient."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_SYSTEM", Text = "En dépensant un point de Sang et une action standard, vous invoquez jusqu’à cinq petits animaux, trois animaux moyens ou un grand animal. Vous déterminez le type (et la taille) de ces animaux. Dans des conditions habituelles, ces animaux arriveront dans les dix minutes. Toutefois, si vous choisissez d’invoquer des animaux particulièrement courants dans la zone, cela peut prendre moins de temps. Invoquer un animal particulièrement rare peut prendre bien plus longtemps (à la discrétion du Conteur). Tenter d’invoquer un animal n’existant pas dans la région (comme un ours polaire dans le désert égyptien) sera un échec automatique. Les animaux ainsi convoqués ne se voient attribuer aucun pouvoir spécial pour répondre à votre appel et doivent donc pouvoir voyager jusqu’à vous. Un coyote ne pourra pas ouvrir une porte fermée, mais pourra se rendre sur un parking, là où un corbeau atteindra très facilement le toit d’un immeuble. Ce pouvoir ne confère aucune capacité spéciale, ni intelligence ou courage à l’animal invoqué. Les animaux invoqués vous considèrent comme un alpha de leur espèce. Si vous utilisez Murmures Sauvages pour communiquer, les animaux Appelés tenteront d’obéir à vos requêtes. Ils travailleront pour vous jusqu’à l’aube ou jusqu’à encaisser autant de dégâts que leur niveau de PNJ. Plusieurs utilisations de ce pouvoir ne permettent pas de convoquer des groupes supplémentaires de créatures tout en contrôlant les premiers. Toutefois, si votre premier groupe d’animaux Appelés est dispersé (en prenant des dégâts, en fuyant ou en étant renvoyé), vous pouvez réutiliser ce pouvoir pour convoquer un second groupe. En outre, Appel ne peut être utilisé pour prendre le contrôle d’un groupe d’animaux sous le contrôle d’un autre utilisateur de la Discipline Animalisme (bien que vous puissiez utiliser Murmures Sauvages pour parler avec de tels animaux). Les animaux convoqués avec Appel sont créés avec les règles de PNJ type, avec les instructions supplémentaires suivantes : • Petits animau : Utilisez la règle pour un PNJ type à 1 point. Les petits animaux peuvent posséder une capacité de déplacement spéciale. Cette capacité lui permet d’escalader, nager, voler ou de s’enfouir à une vitesse normale. Les petits animaux sont les petits chiens, les chats, les écureuils et la plupart des oiseaux, les poissons et les animaux fouisseurs. • Animaux moyens : Utilisez la règle pour un PNJ type à 3 points. Cette catégorie comprend les gros chiens, les coyotes, les lynx et les ours bruns. • Grands animaux : Utilisez la règle pour un PNJ type à 5 points. L’invocateur peut Appeler un cheval, un cerf ou un grizzli. Avant d’aller dormir ou d’entrer en torpeur, il est possible de dépenser un point de Sang pour activer ce pouvoir.Utilisé de cette façon, les animaux invoqués par ce pouvoir garderont votre lieu de repos jusqu’à leur mort ou votre réveil."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_SYSTEM", Text = "La cible de ce pouvoir doit être un vampire ou une autre créature surnaturelle capable d’entrer en frénésie. Quand vous êtes le centre de l’attention d’un autre personnage (comme indiqué dans les règles génériques d’usage de Disciplines), vous pouvez dépenser un point de sang, utiliser une action standard et faire un challenge en opposition en utilisant le Score de Test d’Animalisme. Si la cible était en frénésie, quand ce pouvoir a été utilisé avec succès, elle sort immédiatement de frénésie. Si la cible du pouvoir n’était pas en frénésie, elle devient incapable d’entrer en frénésie durant la prochaine heure. De plus, sa Volonté est affaiblie et elle doit dépenser deux points de Volonté (au lieu d’un seul) pour bénéficier d’un re-test de challenge durant le reste de ce tour et le prochain tour complet. La Bête d’un vampire est une partie critique de sa nature prédatrice. Quand elle est endormie, le vampire est plus lent à réagir. Si un individu a un Trait de la Bête (ou en gagne un) sous l’effet de ce pouvoir, elle lutte pour utiliser sa Volonté pour une plus grande période. Pour les cinq prochaines minutes, elle doit continuer à dépenser deux points de Volonté au lieu d’un pour refaire ses challenges. Les personnages ayant des avantages ou des pouvoirs permettant un re-test sans dépenser de Volonté peuvent les utiliser normalement quand ils sont sous l’effet de ce pouvoir et ne dépensent pas un point supplémentaire de Volonté pour ces re-tests. Dompter la Bête ne peut être utilisé sur soi."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_SYSTEM", Text = "Pour utiliser Soumission de l’Esprit, vous devez dépenser un point de sang et une action standard pour regarder un animal dans les yeux ; ce pouvoir ne peut pas fonctionner sur un sujet aveugle ou qui ne peut pas voir vos yeux. Faites un challenge opposé contre l’animal quand vous tentez de contrôler. Si c’est une réussite, votre conscience est transférée dans le corps de votre cible et son esprit est mis dans un état proche de la fugue. Comme votre esprit est entièrement concentré sur le contrôle de ce nouveau corps, le vampire n’a aucune perception de ce que son vrai corps ressent. Le corps du personnage tombe dans un état de coma et ne peut se défendre ni agir de lui-même. Le corps peut toujours utiliser Force d’Âme ou d’autres pouvoirs qui sont toujours actifs quand votre conscience est absente. Pendant l’utilisation de ce pouvoir, vous connaissez toujours la direction et la distance à laquelle se trouve votre vrai corps, bien que vous ne puissiez pas percevoir ses alentours. Les animaux normaux et goulifiés peuvent être la cible de Soumettre l’Esprit. Les créatures surnaturelles (comme les vampires transformés en animaux ou les loup-garous) ne peuvent pas être la cible de ce pouvoir. Assurez-vous de demander à votre Conteur si votre cible est appropriée. Les animaux normaux ne possèdent pas de disciplines et ne peuvent dépenser de sang. Toutefois, si votre personnage contrôle un animal goulifié, la goule possède 5 points de sang (comme une goule standard). Le vampire ayant le contrôle peut dépenser un point de sang par tour, quelle que soit la génération du personnage. Vous ne pouvez en aucune façon dépenser de sang pour agir sur le corps d’origine. Un personnage ne peut utiliser aucune de ses disciplines pendant qu’il utilise Soumission de l’Esprit. Vous pouvez dépenser le sang de la goule pour utiliser ses propres pouvoirs physiques : Célérité, Force d’Âme et Puissance. Pendant l’utilisation de ce pouvoir, un personnage utilise ses propres attributs et focus mentaux et sociaux, ses compétences et historiques pour les challenges.Toutefois, vous utilisez les attributs physiques de l’animal pour les challenges physiques.Cet attribut est égal au double du niveau de PNJ de cet animal. Si l’animal que vous contrôlez a le pouvoir de voler ou est adapté à la vie aquatique(comme un poisson), vous pouvez voler ou nager à vitesse normale. Soumettre l’Esprit dure jusqu’à la prochaine aube ou jusqu’à ce que vous dépensiez une action simple pour quitter l’animal et vous réveiller. Soumettre l’Esprit s’arrête immédiatement si le personnage s’éloigne à plus de 16km(10 miles) de son corps d’origine ou si le corps d’origine comme celui de l’animal encaissent des dommages. Les animaux ne prennent pas de dégâts dus au soleil, même une fois contrôlé par un vampire. Toutefois, un vampire avec des Traits de la Bête risque d’entrer en frénésie. "},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_SYSTEM", Text = "Dépensez un point de sang et une action simple pour sortir immédiatement de Frénésie. Alternativement, vous pouvez dépenser un point de sang et une action simple pour rentrer immédiatement en Frénésie."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_FOCUS_DESCRIPTION", Text = "Vous n’avez pas besoin de grogner ou de faire un geste pour vous faire comprendre. Votre Bête peut communiquer directement avec les esprits des animaux proches. Toutefois, ces animaux doivent pouvoir vous voir pendant que vous utilisez ce pouvoir. En outre, vous n’avez plus besoin de compter sur la capacité de langage de l’animal. Quand vous utilisez ce pouvoir, vous obtenez une image mentale de toute situation que l’animal tente de décrire. Par exemple, vous verriez un souvenir du Prince marchant vers sa voiture, plutôt que d’entendre la description et l’interprétation du rat témoin de la scène."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_FOCUS_DESCRIPTION", Text = "Quand vous invoquez des créatures en utilisant ce pouvoir, appliquez l’un des effets additionnels suivants. Si vous invoquez plus d’une créature, l’effet choisi s’applique à chaque créature (toutes pourront voler, auront une intelligence supérieure, etc.) • Déplacement spécial Vous pouvez invoquer un groupe de créatures de taille moyenne qui peut voler ou nager à une vitesse normale (comme un vautour, un aigle ou un saumon) ou une unique créature de grande taille qui nage à vitesse normale (comme un requin ou un dauphin) • Intelligence accrue Vous pouvez appeler un animal particulièrement intelligent pour son espèce. Cet animal est doué de compréhension et suivra des instructions bien plus complexes. Vous pouvez lui donner des ordres de type Si/Alors comme «Reste à la porte pendant que je m’infiltre à l’intérieur. Aboie une fois si un homme approche et deux fois si tu vois une femme». Cet animal est un individu lambda de son espèce pour les autres aspects. • Nuée Vous invoquez un grand nombre de petits animaux. Ce peut être des rats, des corbeaux, des piranhas ou d’autres créatures similaires ; mais souvenez-vous qu’Animalisme ne peut affecter les insectes."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_FOCUS_DESCRIPTION", Text = "Plutôt que d’avoir à dépenser un point de Volonté supplémentaire pour faire un re-test, la victime ne peut plus faire de re-test du tout durant l’effet de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser les deux premiers niveaux de vos disciplines mentales et sociales de clan lorsque vous utilisez Soumission de l’Esprit. Si vous contrôlez un animal goulifié, vous pouvez dépenser jusqu’à 5 points de sang pour utiliser ces disciplines de clan, au rythme d’un point par tour, quelle que soit la génération. Les vampires avec ce focus ayant Animalisme comme discipline de clan peuvent utiliser Soumission de l’Esprit pendant l’utilisation de Soumission de l’Esprit, transférant leur esprit d’un animal à un autre. Chaque nouvelle utilisation de Soumission de l’Esprit coûte un point de sang, une action standard, un contact visuel et un challenge opposé."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Conquérir la Bête pour entrer en Frénésie, même si vous en seriez en principe incapable, par exemple lorsque vous êtes affecté par des pouvoirs comme Dompter la Bête. De plus, en Frénésie de rage, votre personnage reçoit un bonus de +3 à tous ses groupements de Test d’Attaque Physique (au lieu du +1 standard). Votre personnage souffre toujours du malus standard de -2 à ses groupements de Test de Défense Physique quand il est en Frénésie."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_EXCEPTIONALSUCCESS", Text = "L’effet d’affaiblissement sur la Volonté dure jusqu’à la fin de ce tour et pour les deux tours complets suivants (plutôt qu’un)."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_EXCEPTIONALSUCCESS", Text = null}
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "ANIMALISM_KEY",
                    DisciplineName = "ANIMALISM_NAME",
                    Description = "ANIMALISM_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class AuspexInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "AUSPEX_POWER_1_NAME", Description = "AUSPEX_POWER_1_DESCRIPTION", System = "AUSPEX_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "AUSPEX_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 2, PowerName = "AUSPEX_POWER_2_NAME", Description = "AUSPEX_POWER_2_DESCRIPTION", System = "AUSPEX_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "AUSPEX_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 3, PowerName = "AUSPEX_POWER_3_NAME", Description = "AUSPEX_POWER_3_DESCRIPTION", System = "AUSPEX_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "AUSPEX_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 4, PowerName = "AUSPEX_POWER_4_NAME", Description = "AUSPEX_POWER_4_DESCRIPTION", System = "AUSPEX_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "AUSPEX_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 5, PowerName = "AUSPEX_POWER_5_NAME", Description = "AUSPEX_POWER_5_DESCRIPTION", System = "AUSPEX_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "AUSPEX_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "AUSPEX_NAME", Text = "Auspex"},
                new Traduction{LCID = 1036, Key = "AUSPEX_DESCRIPTION", Text = "Les sens d’un prédateur doivent être extrêmement développés pour traquer sa proie dans la nuit. Les cinq sens de l’odorat, du toucher, du goût, de la vue et de l’ouïe peuvent tous être affûtés avec l’utilisation de l’Auspex. Ils peuvent alors dépasser les sens physiques, augmentant les capacités de concentration, de perception et même de conscience d’un vampire au-delà des possibilités des Mortels. De tels sens peuvent saisir les subtiles textures du mouvement ainsi que les états émotionnels, transcendant l’acuité mentale ordinaire. L’Auspex peut également percer les distractions mentales et les illusions, comme celles créées par les disciplines d’Occultation et de Chimérie. Auspex et Chimérie/Occultation : Si vous tentez d’utiliser Sens Accrus pour percer les occultations surnaturelles, votre cible peut choisir d’utiliser Mental +Discrétion pour Score de Test de Défense, en lieu et place de Mental + Volonté.Si vous tentez de percer une illusion, votre cible peut choisir d’utiliser Social +Subterfuge au lieu du Score de Test générique Social +Volonté. Si l’utilisateur d’Auspex réussit, il perce les pouvoirs d’Occultation ou de Chimérie. Score de Test: L’utilisateur d’Auspex utilise Mental + Investigation contre Mental +Volonté de la cible."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_NAME", Text = "Sens Accrus"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_DESCRIPTION", Text = "Vous pouvez étendre vos sens physiques au-delà des limites humaines. Votre vue et votre ouïe peuvent être étendues jusqu’à deux fois les limites humaines, alors que le toucher, l’odorat et le goût deviennent suffisamment sensibles pour discerner les plus infimes détails avec aisance. Un personnage peut améliorer n’importe lequel de ses sens, voire tous, selon ses désirs."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_SYSTEM", Text = "Vous pouvez communiquer avec les animaux en poussant des grognements et en utilisant le langage corporel. Pour poser des questions à un animal, consultez un Conteur. Le Conteur doit répondre du point de vue de l’animal qui aura été attiré par votre appel. Un personnage qui souhaite établir une communication doit être visible et audible de la créature. Vous pouvez parler à un animal en particulier, ou bien utiliser ce pouvoir pour questionner toute la faune locale à portée d’écoute. S’il n’y a pas d’animaux à proximité, vos requêtes peuvent rester sans réponse. De plus, si le Conteur pense que vous demandez quelque chose qu’un animal ne remarquerait pas (ou pourrait ne pas comprendre), votre personnage recevra une réponse confuse ou incomplète. Demander «Est-ce que des créatures à deux pattes (humain ou vampire) sont passées par ici cette nuit ?» recevrait une réponse raisonnable. Les écureuils, les chiens errants ou les oiseaux locaux pourraient vous dire qu’un groupe de six hommes sont passés par ici très récemment. Toutefois, ces animaux seraient incapables de différencier un humain d’un autre, ni d’identifier le type d’équipement qu’ils portaient."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_FOCUS_DESCRIPTION", Text = "Vous n’avez pas besoin de grogner ou de faire un geste pour vous faire comprendre. Votre Bête peut communiquer directement avec les esprits des animaux proches. Toutefois, ces animaux doivent pouvoir vous voir pendant que vous utilisez ce pouvoir. En outre, vous n’avez plus besoin de compter sur la capacité de langage de l’animal. Quand vous utilisez ce pouvoir, vous obtenez une image mentale de toute situation que l’animal tente de décrire. Par exemple, vous verriez un souvenir du Prince marchant vers sa voiture, plutôt que d’entendre la description et l’interprétation du rat témoin de la scène."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_NAME", Text = "Appel"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_DESCRIPTION", Text = "En poussant un hurlement, une série de gazouillis, ou tout autre bruit d’animal identifiable, vous invoquez des animaux jusqu'à vous. Selon la forme de votre appel, vous pouvez choisir la taille et le type d’animal commun dans la zone. Bien que ces animaux ne soient pas vos esclaves, ils sont relativement amicaux envers vous et tenteront de vous assister de leur mieux pour ce que vous leur demandez."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_SYSTEM", Text = "En dépensant un point de Sang et une action standard, vous invoquez jusqu’à cinq petits animaux, trois animaux moyens ou un grand animal. Vous déterminez le type (et la taille) de ces animaux. Dans des conditions habituelles, ces animaux arriveront dans les dix minutes. Toutefois, si vous choisissez d’invoquer des animaux particulièrement courants dans la zone, cela peut prendre moins de temps. Invoquer un animal particulièrement rare peut prendre bien plus longtemps (à la discrétion du Conteur). Tenter d’invoquer un animal n’existant pas dans la région (comme un ours polaire dans le désert égyptien) sera un échec automatique. Les animaux ainsi convoqués ne se voient attribuer aucun pouvoir spécial pour répondre à votre appel et doivent donc pouvoir voyager jusqu’à vous. Un coyote ne pourra pas ouvrir une porte fermée, mais pourra se rendre sur un parking, là où un corbeau atteindra très facilement le toit d’un immeuble. Ce pouvoir ne confère aucune capacité spéciale, ni intelligence ou courage à l’animal invoqué. Les animaux invoqués vous considèrent comme un alpha de leur espèce. Si vous utilisez Murmures Sauvages pour communiquer, les animaux Appelés tenteront d’obéir à vos requêtes. Ils travailleront pour vous jusqu’à l’aube ou jusqu’à encaisser autant de dégâts que leur niveau de PNJ. Plusieurs utilisations de ce pouvoir ne permettent pas de convoquer des groupes supplémentaires de créatures tout en contrôlant les premiers. Toutefois, si votre premier groupe d’animaux Appelés est dispersé (en prenant des dégâts, en fuyant ou en étant renvoyé), vous pouvez réutiliser ce pouvoir pour convoquer un second groupe. En outre, Appel ne peut être utilisé pour prendre le contrôle d’un groupe d’animaux sous le contrôle d’un autre utilisateur de la Discipline AUSPEXe (bien que vous puissiez utiliser Murmures Sauvages pour parler avec de tels animaux). Les animaux convoqués avec Appel sont créés avec les règles de PNJ type, avec les instructions supplémentaires suivantes : • Petits animau : Utilisez la règle pour un PNJ type à 1 point. Les petits animaux peuvent posséder une capacité de déplacement spéciale. Cette capacité lui permet d’escalader, nager, voler ou de s’enfouir à une vitesse normale. Les petits animaux sont les petits chiens, les chats, les écureuils et la plupart des oiseaux, les poissons et les animaux fouisseurs. • Animaux moyens : Utilisez la règle pour un PNJ type à 3 points. Cette catégorie comprend les gros chiens, les coyotes, les lynx et les ours bruns. • Grands animaux : Utilisez la règle pour un PNJ type à 5 points. L’invocateur peut Appeler un cheval, un cerf ou un grizzli. Avant d’aller dormir ou d’entrer en torpeur, il est possible de dépenser un point de Sang pour activer ce pouvoir.Utilisé de cette façon, les animaux invoqués par ce pouvoir garderont votre lieu de repos jusqu’à leur mort ou votre réveil."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_FOCUS_DESCRIPTION", Text = "Quand vous invoquez des créatures en utilisant ce pouvoir, appliquez l’un des effets additionnels suivants. Si vous invoquez plus d’une créature, l’effet choisi s’applique à chaque créature (toutes pourront voler, auront une intelligence supérieure, etc.) • Déplacement spécial Vous pouvez invoquer un groupe de créatures de taille moyenne qui peut voler ou nager à une vitesse normale (comme un vautour, un aigle ou un saumon) ou une unique créature de grande taille qui nage à vitesse normale (comme un requin ou un dauphin) • Intelligence accrue Vous pouvez appeler un animal particulièrement intelligent pour son espèce. Cet animal est doué de compréhension et suivra des instructions bien plus complexes. Vous pouvez lui donner des ordres de type Si/Alors comme «Reste à la porte pendant que je m’infiltre à l’intérieur. Aboie une fois si un homme approche et deux fois si tu vois une femme». Cet animal est un individu lambda de son espèce pour les autres aspects. • Nuée Vous invoquez un grand nombre de petits animaux. Ce peut être des rats, des corbeaux, des piranhas ou d’autres créatures similaires ; mais souvenez-vous qu’AUSPEXe ne peut affecter les insectes."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_NAME", Text = "Dompter la Bête"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_DESCRIPTION", Text = "La Bête est une créature féroce, désireuse de dominer les autres, sujette à de violentes pulsions et agissant de manière primitive. Toutefois, la Bête peut être domptée, ou bien intimidée, par ceux qui savent comment maîtriser ses pulsions. Certains vampires utilisent ce pouvoir comme un alpha le ferait sur une créature inférieure, forçant la Bête au calme. D’autres apaisent les émotions de leur cible, plongeant la Bête de l’autre dans une paisible tranquillité. Quelle que soit la méthode utilisée, le résultat est le même et le vampire ciblé doit temporairement survivre sans les instincts acérés de sa Bête."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_SYSTEM", Text = "La cible de ce pouvoir doit être un vampire ou une autre créature surnaturelle capable d’entrer en frénésie. Quand vous êtes le centre de l’attention d’un autre personnage (comme indiqué dans les règles génériques d’usage de Disciplines), vous pouvez dépenser un point de sang, utiliser une action standard et faire un challenge en opposition en utilisant le Score de Test d’AUSPEXe. Si la cible était en frénésie, quand ce pouvoir a été utilisé avec succès, elle sort immédiatement de frénésie. Si la cible du pouvoir n’était pas en frénésie, elle devient incapable d’entrer en frénésie durant la prochaine heure. De plus, sa Volonté est affaiblie et elle doit dépenser deux points de Volonté (au lieu d’un seul) pour bénéficier d’un re-test de challenge durant le reste de ce tour et le prochain tour complet. La Bête d’un vampire est une partie critique de sa nature prédatrice. Quand elle est endormie, le vampire est plus lent à réagir. Si un individu a un Trait de la Bête (ou en gagne un) sous l’effet de ce pouvoir, elle lutte pour utiliser sa Volonté pour une plus grande période. Pour les cinq prochaines minutes, elle doit continuer à dépenser deux points de Volonté au lieu d’un pour refaire ses challenges. Les personnages ayant des avantages ou des pouvoirs permettant un re-test sans dépenser de Volonté peuvent les utiliser normalement quand ils sont sous l’effet de ce pouvoir et ne dépensent pas un point supplémentaire de Volonté pour ces re-tests. Dompter la Bête ne peut être utilisé sur soi."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_EXCEPTIONALSUCCESS", Text = "L’effet d’affaiblissement sur la Volonté dure jusqu’à la fin de ce tour et pour les deux tours complets suivants (plutôt qu’un)."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_FOCUS_DESCRIPTION", Text = "Plutôt que d’avoir à dépenser un point de Volonté supplémentaire pour faire un re-test, la victime ne peut plus faire de re-test du tout durant l’effet de ce pouvoir."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_NAME", Text = "Soumission de l’esprit"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_DESCRIPTION", Text = "La Bête est une chose palpable, capable d’influencer les esprits des autres animaux. Vous pouvez non seulement intimider les créatures inférieures, mais pouvez aussi envoyer votre conscience dans le corps d’un animal, le soumettant complètement. Le corps de l’animal devient complètement soumis à votre volonté et vous pouvez l’utiliser comme si c’était votre forme naturelle. Pendant que votre esprit est dans le corps de l’animal, votre propre corps tombe dans un état comateux. Bien que vous puissiez utiliser l’entièreté de votre intelligence, votre ruse et vos souvenirs, vous êtes limités par les capacités physiques de l’animal."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_SYSTEM", Text = "Pour utiliser Soumission de l’Esprit, vous devez dépenser un point de sang et une action standard pour regarder un animal dans les yeux ; ce pouvoir ne peut pas fonctionner sur un sujet aveugle ou qui ne peut pas voir vos yeux. Faites un challenge opposé contre l’animal quand vous tentez de contrôler. Si c’est une réussite, votre conscience est transférée dans le corps de votre cible et son esprit est mis dans un état proche de la fugue. Comme votre esprit est entièrement concentré sur le contrôle de ce nouveau corps, le vampire n’a aucune perception de ce que son vrai corps ressent. Le corps du personnage tombe dans un état de coma et ne peut se défendre ni agir de lui-même. Le corps peut toujours utiliser Force d’Âme ou d’autres pouvoirs qui sont toujours actifs quand votre conscience est absente. Pendant l’utilisation de ce pouvoir, vous connaissez toujours la direction et la distance à laquelle se trouve votre vrai corps, bien que vous ne puissiez pas percevoir ses alentours. Les animaux normaux et goulifiés peuvent être la cible de Soumettre l’Esprit. Les créatures surnaturelles (comme les vampires transformés en animaux ou les loup-garous) ne peuvent pas être la cible de ce pouvoir. Assurez-vous de demander à votre Conteur si votre cible est appropriée. Les animaux normaux ne possèdent pas de disciplines et ne peuvent dépenser de sang. Toutefois, si votre personnage contrôle un animal goulifié, la goule possède 5 points de sang (comme une goule standard). Le vampire ayant le contrôle peut dépenser un point de sang par tour, quelle que soit la génération du personnage. Vous ne pouvez en aucune façon dépenser de sang pour agir sur le corps d’origine. Un personnage ne peut utiliser aucune de ses disciplines pendant qu’il utilise Soumission de l’Esprit. Vous pouvez dépenser le sang de la goule pour utiliser ses propres pouvoirs physiques : Célérité, Force d’Âme et Puissance. Pendant l’utilisation de ce pouvoir, un personnage utilise ses propres attributs et focus mentaux et sociaux, ses compétences et historiques pour les challenges.Toutefois, vous utilisez les attributs physiques de l’animal pour les challenges physiques.Cet attribut est égal au double du niveau de PNJ de cet animal. Si l’animal que vous contrôlez a le pouvoir de voler ou est adapté à la vie aquatique(comme un poisson), vous pouvez voler ou nager à vitesse normale. Soumettre l’Esprit dure jusqu’à la prochaine aube ou jusqu’à ce que vous dépensiez une action simple pour quitter l’animal et vous réveiller. Soumettre l’Esprit s’arrête immédiatement si le personnage s’éloigne à plus de 16km(10 miles) de son corps d’origine ou si le corps d’origine comme celui de l’animal encaissent des dommages. Les animaux ne prennent pas de dégâts dus au soleil, même une fois contrôlé par un vampire. Toutefois, un vampire avec des Traits de la Bête risque d’entrer en frénésie. "},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser les deux premiers niveaux de vos disciplines mentales et sociales de clan lorsque vous utilisez Soumission de l’Esprit. Si vous contrôlez un animal goulifié, vous pouvez dépenser jusqu’à 5 points de sang pour utiliser ces disciplines de clan, au rythme d’un point par tour, quelle que soit la génération. Les vampires avec ce focus ayant AUSPEXe comme discipline de clan peuvent utiliser Soumission de l’Esprit pendant l’utilisation de Soumission de l’Esprit, transférant leur esprit d’un animal à un autre. Chaque nouvelle utilisation de Soumission de l’Esprit coûte un point de sang, une action standard, un contact visuel et un challenge opposé."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_NAME", Text = "Conquérir la Bête"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_DESCRIPTION", Text = "Grâce à votre fine compréhension de votre propre nature primitive et vos instincts de prédateur, vous êtes en communion avec la Bête. Bien que personne ne dirait que le monstre est dompté, la capacité de lâcher ou restreindre volontairement votre Bête est effroyable et peut donner à un vampire un avantage de taille."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_SYSTEM", Text = "Dépensez un point de sang et une action simple pour sortir immédiatement de Frénésie. Alternativement, vous pouvez dépenser un point de sang et une action simple pour rentrer immédiatement en Frénésie."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Conquérir la Bête pour entrer en Frénésie, même si vous en seriez en principe incapable, par exemple lorsque vous êtes affecté par des pouvoirs comme Dompter la Bête. De plus, en Frénésie de rage, votre personnage reçoit un bonus de +3 à tous ses groupements de Test d’Attaque Physique (au lieu du +1 standard). Votre personnage souffre toujours du malus standard de -2 à ses groupements de Test de Défense Physique quand il est en Frénésie."}

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "AUSPEX_KEY",
                    DisciplineName = "AUSPEX_NAME",
                    Description = "AUSPEX_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class CelerityInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "CELERITY_POWER_1_NAME", Description = "CELERITY_POWER_1_DESCRIPTION", System = "CELERITY_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "CELERITY_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 2, PowerName = "CELERITY_POWER_2_NAME", Description = "CELERITY_POWER_2_DESCRIPTION", System = "CELERITY_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "CELERITY_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 3, PowerName = "CELERITY_POWER_3_NAME", Description = "CELERITY_POWER_3_DESCRIPTION", System = "CELERITY_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "CELERITY_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 4, PowerName = "CELERITY_POWER_4_NAME", Description = "CELERITY_POWER_4_DESCRIPTION", System = "CELERITY_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "CELERITY_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 5, PowerName = "CELERITY_POWER_5_NAME", Description = "CELERITY_POWER_5_DESCRIPTION", System = "CELERITY_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "CELERITY_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "CELERITY_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "CELERITY_KEY",
                    DisciplineName = "CELERITY_NAME",
                    Description = "CELERITY_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ChimestryInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "CHIMERSTRY_POWER_1_NAME", Description = "CHIMERSTRY_POWER_1_DESCRIPTION", System = "CHIMERSTRY_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "CHIMERSTRY_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 2, PowerName = "CHIMERSTRY_POWER_2_NAME", Description = "CHIMERSTRY_POWER_2_DESCRIPTION", System = "CHIMERSTRY_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "CHIMERSTRY_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 3, PowerName = "CHIMERSTRY_POWER_3_NAME", Description = "CHIMERSTRY_POWER_3_DESCRIPTION", System = "CHIMERSTRY_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 4, PowerName = "CHIMERSTRY_POWER_4_NAME", Description = "CHIMERSTRY_POWER_4_DESCRIPTION", System = "CHIMERSTRY_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 5, PowerName = "CHIMERSTRY_POWER_5_NAME", Description = "CHIMERSTRY_POWER_5_DESCRIPTION", System = "CHIMERSTRY_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "CHIMERSTRY_KEY",
                    DisciplineName = "CHIMERSTRY_NAME",
                    Description = "CHIMERSTRY_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DaimoinonInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DAIMOINON_POWER_1_NAME", Description = "DAIMOINON_POWER_1_DESCRIPTION", System = "DAIMOINON_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "DAIMOINON_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 2, PowerName = "DAIMOINON_POWER_2_NAME", Description = "DAIMOINON_POWER_2_DESCRIPTION", System = "DAIMOINON_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "DAIMOINON_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 3, PowerName = "DAIMOINON_POWER_3_NAME", Description = "DAIMOINON_POWER_3_DESCRIPTION", System = "DAIMOINON_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "DAIMOINON_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 4, PowerName = "DAIMOINON_POWER_4_NAME", Description = "DAIMOINON_POWER_4_DESCRIPTION", System = "DAIMOINON_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "DAIMOINON_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 5, PowerName = "DAIMOINON_POWER_5_NAME", Description = "DAIMOINON_POWER_5_DESCRIPTION", System = "DAIMOINON_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "DAIMOINON_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DAIMOINON_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DAIMOINON_KEY",
                    DisciplineName = "DAIMOINON_NAME",
                    Description = "DAIMOINON_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DementationInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DEMENTATION_POWER_1_NAME", Description = "DEMENTATION_POWER_1_DESCRIPTION", System = "DEMENTATION_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 2, PowerName = "DEMENTATION_POWER_2_NAME", Description = "DEMENTATION_POWER_2_DESCRIPTION", System = "DEMENTATION_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 3, PowerName = "DEMENTATION_POWER_3_NAME", Description = "DEMENTATION_POWER_3_DESCRIPTION", System = "DEMENTATION_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 4, PowerName = "DEMENTATION_POWER_4_NAME", Description = "DEMENTATION_POWER_4_DESCRIPTION", System = "DEMENTATION_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 5, PowerName = "DEMENTATION_POWER_5_NAME", Description = "DEMENTATION_POWER_5_DESCRIPTION", System = "DEMENTATION_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DEMENTATION_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DEMENTATION_KEY",
                    DisciplineName = "DEMENTATION_NAME",
                    Description = "DEMENTATION_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DominateInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DOMINATE_POWER_1_NAME", Description = "DOMINATE_POWER_1_DESCRIPTION", System = "DOMINATE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "DOMINATE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 2, PowerName = "DOMINATE_POWER_2_NAME", Description = "DOMINATE_POWER_2_DESCRIPTION", System = "DOMINATE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "DOMINATE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 3, PowerName = "DOMINATE_POWER_3_NAME", Description = "DOMINATE_POWER_3_DESCRIPTION", System = "DOMINATE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "DOMINATE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 4, PowerName = "DOMINATE_POWER_4_NAME", Description = "DOMINATE_POWER_4_DESCRIPTION", System = "DOMINATE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "DOMINATE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 5, PowerName = "DOMINATE_POWER_5_NAME", Description = "DOMINATE_POWER_5_DESCRIPTION", System = "DOMINATE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "DOMINATE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DOMINATE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DOMINATE_KEY",
                    DisciplineName = "DOMINATE_NAME",
                    Description = "DOMINATE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class FortitudeInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "FORTITUTE_POWER_1_NAME", Description = "FORTITUTE_POWER_1_DESCRIPTION", System = "FORTITUTE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "FORTITUTE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 2, PowerName = "FORTITUTE_POWER_2_NAME", Description = "FORTITUTE_POWER_2_DESCRIPTION", System = "FORTITUTE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "FORTITUTE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 3, PowerName = "FORTITUTE_POWER_3_NAME", Description = "FORTITUTE_POWER_3_DESCRIPTION", System = "FORTITUTE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "FORTITUTE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 4, PowerName = "FORTITUTE_POWER_4_NAME", Description = "FORTITUTE_POWER_4_DESCRIPTION", System = "FORTITUTE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "FORTITUTE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 5, PowerName = "FORTITUTE_POWER_5_NAME", Description = "FORTITUTE_POWER_5_DESCRIPTION", System = "FORTITUTE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "FORTITUTE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "FORTITUTE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "FORTITUTE_KEY",
                    DisciplineName = "FORTITUTE_NAME",
                    Description = "FORTITUTE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class MelpomineeyInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "MELPOMINEE_POWER_1_NAME", Description = "MELPOMINEE_POWER_1_DESCRIPTION", System = "MELPOMINEE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "MELPOMINEE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 2, PowerName = "MELPOMINEE_POWER_2_NAME", Description = "MELPOMINEE_POWER_2_DESCRIPTION", System = "MELPOMINEE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "MELPOMINEE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 3, PowerName = "MELPOMINEE_POWER_3_NAME", Description = "MELPOMINEE_POWER_3_DESCRIPTION", System = "MELPOMINEE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "MELPOMINEE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 4, PowerName = "MELPOMINEE_POWER_4_NAME", Description = "MELPOMINEE_POWER_4_DESCRIPTION", System = "MELPOMINEE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "MELPOMINEE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 5, PowerName = "MELPOMINEE_POWER_5_NAME", Description = "MELPOMINEE_POWER_5_DESCRIPTION", System = "MELPOMINEE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "MELPOMINEE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "MELPOMINEE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "MELPOMINEE_KEY",
                    DisciplineName = "MELPOMINEE_NAME",
                    Description = "MELPOMINEE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class MytherceriaInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "MYTHERCERIA_POWER_1_NAME", Description = "MYTHERCERIA_POWER_1_DESCRIPTION", System = "MYTHERCERIA_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "MYTHERCERIA_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 2, PowerName = "MYTHERCERIA_POWER_2_NAME", Description = "MYTHERCERIA_POWER_2_DESCRIPTION", System = "MYTHERCERIA_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "MYTHERCERIA_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 3, PowerName = "MYTHERCERIA_POWER_3_NAME", Description = "MYTHERCERIA_POWER_3_DESCRIPTION", System = "MYTHERCERIA_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "MYTHERCERIA_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 4, PowerName = "MYTHERCERIA_POWER_4_NAME", Description = "MYTHERCERIA_POWER_4_DESCRIPTION", System = "MYTHERCERIA_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "MYTHERCERIA_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 5, PowerName = "MYTHERCERIA_POWER_5_NAME", Description = "MYTHERCERIA_POWER_5_DESCRIPTION", System = "MYTHERCERIA_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "MYTHERCERIA_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "MYTHERCERIA_KEY",
                    DisciplineName = "MYTHERCERIA_NAME",
                    Description = "MYTHERCERIA_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObeahInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBEAH_POWER_1_NAME", Description = "OBEAH_POWER_1_DESCRIPTION", System = "OBEAH_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "OBEAH_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 2, PowerName = "OBEAH_POWER_2_NAME", Description = "OBEAH_POWER_2_DESCRIPTION", System = "OBEAH_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "OBEAH_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 3, PowerName = "OBEAH_POWER_3_NAME", Description = "OBEAH_POWER_3_DESCRIPTION", System = "OBEAH_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "OBEAH_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 4, PowerName = "OBEAH_POWER_4_NAME", Description = "OBEAH_POWER_4_DESCRIPTION", System = "OBEAH_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "OBEAH_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 5, PowerName = "OBEAH_POWER_5_NAME", Description = "OBEAH_POWER_5_DESCRIPTION", System = "OBEAH_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "OBEAH_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBEAH_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBEAH_KEY",
                    DisciplineName = "OBEAH_NAME",
                    Description = "OBEAH_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObfuscateInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBFUSCATE_POWER_1_NAME", Description = "OBFUSCATE_POWER_1_DESCRIPTION", System = "OBFUSCATE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "OBFUSCATE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 2, PowerName = "OBFUSCATE_POWER_2_NAME", Description = "OBFUSCATE_POWER_2_DESCRIPTION", System = "OBFUSCATE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "OBFUSCATE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 3, PowerName = "OBFUSCATE_POWER_3_NAME", Description = "OBFUSCATE_POWER_3_DESCRIPTION", System = "OBFUSCATE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "OBFUSCATE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 4, PowerName = "OBFUSCATE_POWER_4_NAME", Description = "OBFUSCATE_POWER_4_DESCRIPTION", System = "OBFUSCATE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "OBFUSCATE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 5, PowerName = "OBFUSCATE_POWER_5_NAME", Description = "OBFUSCATE_POWER_5_DESCRIPTION", System = "OBFUSCATE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "OBFUSCATE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBFUSCATE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBFUSCATE_KEY",
                    DisciplineName = "OBFUSCATE_NAME",
                    Description = "OBFUSCATE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObtenebrationInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBTENEBRATION_POWER_1_NAME", Description = "OBTENEBRATION_POWER_1_DESCRIPTION", System = "OBTENEBRATION_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "OBTENEBRATION_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 2, PowerName = "OBTENEBRATION_POWER_2_NAME", Description = "OBTENEBRATION_POWER_2_DESCRIPTION", System = "OBTENEBRATION_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "OBTENEBRATION_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 3, PowerName = "OBTENEBRATION_POWER_3_NAME", Description = "OBTENEBRATION_POWER_3_DESCRIPTION", System = "OBTENEBRATION_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 4, PowerName = "OBTENEBRATION_POWER_4_NAME", Description = "OBTENEBRATION_POWER_4_DESCRIPTION", System = "OBTENEBRATION_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 5, PowerName = "OBTENEBRATION_POWER_5_NAME", Description = "OBTENEBRATION_POWER_5_DESCRIPTION", System = "OBTENEBRATION_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBTENEBRATION_KEY",
                    DisciplineName = "OBTENEBRATION_NAME",
                    Description = "OBTENEBRATION_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class PotenceInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "POTENCE_POWER_1_NAME", Description = "POTENCE_POWER_1_DESCRIPTION", System = "POTENCE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "POTENCE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 2, PowerName = "POTENCE_POWER_2_NAME", Description = "POTENCE_POWER_2_DESCRIPTION", System = "POTENCE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "POTENCE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 3, PowerName = "POTENCE_POWER_3_NAME", Description = "POTENCE_POWER_3_DESCRIPTION", System = "POTENCE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "POTENCE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 4, PowerName = "POTENCE_POWER_4_NAME", Description = "POTENCE_POWER_4_DESCRIPTION", System = "POTENCE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "POTENCE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 5, PowerName = "POTENCE_POWER_5_NAME", Description = "POTENCE_POWER_5_DESCRIPTION", System = "POTENCE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "POTENCE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "POTENCE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "POTENCE_KEY",
                    DisciplineName = "POTENCE_NAME",
                    Description = "POTENCE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class PresenceInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "PRESENCE_POWER_1_NAME", Description = "PRESENCE_POWER_1_DESCRIPTION", System = "PRESENCE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 2, PowerName = "PRESENCE_POWER_2_NAME", Description = "PRESENCE_POWER_2_DESCRIPTION", System = "PRESENCE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 3, PowerName = "PRESENCE_POWER_3_NAME", Description = "PRESENCE_POWER_3_DESCRIPTION", System = "PRESENCE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 4, PowerName = "PRESENCE_POWER_4_NAME", Description = "PRESENCE_POWER_4_DESCRIPTION", System = "PRESENCE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 5, PowerName = "PRESENCE_POWER_5_NAME", Description = "PRESENCE_POWER_5_DESCRIPTION", System = "PRESENCE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PRESENCE_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_NAME", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_DESCRIPTION", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_SYSTEM", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "PRESENCE_KEY",
                    DisciplineName = "PRESENCE_NAME",
                    Description = "PRESENCE_DESCRIPTION",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
