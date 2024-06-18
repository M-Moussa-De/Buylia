import { Card, CardBody, CardFooter, CardHeader } from "@nextui-org/react";
import SimpleCard from "./SimpleCard";

type Details = {
  title: string;
  main: {
    src: string;
    alt: string;
    text: string;
  };
  mini: {
    src: string;
    alt: string;
    text: string;
  }[];
  linkText: string;
};

type Props = {
  details: Details;
};

export default function CardWithMainAndMiniPics({ details }: Props) {
  const { title, main, mini, linkText } = details;
  const { src, alt, text } = main;

  return (
    <Card radius="none" className="p-2 md:max-w-[350px]">
      <CardHeader>
        <h2 className="text-xl font-bold">{title}</h2>
      </CardHeader>
      <CardBody className="flex flex-col justify-around">
        {/* Main Image */}
        <div className="flex gap-3">
          <SimpleCard src={src} alt={alt} title={text} />
        </div>

        {/* Mini Images */}
        <div className="flex gap-3 mt-3">
          {mini.map(
            (
              item: { src: string; alt: string; text: string },
              index: number
            ) => (
              <SimpleCard
                key={index}
                src={item.src}
                alt={item.alt}
                title={item.text}
              />
            )
          )}
        </div>
      </CardBody>
      <CardFooter className="mt-3">
        <a href="/" className="text-green-700">
          {linkText}
        </a>
      </CardFooter>
    </Card>
  );
}
