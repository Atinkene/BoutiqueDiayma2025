# Boutique Diayma

##  Introduction
Ce projet est une application e-commerce de type boutique en ligne développée en **.NET Core 2.0** (obsolète, mise à jour recommandée).  
Elle permet de visualiser des produits, de gérer un panier et de passer des commandes.

---

### 1. Récupérez dans Visual Studio et exécutez le code fourni lien Github.

### 2. Quels sont les projets de la solution ?
### 3. Quelle est la version SDK .NET utilisée par ces projets ?
### 4. Installez le SDK

## 5. Trajet avant affichage des produits (Pas à pas détaillé)

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





### 6. Explorez l’application. Signalez 2 bugs trouvés ?
### 7. Placez un point d’arrêt sur les lignes suivantes du code :
#### a) CartSummaryViewComponent ligne 12
#### b) ProductController ligne 15
#### c) OrderController ligne 17
#### d) CartController ligne 15
#### e) Startup ligne 20
### 8. Quels sont les namespaces, classes et méthodes visités avant l’affichage des produits sur l’écran d’accueil de votre navigateur ? Choisissez le mode approprié selon le contexte, "Pas à pas détaillé", "Pas à pas principal" ou "Pas à pas sortant". Vos réponses doivent être détaillées dans le fichier README du dépôt.
### 9. Déployez votre solution sous forme d’exécutable Windows.
### 10. Fournir un lien drive Google, Onedrive etc. à l’exécutable ci-dessus.
### 11. Optionnel :
#### a) Ajoutez une langue d’affichage à l’interface, Wolof par exemple. Conservez les options de culture du français.
#### b) Procédez à 3 commits significatifs (changements importants) au moins.
#### c) Déposez le lien à votre dépôt github sur Google Classrooms.