type Props = {
  src: string;
  alt: string;
  title?: string;
};

export default function SimpleCard({ src, title, alt }: Props) {
  return (
    <div>
      <img src={src} alt={alt} title={title} />
      <span>{title}</span>
    </div>
  );
}
