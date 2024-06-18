import CardPcsWithFourPics from "../../app/components/CardPcsWithFourPics";
import CardWithOnePic from "../../app/components/CardWithOnePic";
import CardWithMainAndMiniPics from "../../app/components/CardWithMainAndMiniPics";
import Hero from "../../app/layout/Hero";
import Chair from "../../app/assets/miniImages/chair.jpg";
import Headset from "../../app/assets/miniImages/headset.jpg";
import keyboard from "../../app/assets/miniImages/keyboard.jpg";
import Mouse from "../../app/assets/miniImages/mouse.jpg";
import DesktopSingleImage from "../../app/assets/miniImages/desktopSingleImage.jpg";
import Jeans from "../../app/assets/miniImages/DQC_APR_TBYB_W_BOTTOMS.jpg";
import Tops from "../../app/assets/miniImages/DQC_APR_TBYB_W_TOPS.jpg";
import Dresses from "../../app/assets/miniImages/DQC_APR_TBYB_W_DRESSES.jpg";
import Shoes from "../../app/assets/miniImages/DQC_APR_TBYB_W_SHOES.jpg";
import Bears from "../../app/assets/miniImages/bears.jpg";
import WomanWithIPhone from "../../app/assets/miniImages/woman_with_iphone.jpg";
import ManWithTablet from "../../app/assets/miniImages/man_with_tablet.jpg";
import WomanWithLap from "../../app/assets/miniImages/woman_with_lap.jpg";
import BoyWatchingTv from "../../app/assets/miniImages/boy_watching_tv.jpg";
import BasketHampers from "../../app/assets/miniImages/GW_EE_LaundryLuxe_D_Quad.jpg";
import Hardware from "../../app/assets/miniImages/GW_EE_Kitchen_D_Quad.jpg";
import AccentFurniture from "../../app/assets/miniImages/GW_EE_AccentFurniture_D_Quad.jpg";
import WallpaperPaint from "../../app/assets/miniImages/GW_EE_Hallway_D_Quad.jpg";
import Dining from "../../app/assets/miniImages/dining.jpg";
import Home from "../../app/assets/miniImages/home.jpg";
import Kitchen from "../../app/assets/miniImages/kitchen.jpg";
import HeathAndBaeuty from "../../app/assets/miniImages/health_and_beauty.jpg";
import DressesFashion from "../../app/assets/miniImages/dresses.jpg";
import Knits from "../../app/assets/miniImages/knits.jpg";
import Jackets from "../../app/assets/miniImages/jackes.jpg";
import Jewelry from "../../app/assets/miniImages/jewerly.jpg";

const gamingAccessoriesCardDetails = {
  title: "Gaming accessories",
  topRow: [
    {
      src: Headset,
      alt: "Headset",
      text: "Headsets",
    },
    {
      src: keyboard,
      alt: "Keyboard",
      text: "Keyboards",
    },
  ],

  lowRow: [
    {
      src: Mouse,
      alt: "Mouse",
      text: "Computer mice",
    },
    {
      src: Chair,
      alt: "Chair",
      text: "Chairs",
    },
  ],
  linkText: "See more",
};

const dealsPcsCardDetails = {
  title: "Deals in PCs",
  src: DesktopSingleImage,
  alt: "Desktop Single Image",
  linkText: "Shop now",
};

const shopDealsInFashion = {
  title: "Deals in fashion",
  topRow: [
    {
      src: Jeans,
      alt: "Jeans",
      text: "Jeans under 30$",
    },
    {
      src: Tops,
      alt: "Tops",
      text: "Tops under 25$",
    },
  ],

  lowRow: [
    {
      src: Dresses,
      alt: "Dresses",
      text: "Dresses under 30$",
    },
    {
      src: Shoes,
      alt: "Shoes",
      text: "Shoes under 50$",
    },
  ],
  linkText: "See all deals",
};

const bears = {
  title: "Toys under $25",
  src: Bears,
  alt: "Bears",
  linkText: "Shop now",
};

const amazonGadgetStore = {
  title: "Amazon Gadget Store",
  main: {
    src: WomanWithIPhone,
    alt: "Smart Phones",
    text: "SmartPhones",
  },
  mini: [
    {
      src: ManWithTablet,
      alt: "Tablets",
      text: "Tablets",
    },
    {
      src: WomanWithLap,
      alt: "Laptops",
      text: "Laptops",
    },
    {
      src: BoyWatchingTv,
      alt: "TVs",
      text: "TVs",
    },
  ],
  linkText: "See more from Amazon Gadget",
};

const easyUpdatedForElevatedSpaces = {
  title: "Easy updates for elevated spaces",
  topRow: [
    {
      src: BasketHampers,
      alt: "Basket & Hampers",
      text: "Basket & Hampers",
    },
    {
      src: Hardware,
      alt: "Hardware",
      text: "Hardware",
    },
  ],

  lowRow: [
    {
      src: AccentFurniture,
      alt: "Accent Furniture",
      text: "Accent furniture",
    },
    {
      src: WallpaperPaint,
      alt: "Wallpaper & Paint",
      text: "Wallpaper & paint",
    },
  ],

  linkText: "Shop home products",
};

const refreshYourSpace = {
  title: "Refresh your space",
  topRow: [
    {
      src: Dining,
      alt: "Dining",
      text: "Dining",
    },
    {
      src: Home,
      alt: "Home",
      text: "Home",
    },
  ],

  lowRow: [
    {
      src: Kitchen,
      alt: "Kitchen",
      text: "Kitchen",
    },
    {
      src: HeathAndBaeuty,
      alt: "Health & Beauty",
      text: "Health & Beauty",
    },
  ],

  linkText: "See more",
};

const fashionTrendsYouLike = {
  title: "Fashion trends you like",
  topRow: [
    {
      src: DressesFashion,
      alt: "Dresses",
      text: "Dresses",
    },
    {
      src: Knits,
      alt: "Knits",
      text: "Knits",
    },
  ],

  lowRow: [
    {
      src: Jackets,
      alt: "Jackets",
      text: "Jackets",
    },
    {
      src: Jewelry,
      alt: "Jewelry",
      text: "Jewelry",
    },
  ],

  linkText: "Explore more",
};

export default function HomePage() {
  return (
    <>
      <Hero />

      <main className="pb-60">
        <div className="container mx-auto mt-5">
          <section className="flex justify-center items-center flex-wrap gap-4">
            <CardPcsWithFourPics details={gamingAccessoriesCardDetails} />
            <CardPcsWithFourPics details={shopDealsInFashion} />
            <CardWithOnePic details={dealsPcsCardDetails} />
            <CardPcsWithFourPics details={refreshYourSpace} />
            <CardWithMainAndMiniPics details={amazonGadgetStore} />
            <CardPcsWithFourPics details={easyUpdatedForElevatedSpaces} />
            <CardWithOnePic details={bears} />
            <CardPcsWithFourPics details={fashionTrendsYouLike} />
          </section>
        </div>
      </main>
    </>
  );
}
