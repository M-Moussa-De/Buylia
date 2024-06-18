import Logo from "../assets/logo.svg";
import CustomInput from "../components/CustomInput";
import { RxHamburgerMenu } from "react-icons/rx";
import { Button } from "@nextui-org/react";
import { MdFavoriteBorder } from "react-icons/md";
import { FiShoppingCart } from "react-icons/fi";
import { IoBagHandleOutline } from "react-icons/io5";
import { CiLocationOn } from "react-icons/ci";

const topRightEls = [
  {
    icon: <IoBagHandleOutline size={20} />,
    text: "Orders",
    url: "/orders",
  },
  {
    icon: <MdFavoriteBorder size={20} />,
    text: "Favorites",
    url: "/favorites",
  },
  {
    icon: <FiShoppingCart size={20} />,
    text: "Cart",
    url: "/cart",
  },
];

const bottomMiddelEls = [
  {
    text: "Home",
    url: "/",
  },
  {
    text: "New Arrivals",
    url: "/new-arrivals",
  },
  {
    text: "Best Sellers",
    url: "/best-sellers",
  },
  {
    text: "Trending",
    url: "/trending",
  },
  {
    text: "Deals",
    url: "/deals",
  },
];

const bottomRightEls = [
  {
    text: "About Us",
    url: "/about-us",
  },
  {
    text: "Contact",
    url: "/contact",
  },
];

export default function Header() {
  return (
    <header className="bg-white px-6 py-2 w-full">
      {/* Top */}
      <div className="w-full flex justify-between">
        {/* Left */}
        <div className="flex items-center">
          <img src={Logo} alt="" width={100} />
        </div>

        {/* Middel */}
        <div className="w-4/5 flex items-center justify-center">
          <div>
            <Button
              variant="bordered"
              startContent={<RxHamburgerMenu />}
              style={{ color: "#2AB1CE" }}
            >
              Categories
            </Button>
          </div>
          {/* Search */}
          <div className="ml-5 w-4/5">
            <CustomInput />
          </div>
        </div>

        {/* Right */}
        <div className="flex justify-between items-center">
          {topRightEls.map((el, index) => (
            <div key={index} className="flex items-center">
              <Button
                variant="solid"
                startContent={el.icon}
                className="bg-transparent"
                style={{ color: "#2AB1CE" }}
              >
                {el.text}
              </Button>
            </div>
          ))}
          <div className="ml-4">
            <Button
              color="default"
              variant="flat"
              size="md"
              radius="sm"
              className="text-md bg-gray-100"
              style={{ color: "#2AB1CE" }}
            >
              Sign In
            </Button>
          </div>
        </div>
      </div>
      {/* End Top */}

      {/* Bottom */}
      <nav className="mt-4">
        <div className="w-full flex justify-between">
          {/* Left */}
          <div>
            <Button
              variant="solid"
              startContent={<CiLocationOn size={20} />}
              className="bg-transparent pl-0"
              style={{ color: "#2AB1CE" }}
            >
              Germany
            </Button>
          </div>

          {/* Middel */}
          <div className="flex justify-between items-center">
            {bottomMiddelEls.map((el, index) => (
              <div key={index} className="flex items-center">
                <Button
                  variant="solid"
                  className="bg-transparent"
                  style={{ color: "#2AB1CE" }}
                >
                  {el.text}
                </Button>
              </div>
            ))}
          </div>
          {/* Middel End */}

          {/* Left */}
          <div className="flex items-center">
            {bottomRightEls.map((el, index) => (
              <div key={index} className="flex items-center">
                <Button
                  variant="solid"
                  className="bg-transparent"
                  style={{ color: "#2AB1CE" }}
                >
                  {el.text}
                </Button>
              </div>
            ))}
          </div>
          {/* Left End */}
        </div>
      </nav>
      {/* Bottom End  */}
    </header>
  );
}
