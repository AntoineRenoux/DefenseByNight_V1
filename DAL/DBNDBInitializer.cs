using DAL.Models;
using DAL.Models.Ref;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBNDBInitializer : DropCreateDatabaseIfModelChanges<DBNContext>
    {
        protected override void Seed(DBNContext context)
        {
            #region Traduction

            //1036 : Français

            #region Labels

            var labels = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "GEN_LBL_SITE_NAME", Text = "Defense By Night"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONNEXION", Text = "Connexion"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_REGISTRATION", Text = "Inscription"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_FIRSTNAME", Text = "Prénom"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_LASTNAME", Text = "Nom de famille"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_EMAIL", Text = "Adresse mail"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_PASSWORD", Text = "Mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_BIRTHDATE", Text = "Date de naissance"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_ALIAS", Text = "Pseudo"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_ACCOUNT", Text = "Mon Compte"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_DISCONNECT", Text = "Déconnexion"},
            };

            labels.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            #endregion

            #region Messages d'erreurs
            var errorMessages = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_MISSING", Text = "Le prénom n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_LASTNAME_MISSING", Text = "Le nom de famille n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_EMAIL_MISSING", Text = "L'adresse mail n'est pas renseignée."},
                new Traduction{LCID = 1036, Key = "ERR_PASSWORD_MISSING", Text = "Le mot de passe n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_BIRTHDATE_MISSING", Text = "La date de naissance n'est pas renseignée."},
                new Traduction{LCID = 1036, Key = "ERR_ALIAS_MISSING", Text = "Le pseudo n'est pas renseigné."},

                new Traduction{LCID = 1036, Key = "ERR_PASSWORD_TO_SHORT", Text = "Le mot de passe doit faire au moins 6 carractères."},

                new Traduction{LCID = 1036, Key = "ERR_SIGNIN_FAIL", Text = "L'adresse mail ou le mot de passe est incorrecte."},
            };

            errorMessages.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

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

         

            #region Disciplines

            #region Animalisme
            var animalism = new Discipline
            {
                Name = "ANIMALISM_NAME",
                Description = "ANIMALISM_DESCRIPTION",
                Powers = new List<Power>()
            };

            context.Disciplines.Add(animalism);
            context.SaveChanges();

            var powers = new List<Power>
            {
                new Power { Level = 1, Name = "ANIMALISM_POWER_1_NAME", Discipline = animalism, Description = "ANIMALISM_POWER_1_DESCRIPTION", System = "ANIMALISM_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_1_EXCEPTIONALSUCCESS"},
                new Power { Level = 2, Name = "ANIMALISM_POWER_2_NAME", Discipline = animalism, Description = "ANIMALISM_POWER_2_DESCRIPTION", System = "ANIMALISM_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_2_EXCEPTIONALSUCCESS" },
                new Power { Level = 3, Name = "ANIMALISM_POWER_3_NAME", Discipline = animalism, Description = "ANIMALISM_POWER_3_DESCRIPTION", System = "ANIMALISM_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_3_EXCEPTIONALSUCCESS" },
                new Power { Level = 4, Name = "ANIMALISM_POWER_4_NAME", Discipline = animalism, Description = "ANIMALISM_POWER_4_DESCRIPTION", System = "ANIMALISM_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_4_EXCEPTIONALSUCCESS" },
                new Power { Level = 5, Name = "ANIMALISM_POWER_5_NAME", Discipline = animalism, Description = "ANIMALISM_POWER_5_DESCRIPTION", System = "ANIMALISM_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_5_EXCEPTIONALSUCCESS" }
            };

            powers.ForEach(p =>
            {
                context.Powers.Add(p);
            });

            context.SaveChanges();

            powers.ForEach(p =>
            {
                animalism.Powers.Add(p);
            });


            #region Traduction
            var animalismTraductions = new List<Traduction>
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

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang, utilisez votre action standard et faites un challenge opposé d’Aliénation avec votre cible. En cas de succès, vous pouvez soit diminuer, soit élever ses émotions pendant une heure. Si vous choisissez d’élever ses émotions, alors elle ressentira un flux d’émotions − désir désespéré, anxiété, joie ou inquiétude − poussé à l’extrême. Elle doit dépenser 1 point de Volonté à chaque fois que quelque chose de surprenant ou de perturbant arrive. Si elle ne le fait pas, elle réagit de manière démesurée, soit en fuyant, soit en frappant la source de son trouble. Si vous choisissez d’atténuer ses émotions, la cible ressentira une perte de son empathie ; son esprit ralentit et ses réactions, quelles qu’elles soient, deviennent froides et insipides.Elle ne ressent aucune réponse à un stimulus émotionnel, tel que l’amour, la haine ou la peur.Elle est simplement vide, à un point que cela en devient déconcertant.Un personnage aux émotions atténuées doit dépenser 1 point de Volonté pour engager un combat ou réagir avec une grande conviction.Elle n’a cependant pas besoin de dépenser de la Volonté pour se joindre à un combat commencé ou pour se défendre. Vous pouvez mettre fin aux effets d’une Passion en appliquant l’effet inverse(un personnage dont les émotions ont été atténuées est soigné en utilisant Passion pour accroître ses émotions)."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang, utilisez votre action standard et faites un challenge opposé d’Aliénation. En cas de succès, le subconscient de votre cible est envahi de visions, de sensations et de sons perturbants, qu’il est le seul à percevoir. Elle souffre d’un malus de -3 pour tout test d’attaque pour les 3 prochains tours, du fait qu’elle essaie (sans succès) de séparer réalité et fiction. Après ces 3 tours, le sujet commence à distinguer ce qui est réel de ce qui est imaginaire. Pendant 1 heure, la pénalité n’est plus que de -1. Les pénalités de Hantise Psychique ne s’appliquent pas aux tests de défense. Utiliser ce pouvoir sur un individu avec un dérangement lui donne 1 trait de dérangement. Plusieurs Hantises Psychiques ne se cumulent pas."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_SYSTEM", Text = "Ce pouvoir est toujours actif. Un personnage utilisant Vision du Chaos reçoit un bonus contextuel de +5 à n’importe quelle utilisation basique de la compétence Enquête ou à n’importe quel test de compétence Académique dans le but de casser un code, trouver une pièce manquante d’un puzzle ou combiner des indices. De plus, en faisant ce type de challenge, vous pouvez effectuer ce test sans interagir physiquement avec votre environnement, un simple coup d’œil autour de la zone (une action standard) est suffisant pour faire une recherche complète. Un personnage utilisant ce pouvoir peut passer quelques instants à scanner une pièce et réussir à découvrir un pistolet dissimulé dans une boîte à chaussures sous le lit, il peut jeter un regard sur une grille de mots-croisés et le résoudre en quelques instants ou il peut compter rapidement le nombre de dalles dans la pièce qu’il est en train de traverser."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_SYSTEM", Text = "Pour utiliser Voix de la Folie, vous devez avoir l’attention de la cible pendant au moins 5 tours (15 secondes) pour lui décrire le dérangement que vous voulez lui infliger. Quand vous avez fini cette description, dépensez 1 point de Sang et faites un challenge opposé contre votre cible. En cas de succès, vous infligez le dérangement de votre choix à votre cible pour le reste de la soirée et 1 trait de dérangement. Si l’individu dispose déjà de traits de dérangement, ce dernier peut causer un épisode psychotique (voir le chapitre sur les Dérangements). Par exemple, vous pouvez approcher le Primogène Ventrue et lui dire « J’ai vu 2 Brujahs tourner autour de votre voiture la nuit dernière. Que faisaient-ils ? Pensez-vous que les Brujahs soient dignes de confiance ? ». En cas de succès, avec cette phrase, vous pouvez donner le dérangement Phobie avec pour déclencheur « Brujah ». Un individu ne peut être affecté par ce pouvoir qu’une seule fois par utilisateur d’Aliénation. Si le même personnage tente d’infliger un second dérangement avant que le premier n’expire, le premier dérangement est remplacé par le second. Si un autre utilisateur d’Aliénation réussit à utiliser ce pouvoir sur une cible déjà affectée, les dérangements se cumulent."},
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

            animalismTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();

            #endregion

            #endregion
            #region Aliénation
            var dementation = new Discipline
            {
                Name = "DEMENTATION_NAME",
                Description = "DEMENTATION_DESCRIPTION",
                Powers = new List<Power>()
            };

            context.Disciplines.Add(dementation);
            context.SaveChanges();

            powers = new List<Power>
            {
                new Power { Level = 1, Name = "DEMENTATION_POWER_1_NAME", Discipline = dementation, Description = "DEMENTATION_POWER_1_DESCRIPTION", System = "DEMENTATION_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS"},
                new Power { Level = 2, Name = "DEMENTATION_POWER_2_NAME", Discipline = dementation, Description = "DEMENTATION_POWER_2_DESCRIPTION", System = "DEMENTATION_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS" },
                new Power { Level = 3, Name = "DEMENTATION_POWER_3_NAME", Discipline = dementation, Description = "DEMENTATION_POWER_3_DESCRIPTION", System = "DEMENTATION_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS" },
                new Power { Level = 4, Name = "DEMENTATION_POWER_4_NAME", Discipline = dementation, Description = "DEMENTATION_POWER_4_DESCRIPTION", System = "DEMENTATION_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS" },
                new Power { Level = 5, Name = "DEMENTATION_POWER_5_NAME", Discipline = dementation, Description = "DEMENTATION_POWER_5_DESCRIPTION", System = "DEMENTATION_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS" }
            };

            powers.ForEach(p =>
            {
                context.Powers.Add(p);
            });

            context.SaveChanges();

            powers.ForEach(p =>
            {
                dementation.Powers.Add(p);
            });
          
            #region Traduction
            var dementationTraductions = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DEMENTATION_NAME", Text = "Aliénation"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_DESCRIPTION", Text = "L’Étreinte ravage les esprits des Malkaviens, tordant et brisant leur psyché, mais étend leur conscience à un point où génie et folie semblent proches. Ils deviennent des visionnaires, catalyseurs de changements et de folies, portant à la fois sagesse et démence dans leur éveil. Le pouvoir d’Aliénation, leur discipline de référence, porte cette folie encore plus loin, la répandant à travers le monde. Cette discipline ouvre les portes du subconscient et libère l’ego, dévastant la logique de la victime et la supplantant par le chaos."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_NAME", Text = "Passion"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_NAME", Text = "Hantise psychique"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_NAME", Text = "Vision du Chaos"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_NAME", Text = "Voix de la Folie"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_NAME", Text = "Démence Absolue"},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_DESCRIPTION", Text = "Telle la ménade des temps anciens, vous pouvez élever les émotions à des sommets, faisant remonter les peurs, les désirs, le désespoir ou n’importe quelle envie irrépressible de votre cible à la surface. A l’inverse, vous pouvez aussi atténuer ces émotions, entraînant l’esprit dans un vide froid et rationnel."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_DESCRIPTION", Text = "Des visions cauchemardesques, des flashs à peine perceptibles, des échos surnaturels et des conversations incompréhensibles hantent votre victime, transformant le monde autour d’elle en une brume de rêve. Rien ne semble normal et d’étranges sensations parcourent la peau de la cible. Ses désirs subconscients font surface et ses peurs et ses regrets les plus profonds reviennent la hanter, tels de sombres murmures hallucinatoires du passé."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_DESCRIPTION", Text = "Il y a de la sagesse entre les fissures et les morceaux brisés de la réalité et il y a des leçons à apprendre en regardant l’univers s'effondrer lentement. Avec ce pouvoir, vous êtes à même de discerner des modèles complexes, de dévoiler des incohérences et de traquer les étranges et impalpables fils du destin"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_DESCRIPTION", Text = "Votre voix peut porter la démence du chant des sirènes et le murmure du pandémonium de la folie pure. En parlant d’une voix lourde et résonante, vous pouvez faire revivre les regrets, les peurs, la douleur, l’horreur et les souffrances de la vie et non-vie de votre cible, libérant son Ça et donnant les rênes à ses démons intérieurs."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_DESCRIPTION", Text = "En utilisant ce pouvoir, la folie absolue – l’éclatement total du miroir – est libérée au sein de l’esprit de votre victime. Vous faites remonter chaque sentiment d’insécurité, chaque affront oublié, chaque moment de panique ou chaque accès de colère et amplifiez ces blessures émotionnelles au centuple, causant des ravages sur l’esprit de votre cible."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_SYSTEM", Text = "Sens Accrus est toujours actif. La vision accrue d’un personnage lui permet de voir clairement, même dans l’obscurité la plus totale, et lui permet de comprendre des sons trop faibles pour que des personnes normales les entendent. Lorsqu’un personnage avec Sens Accrus se situe à moins de deux pas d’un individu dissimulé par des moyens surnaturels, comme avec Occultation, le personnage avec Sens Accrus réalise automatiquement que quelqu’un est proche, bien qu’il ne sache ni l’identité ni l’emplacement de cette personne. Sens Accrus ne donne qu’une vague sensation que quelque chose n’est pas normal. Lorsque que quelque chose vous aveugle, votre ouïe peut fournir une compensation adéquate pour la perte de votre vue. Normalement, les personnages qui ne peuvent voir pendant un combat doivent utiliser la Manœuvre de combat Combat en Aveugle. Tant que l’ouïe de votre personnage est intacte, vous pouvez vous battre sans passer par la Manœuvre de combat Combat en Aveugle. Si vous dépensez 1 point de Sang et faites une action standard, votre personnage peut améliorer ses sens de manière plus poussée. Si vous procédez ainsi, vous remarquez n’importe quel objet ordinaire caché dans votre champ de vision et vous pouvez faire un challenge en opposition en utilisant le Score de Test d’Auspex pour distinguer les détails de n’importe quel objet ou personne dissimulé avec des pouvoirs surnaturels, de même avec les objets illusoires, ou les objets et personnes déguisés par des pouvoirs surnaturels. Si vous percez un pouvoir surnaturel de cette manière, vous pouvez ignorer les utilisations de ce même pouvoir par le même utilisateur pendant les cinq prochaines minutes. Si vous possédez plus de niveaux d’Auspex que votre cible possède du pouvoir qu’elle est en train d’utiliser pour générer l’Occultation (ou l’illusion), les effets perçants du pouvoir persistent pendant une heure au lieu de cinq minutes."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang et une action standard pour faire un challenge en opposition contre votre cible. Si vous réussissez, votre personnage peut lire les détails de l’aura de la cible. Typiquement, l’examen est visuel, mais n’importe quel sens physique approprié peut être utilisé. Si vous réussissez, vous pouvez discerner le type de créature de votre cible (vampire, goule, vampire possédant un mortel, etc…), l’humeur générale, toute tendance violente immédiate et si la cible a diablé ou non lors de l’année passée. Ce pouvoir ne vous permet pas de lire dans les pensées ou de détecter la vérité. Si vous échouez au challenge en opposition, l’aura de votre cible est trop trouble pour la discerner clairement. Les détails sont trop flous et aucune couleur ou motif en particulier ne semble dominant. Le coût en Sang pour activer Perception de l’Aura est nul si la cible ne s’oppose pas au challenge."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_SYSTEM", Text = "Dépensez 1 point de Sang et une action standard pour toucher un objet. Vous pouvez alors poser au Conteur une de ces questions et une question supplémentaire par cinq minutes de concentration du personnage sur l’objet ou le lieu : • Montre - moi la dernière personne qui a tenu l’objet. • Votre personnage reçoit une vision de la dernière personne qui a utilisé l’objet.La vision montre en général le dernier individu significatif et non la dernière personne à avoir touché l’objet. • Comment l’individu est-il mort ? • Cette question ne peut être posée que lorsque Psychométrie est utilisée sur(tout ou partie d’) un cadavre. Votre personnage reçoit une vision des derniers moments de la vie de la cible. • Quand(ou comment) l’objet a t - il été utilisé pour la dernière fois ? • Votre personnage reçoit une image de la plus récente utilisation de l’objet et de sa cible(un couteau attaquant, avec l’apparition de la victime, des jumelles regardant en bas, montrant la voiture du Prince, etc.).Si l’objet a été utilisé dans un événement émotionnellement chargé, comme un meurtre ou un vol, votre personnage reçoit un bref aperçu de l’émotion et de son lien avec l’objet. • Y a-t - il des émotions fortes liées à l’objet ? • Si quelqu’un aime ou déteste l’objet, ou si des émotions profondes sont liées à l’usage de l’objet, votre personnage reçoit cette information. Elle peut dater d’un certain temps, en fonction de la nature de l’objet et de ses associations. Certains objets ou lieux ont des émotions particulièrement fortes liées à eux. Votre Conteur peut décider de fournir une ou plusieurs réponses gratuitement lorsqu’un personnage utilise Psychométrie sur une cible chargée émotionnellement.Les personnages utilisant n’importe quel niveau d’Occultation et qui utilisent l’objet ou visitent un lieu, ne laissent aucune empreinte psychique. Pour les usages de ce pouvoir, les cadavres(y compris les cadavres de créatures surnaturelles et les cendres de vampires) comptent comme des objets et peuvent être ciblés par Psychométrie. Les vampires qui n’ont pas rencontré leur Mort Finale ne comptent pas comme des cadavres."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_SYSTEM", Text = "Pour activer Télépathie sur une cible volontaire, dépensez simplement 1 point de Sang. Aucun challenge n’est nécessaire et la cible peut être localisée n’importe où dans la même ville (ou un rayon de 80 km de l’emplacement de votre personnage). Cet usage de Télépathie ne nécessite pas spécifiquement de ligne de vue. La Télépathie permet au personnage et à sa cible d’envoyer et recevoir messages mentaux et simples images. Si vous tentez d’utiliser Télépathie sur une cible non volontaire, vous devez dépenser 1 point de Sang et faire un challenge en opposition contre la cible, qui doit être dans votre champ de vision. Si vous réussissez, votre personnage peut envoyer une image ou un bref message (quelque chose pouvant être dit en moins de 10 secondes) à la cible. Alternativement, votre personnage peut extirper une image ou une information spécifique de l’esprit de la cible involontaire. L’information reçue de cette manière doit répondre à l’une de ces questions suivantes (selon votre convenance) : • • À quoi êtes - vous en train de penser ? • • À quoi ressemble la personne ou la chose que vous venez juste de décrire ? • Où se trouve la personne ou l’objet dont vous venez juste de parler ? • • Est - ce que vous aimez ou détestez la personne à qui vous êtes en train de parler ? • Qu’avez - vous l’intention de faire dans les cinq prochaines minutes ? Si un personnage volontaire devient réticent pendant un échange télépathique, le personnage utilisant Télépathie doit immédiatement dépenser 1 point de Sang et réussir un challenge en opposition ou être éjecté de l’esprit de la cible désormais non volontaire. Lorsque vous communiquez avec une cible volontaire, une utilisation simple de Télépathie dure une heure mais vous ne pouvez communiquer qu’avec une seule personne en même temps.Si vous activez Télépathie sur une seconde cible, le premier lien se coupe immédiatement. Un individu ne peut pas utiliser d’autres pouvoirs(comme les pouvoirs de Domination − Injonction, Suggestion, ou Esprit Distrait) en conjonction avec Télépathie. Le télépathe a le choix de se faire connaître ou non pendant la communication. Dans le cas où il ne le ferait pas, la cible peut déterminer l’identité du télépathe en réussissant un challenge en opposition de Perception."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_SYSTEM", Text = "Pour activer Projection Astrale, vous devez dépenser 1 point de Sang et une action standard pour méditer. Cette dépense permet à votre personnage de projeter sa conscience en dehors de sa forme physique. Lorsqu’un personnage est en Projection Astrale, son corps est dans un état similaire à la torpeur. Si son corps est endommagé, la Projection Astrale cesse automatiquement et la conscience de l’individu retourne immédiatement dans son corps. La Projection Astrale d’un personnage est une version idéalisée de son apparence normale. Bien que cette image puisse revêtir des habits dorés, être entourée d’un halo de lumière argenté, ou avoir une fourrure épaisse, elle est toujours reconnaissable comme étant votre personnage. Une forme psychique peut voyager à environ 80 km par heure et traverser des objets solides, mais ne peut interagir avec le monde physique de quelle que manière que ce soit. Les seuls pouvoirs que vous pouvez utiliser pendant la Projection Astrale sont les quatre premiers niveaux d’Auspex ; vous ne pouvez pas utiliser d’autres disciplines, de pouvoirs d’Anciens d’Auspex ou de techniques(même celles basées sur l’Auspex) pendant que vous êtes dans cet état. Une forme psychique est invisible à ceux qui ne possèdent pas Sens Accrus ou des capacités surnaturelles similaires. Vous pouvez dépenser 1 point de Sang pour vous manifester(votre corps d’origine dépense ce Sang), rendant votre forme psychique visible comme si elle était matériellement présente pour un tour seulement.Bien que le personnage soit encore intangible et ne puisse interagir physiquement, une forme psychique manifestée peut être vue et entendue normalement et être ciblée par des pouvoirs Sociaux ou Mentaux par ceux dans le monde matériel. Les individus avec Sens Accrus ou des capacités surnaturelles similaires peuvent voir les vagues contours d’un individu en Projection Astrale, même si cet individu ne s’est pas manifesté, mais l’observateur ne peut distinguer de détails, voir les mouvements ou entendre la voix projetée du personnage sauf s’il se manifeste. Deux individus qui sont tous deux en Projection Astrale peuvent interagir entre eux normalement et peuvent même se battre à coups de poing oupar des attaques Physiques non armées. Un coup réussi d’un autre individu sous cette forme n’inflige pas de dégâts; cela coûte à la place 1 point de Volonté à la victime. Si la victime n’a plus de Volonté, la Projection Astrale cesse immédiatement et ne peut être réactivée pendant 10 minutes. Rappelez - vous que seuls les 4 premiers niveaux d’Auspex peuvent être utilisés en Projection Astrale; un personnage ne peut utiliser d’autres pouvoirs (même contre un autre individu en projection astrale) et ne possède aucun équipement autre que de simples vêtements dans cet état."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", Text = "Un personnage spécialisé en Perception peut aiguiser ses sens en dépensant une action simple, au lieu d’une action standard."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", Text = "Si votre cible se situe dans les limites de trois pas, votre personnage ne dépense pas de Sang pour activer Perception de l’Aura, que la cible soit volontaire ou non. Si la cible n’est pas volontaire, vous devez quand même faire un challenge en opposition pour utiliser ce pouvoir."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", Text = "Quand vous activez Psychométrie, vous pouvez poser trois questions au lieu d’une."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez maintenir Télépathie avec jusqu’à trois cibles volontaires, vous permettant de tenir une conversation avec tous les participants en même temps. Les participants peuvent vous parler ou échanger entre eux par contact télépathique. Vous devez dépenser 1 point de Sang par cible. Pour faire venir un nouvel individu dans le lien, vous dépensez alors le Sang nécessaire. Vous pouvez éjecter quelqu’un de votre lien sans couper la communication avec les autres impliqués."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", Text = "En plus de l’Auspex, vous pouvez utiliser les deux premiers niveaux de n’importe quelle discipline Sociale ou Mentale de clan que vous possédez. C’est une exception à la règle contre l’utilisation d’autres disciplines en Projection Astrale. Votre personnage utilise ses pouvoirs normalement lorsqu’il en vise d’autres dans le plan psychique. Si votre personnage se manifeste, il peut également utiliser ses disciplines sur des cibles du monde matériel pendant sa manifestation. Puissance, Célérité et Force d’âme ne peuvent jamais être utilisées en Projection Astrale ni les pouvoirs nécessitant un contact, sauf s’ils sont utilisés contre d’autres individus psychiquement projetés."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS", Text = "Si vous remportez un succès exceptionnel lorsque que vous tentez de voir à travers une occultation surnaturelle, vous percerez automatiquement n’importe quelle Occultation (ou illusion) créée par le même individu pendant la prochaine heure."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS", Text = "Pour la prochaine heure, vous continuez à percevoir l’aura de la cible sans dépense supplémentaire de Sang et sans faire de challenge. Si son humeur change ou si elle devient agressive, vous aurez un avertissement préalable. En terme de mécanisme, si votre cible démarre un combat, vous pouvez faire une action simple avant qu’elle ne fasse n’importe quelle action. Cet avertissement ne vous donne pas une action supplémentaire, mais vous permet d’agir en avance."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS", Text = "Vous pouvez poser deux des questions ci-dessus (au lieu d’une) avec chaque challenge réussi lorsque vous extirpez des informations de l’esprit de votre cible."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS", Text = null}
            };

            dementationTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion
            #endregion

            #endregion

            #endregion

            #region Users
            var users = new List<User>
            {
                new User{Alias="Zesso", FirstName="Antoine", LastName="Renoux", BirthDate = new DateTimeOffset(1992, 2, 13, 0, 0, 0, new TimeSpan(0, 0, 0)), Email = "zesso@gmail.com", Password = "5S5rtlEb$"}
            };

            users.ForEach(u =>
            {
                context.Users.Add(u);
            });

            context.SaveChanges();
            #endregion

        }
    }
}
