import { Spinner } from "@nextui-org/react";

interface Props {
  message?: string;
}

export default function LoadingComponent({ message = "Loading..." }: Props) {
  return (
    <div className="flex justify-center items-center h-full">
      <div
        style={{
          textAlign: "center",
          justifyContent: "center",
          position: "fixed",
          top: "55%",
        }}
      >
        <Spinner label={message} size="md" />
      </div>
    </div>
  );
}
