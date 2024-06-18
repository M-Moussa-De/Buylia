import Slider from "react-slick";
import BeautyProducts from "../assets/hero/beauty.jpg";
import Books from "../assets/hero/books.jpg";
import Kitchen from "../assets/hero/kitchen.jpg";

export default function Hero() {
  const settings = {
    dots: false,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 8000,
    arrows: true,
  };

  return (
    <div className="slider-container" id="hero">
      <Slider {...settings}>
        <div>
          <img src={BeautyProducts} alt="" />
        </div>
        <div>
          <img src={Books} alt="" />
        </div>
        <div>
          <img src={Kitchen} alt="" />
        </div>
      </Slider>
    </div>
  );
}
