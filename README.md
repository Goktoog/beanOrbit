# beanOrbit 
Bu proje, Unity öğrenme sürecimde yaptığım ilk 2D oyun projelerinden birisi. Oyuncu, uzayda ilerlerken asteroitlerden kaçmaya çalışır. Oyuncu, uzayda ilerlerken asteroitlerden kaçmaya çalışır ve her başarılı kaçışta puanı artar. Zamanında dünyaca popüler olan ayrıca o zamana göre çekici bir mekaniği bulunan Flappy bird oyununun geleneksel kalıplarını kullanarak biraz değiştirilmiş versiyonudur. Kısaca bir runner oyunudur.

##  Özellikler:

- `GameManager` sınıfı ile oyun durumu (Menu, Playing, GameOver) yönetimi
- `GameManager` ve `score` sınıflarında **Singleton yapısı** kullanımı
- `PlayerPrefs` ile yüksek skor kayıt sistemi
- UI kullanımı (Canvas, TextMeshPro, Butonlar)
- Game Over ekranı ve yeniden başlatma (SceneManager ile sahne yükleme)
- Basit 2D çarpışma kontrolü ve skor artırma mantığı
- Hareket eden asteroitler

## Nasıl Oynanır:
Oldukça basit şekilde astroidlerden kaçmak için ekrana dokunmak gerekiyor bu benim ilk mobil 2D oyun girişimim.


##  Öğrendiğim Yapılar:

Bu projede:
- Singleton yapısını nasıl kullanacağımı
- Oyun durumlarını enum yapısıyla nasıl yöneteceğimi
-Particle System (Karakter öldüğünde patlama efekti için)
- Temel UI elementleri ile kullanıcıya nasıl etkileşim sunacağımı
- PlayerPrefs ile veri kaydetmeyi
- Zaman kontrolü (`Time.timeScale`) ve sahne yeniden başlatma gibi temel mekanikleri öğrendim
-Sonsuz arkaplan kaydırma sistemi (Draw Mode ve Wrap Mode ayarları)


## Görseller:

Main Menu Ekranı
↓↓↓
![mainMenu](https://github.com/user-attachments/assets/3c06f2fb-a7f7-4cfc-b9d9-0c195c4801d6)

Game Over Ekranı:
↓↓↓
![GameOver](https://github.com/user-attachments/assets/a7fa2507-fee2-4d35-bc83-0e7a83ed14e4)

Oynanış:
↓↓↓
![Ingame](https://github.com/user-attachments/assets/b9c4b0f8-8c87-4344-bd83-ba4e5b341392)








