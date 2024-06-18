import { Card, CardHeader, CardBody, CardFooter } from "@nextui-org/react";
import SimpleCard from "./SimpleCard";

type Props = {
  details: {
    title: string;
    src: string;
    alt: string;
    linkText: string;
  };
};

export default function CardWithOnePic({
  details: { title, src, alt,  linkText },
}: Props) {
  return (
    <Card radius="none" className="p-2 md:max-w-[350px]">
      <CardHeader>
        <h2 className="text-xl font-bold">{title}</h2>
      </CardHeader>
      <CardBody className="flex flex-col justify-around">
        <SimpleCard src={src} alt={alt} />
      </CardBody>
      <CardFooter className="mt-3">
        <a href="/" className="text-green-700">
          {linkText}
        </a>
      </CardFooter>
    </Card>
  );
}
