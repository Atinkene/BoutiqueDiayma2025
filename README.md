# Boutique Diayma

##  Introduction
Ce projet est une application e-commerce de type boutique en ligne développée en **.NET Core 2.0** (obsolète, mise à jour recommandée).  
Elle permet de visualiser des produits, de gérer un panier et de passer des commandes.

---

### 1. Récupérez dans Visual Studio et exécutez le code fourni lien Github.
![Description de l’image](https://drive.google.com/uc?export=view&id=1ztNuRwtq8Vp2ZIpBcOcLn_YONq5Vu8GI)

![Description de l’image](https://drive.google.com/uc?export=view&id=1acG4bmHBvrMIOWzrbGnpngrae3-mGFLA)

![Description de l’image](https://drive.google.com/uc?export=view&id=1N7Ia010URIC53qRbHfxNv0WBv73TB2QS)


---


### 2. Quels sont les projets de la solution ?
La solution ne comporte qu’un seul projet nommé **Diayma**

![Description de l’image](https://drive.google.com/uc?export=view&id=1N7Ia010URIC53qRbHfxNv0WBv73TB2QS)


---


### 3. Quelle est la version SDK .NET utilisée par ces projets ?
La version du SDK .NET utilisée par le projet est la **2.0**.
![Description de l’image](https://drive.google.com/uc?export=view&id=1CcW5xLtLYKt7Md1g3Dlgc71ZTfV8yZfN)


---


### 4. Installez le SDK
![Description de l’image](https://drive.google.com/uc?export=view&id=1nb1xv__u3MGzm67TuL9QXU98L-M6a3l5)

![Description de l’image](https://drive.google.com/uc?export=view&id=1YkryHj8lJs-kzO5-ll8kJzJ_x4CLG-C9)


---


### 5. Créez votre propre dépôt GitHub pour y stocker le code
![Description de l’image](https://drive.google.com/uc?export=view&id=1J2JL7MOEW4v7mSSUdp9h_-cAuS_EAZ8g)


---


## 6. Explorez l’application. Signalez 2 bugs trouvés ?


###  **Bug #1 : Pas de limite de quantité à l'ajout au panier + Stock non mis à jour après l'achat**

**Localisations** : 
- `CartController.cs`, méthode `AddToCart` (avant correction)
- `ProductRepository.cs`, données en mémoire

**Description** :
1. **Absence de vérification du stock lors de l'ajout au panier** : Aucune limite n'était appliquée lors de l'ajout d'articles au panier. Un utilisateur pouvait ajouter plus d'articles qu'il n'y en avait en stock.

2. **Stock non persiste après l'achat** : Le stock était stocké en mémoire (liste statique) et réinitialisé à chaque redémarrage de l'application, causant la perte de toutes les modifications de stock.




![img1](https://drive.google.com/uc?export=view&id=1nyd24nu9RdEuXiNKRyO-6Bg1lGF2GlPz)

![img2](https://drive.google.com/uc?export=view&id=1aliDEMPaTonUdUEnhP8O2Hl7TbLHuphD)

![img3](https://drive.google.com/uc?export=view&id=167xLC9TKUkaUep3a2JOTzkr6tUjycDTp)

![img4](https://drive.google.com/uc?export=view&id=11AdxUHo4_2nrVK6U917qOuMv0H3Zo-SI)

![img5](https://drive.google.com/uc?export=view&id=1iA8frkhlKMzXQX4iYPqdbG20-wYtpQK2)

![img6](https://drive.google.com/uc?export=view&id=1sxsSZr9XWLD8CJWn-02quj7XP6y4ReUm)

![img7](https://drive.google.com/uc?export=view&id=1hLcNL5SvHH3fVX52m_rIAnQMWfSfK7eh)

![img8](https://drive.google.com/uc?export=view&id=1WMizrmuWEV0OzOeAEP2Xihfy45MEmGq5)

![img9](https://drive.google.com/uc?export=view&id=1Q3Chw-ClUSo1VcsVPXK-hBE4sOJokBGG)

![img10](https://drive.google.com/uc?export=view&id=1obtIqYrkUWyYootuTxoNPEoeT_N04zfI)

![img11](https://drive.google.com/uc?export=view&id=1A1jcsNYLAFZhqB-JLG0LXiYcYCSTwjNp)

![img12](https://drive.google.com/uc?export=view&id=1CFZ7Hx2Cpbn9GYm90dzVH_SgebBwNkZB)

![img13](https://drive.google.com/uc?export=view&id=1_0qGbsuf5Goi2Nwq4o7ZtoZErlOCcWBc)

![img14](https://drive.google.com/uc?export=view&id=1oBDvmJiZop82_aNl2C94RXodKrQ3jfDl)

![img15](https://drive.google.com/uc?export=view&id=1jY5hPtXDLf6TV-eWIlNtZf-NdrR63gG7)


---



## 7. Placez un point d’arrêt sur les lignes suivantes du code :

  ## a) CartSummaryViewComponent ligne 12
![Description de l’image](https://drive.google.com/uc?export=view&id=1J2JL7MOEW4v7mSSUdp9h_-cAuS_EAZ8g)

  ## b) ProductController ligne 15
![Description de l’image](https://drive.google.com/uc?export=view&id=1dUgnTTx-ESAlLbCSzPaiV7ikt9UJv5Cu)

  ## c) OrderController ligne 17
![Description de l’image](https://drive.google.com/uc?export=view&id=18-HxLdXXXWa6dgrRUKRZmS0OMdkFkhiM)

  ## d) CartController ligne 15
![Description de l’image](https://drive.google.com/uc?export=view&id=1GH3ShY-1Qs15sUDWHw4__6dmZv-3kq86)

  ## e) Startup ligne 20
![Description de l’image](https://drive.google.com/uc?export=view&id=1oqQWqdfm1Nv7hNRsThE2Wf71Eed4Wqms)


---


## 8. Quels sont les namespaces, classes et méthodes visités avant l’affichage des produits sur l’écran d’accueil de votre navigateur ? Choisissez le mode approprié selon le contexte, "Pas à pas détaillé", "Pas à pas principal" ou "Pas à pas sortant". Vos réponses doivent être détaillées dans le fichier README du dépôt.
  
  ## Trajet avant affichage des produits (Pas à pas détaillé)

En mode **Pas à pas détaillé**, la pile complète des appels avant l’affichage des produits sur l’écran d’accueil est la suivante :

```text
P2FixAnAppDotNetCode.Program.Main(string[] args) Ligne 10
P2FixAnAppDotNetCode.Program.BuildWebHost(string[] args) Ligne 14
P2FixAnAppDotNetCode.Startup.Startup(IConfiguration configuration) Ligne 20
P2FixAnAppDotNetCode.Startup.ConfigureServices(IServiceCollection services) Ligne 27
P2FixAnAppDotNetCode.Startup.Configure(IApplicationBuilder app, IHostingEnvironment env) Ligne 64
P2FixAnAppDotNetCode.Startup.ConfigureServices.AnonymousMethod__4_2(RequestLocalizationOptions opts) Ligne 44
P2FixAnAppDotNetCode.Startup.Configure(IApplicationBuilder app, IHostingEnvironment env) Ligne 67
P2FixAnAppDotNetCode.Startup.ConfigureServices.AnonymousMethod__4_0(LocalizationOptions opts) Ligne 28
P2FixAnAppDotNetCode.Startup.ConfigureServices.AnonymousMethod__4_1(LocalizationOptions opts) Ligne 40
P2FixAnAppDotNetCode.Startup.Configure.AnonymousMethod__5_0(IRouteBuilder routes) Ligne 70
P2FixAnAppDotNetCode.Startup.Configure(IApplicationBuilder app, IHostingEnvironment env) Ligne 69
P2FixAnAppDotNetCode.Program.BuildWebHost(string[] args) Ligne 14
P2FixAnAppDotNetCode.Program.Main(string[] args) Ligne 10
P2FixAnAppDotNetCode.Controllers.ProductController.ProductController(IProductService productService, ILanguageService languageService) Ligne 15
P2FixAnAppDotNetCode.Controllers.ProductController.Index() Ligne 20
P2FixAnAppDotNetCode.Models.Services.ProductService.GetAllProducts() Ligne 25
P2FixAnAppDotNetCode.Models.Repositories.ProductRepository.GetAllProducts() Ligne 42
P2FixAnAppDotNetCode.Models.Repositories.ProductRepository.GetAllProducts.AnonymousMethod__3_0(Product p) Ligne 43
P2FixAnAppDotNetCode.Models.Repositories.ProductRepository.GetAllProducts() Ligne 43
P2FixAnAppDotNetCode.Models.Services.ProductService.GetAllProducts() Ligne 29
P2FixAnAppDotNetCode.Controllers.ProductController.Index() Ligne 21
P2FixAnAppDotNetCode.Components.CartSummaryViewComponent.CartSummaryViewComponent(ICart cart) Ligne 12
P2FixAnAppDotNetCode.Components.CartSummaryViewComponent.Invoke() Ligne 16
AspNetCore._Views_Shared__Layout_cshtml.ExecuteAsync.AnonymousMethod__22_6() Ligne 22
P2FixAnAppDotNetCode.Components.LanguageSelectorViewComponent.Invoke(ILanguageService languageService) Ligne 9
AspNetCore._Views_Shared__Layout_cshtml.ExecuteAsync.AnonymousMethod__22_6() Ligne 33
```


---


## 9. Déployez votre solution sous forme d’exécutable Windows.

![img1](https://drive.google.com/uc?export=view&id=1RrHnQ6Uhb2sxrJjJ1lcWIROMDK3GwY1a)

![img2](https://drive.google.com/uc?export=view&id=1ukpi2d3XerY-dgh9XkR1RN9K7VUa3eh-)

![img3](https://drive.google.com/uc?export=view&id=1CHeAZYP4zNsjiS9Kx4ik1gUVms7S3xlW)

![img4](https://drive.google.com/uc?export=view&id=1aOyphYFg1K1iNl3JX3Cb2MLI__Db4jwE)

![img5](https://drive.google.com/uc?export=view&id=1cVk8fpr--3xpm5U6GNBslzSlKk3BCJSx)

![img6](https://drive.google.com/uc?export=view&id=1Nx0r9ECQ0FE4cc91dY5liQweGzLwQSuF)

![img7](https://drive.google.com/uc?export=view&id=1FKXzmXFXrjYLB6Iz7PEy-ZUBCwuFrD2r)

![img8](https://drive.google.com/uc?export=view&id=1iD7AyMnpHumYUMbVprsi0DiA0bmjXg3G)

![img9](https://drive.google.com/uc?export=view&id=1e9aunZyj3E995K05_9NiSLfhdv4hBxsa)



---


## 10. Fournir un lien drive Google, Onedrive etc. à l’exécutable ci-dessus.
[Accéder au dossier Drive](https://drive.google.com/drive/folders/1PzseFm_jL4y-gHHDaOoeX0hSnbZEKXSP?usp=drive_link)


---


## 11. Optionnel :
  ## a) Ajoutez une langue d’affichage à l’interface, Wolof par exemple. Conservez les options de culture du français.
![Image 1](https://drive.google.com/uc?export=view&id=1sgYuq5rVWAgokY7QdrjxzFemvay9R_-O)

![Image 2](https://drive.google.com/uc?export=view&id=1kIszu-KU_DvjX1niV4cFlpNlzrMIrVOH)

![Image 3](https://drive.google.com/uc?export=view&id=16c89roYg2JRKg6HH94pkfmlBXyFhZQ3L)

![Image 4](https://drive.google.com/uc?export=view&id=1JJVlh-RgvrMsfTF9-vrtT4HIVzBSgdZ5)


  ## b) Procédez à 3 commits significatifs (changements importants) au moins.

  ## Ajouts et améliorations des langues
- **Support de la culture wolof** : Intégration complète de la langue wolof permettant de traduire toutes les pages de l'application.  
- **Support de la culture espagnole** : Ajout de la langue espagnole pour permettre l'affichage des pages en espagnol.  
- **Mise à jour du README** : Documentation complétée pour inclure les nouvelles langues et cultures disponibles.

  ## Améliorations de l'interface et de l'expérience utilisateur (UX)
- Optimisation de l'expérience utilisateur pour rendre l'interface plus intuitive.  
- Gestion améliorée des messages et notifications utilisateurs pour plus de clarté.

  ## Gestion des commandes et du stock
- Validation du stock disponible avant la sauvegarde des commandes pour éviter les erreurs et ruptures.

![Image](https://drive.google.com/uc?export=view&id=1-NMtFVpWcTjwm-Su4waQrMqNSMNtxe2k)

![Image 1](https://drive.google.com/uc?export=view&id=159JVy6WH7gFIiwDy5rkSraEvQDBtPTR7)

![Image 2](https://drive.google.com/uc?export=view&id=1zC3fTdZ-uPdHCLe-mzB_OL9e0YgoTaHP)

![Image 3](https://drive.google.com/uc?export=view&id=12tZeyd3CCuzbzOgfPO-KgCa2wTs7bd8c)

![Image 4](https://drive.google.com/uc?export=view&id=1BKSSmy30fSKRcCgAuZHaqOaVjNfsz38-)


  ## c) Déposez le lien à votre dépôt github sur Google Classrooms.

## Dépôt GitHub

[Accéder au dépôt BoutiqueDiayma2025](https://github.com/Atinkene/BoutiqueDiayma2025.git)
