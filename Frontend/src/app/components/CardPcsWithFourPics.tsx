import { Card, CardBody, CardFooter, CardHeader } from "@nextui-org/react";
import SimpleCard from "./SimpleCard";

type Props = {
  details: {
    title: string;
    topRow: {
      src: string;
      alt: string;
      text: string;
    }[];
    lowRow: {
      src: string;
      alt: string;
      text: string;
    }[];
    linkText: string;
  };
};

export default function CardPcsWithFourPics({
  details: { title, topRow, lowRow, linkText },
}: Props) {
  return (
    <Card radius="none" className="p-2 md:max-w-[350px]">
      <CardHeader>
        <h2 className="text-xl font-bold">{title}</h2>
      </CardHeader>
      <CardBody className="flex flex-col justify-around">
        <div className="flex gap-3">
          {topRow.map((item, index) => (
            <SimpleCard
              key={index}
              src={item.src}
              alt={item.alt}
              title={item.text}
            />
          ))}
        </div>

        <div className="flex gap-3 mt-3">
          {lowRow.map((item, index) => (
            <SimpleCard
              key={index}
              src={item.src}
              alt={item.alt}
              title={item.text}
            />
          ))}
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
