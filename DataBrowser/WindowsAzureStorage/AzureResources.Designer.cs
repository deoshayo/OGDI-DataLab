﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18033
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ogdi.InteractiveSdk.Mvc {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AzureResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AzureResources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ogdi.InteractiveSdk.Mvc.AzureResources", typeof(AzureResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Container cannot be null.
        /// </summary>
        internal static string ContainerCannotBeNull {
            get {
                return ResourceManager.GetString("ContainerCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Container and tableName should be non-numeric.
        /// </summary>
        internal static string ContainerTableNameNonNumeric {
            get {
                return ResourceManager.GetString("ContainerTableNameNonNumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à x-ms-continuation-NextPartitionKey.
        /// </summary>
        internal static string continuation_nextPartionKey {
            get {
                return ResourceManager.GetString("continuation_nextPartionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à x-ms-continuation-NextRowKey.
        /// </summary>
        internal static string continuation_nextRowKey {
            get {
                return ResourceManager.GetString("continuation_nextRowKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à EntityMetadata.
        /// </summary>
        internal static string metaDataTableName {
            get {
                return ResourceManager.GetString("metaDataTableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à http://www.w3.org/2005/Atom.
        /// </summary>
        internal static string nsAtom {
            get {
                return ResourceManager.GetString("nsAtom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à http://schemas.microsoft.com/ado/2007/08/dataservices.
        /// </summary>
        internal static string nsDataServices {
            get {
                return ResourceManager.GetString("nsDataServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à http://schemas.microsoft.com/ado/2007/08/dataservices/metadata.
        /// </summary>
        internal static string nsMetadata {
            get {
                return ResourceManager.GetString("nsMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Page size should not be zero or negative.
        /// </summary>
        internal static string PagesizeNotZEROOrNegative {
            get {
                return ResourceManager.GetString("PagesizeNotZEROOrNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à TableName cannot be null.
        /// </summary>
        internal static string TableNameCannotBeNull {
            get {
                return ResourceManager.GetString("TableNameCannotBeNull", resourceCulture);
            }
        }
    }
}
